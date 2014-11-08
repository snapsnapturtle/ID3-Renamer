using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using File = System.IO.File;
using System.Text.RegularExpressions;

namespace ID3Renamer
{
    public partial class Form1 : Form
    {
        string errors;

        int fileCount;
        int alreadyExist = 0;
        delegate string SomeDelegate(FileInfo fileInfo, string directory);

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            labelStatus.Text = "Getting MP3 Files";

            string directory = textBoxParentDirectory.Text;
            processDirectory(directory);
        }

        public void processDirectory(string directory)
        {
            listDirectories.Items.Clear();

            if (Directory.Exists(directory))
            {
                string[] files = Directory.GetFiles(directory, "*.mp3", SearchOption.AllDirectories);
                foreach (string file in files)
                {
                    listDirectories.Items.Add(file);
                    fileCount++;
                }

                if (fileCount == 1) labelStatus.Text = fileCount + " Item";
                else labelStatus.Text = fileCount + " Items";
            }

            else
            {
                labelStatus.Text = "Directory is not valid";
            }
        }

        private void buttonBrowseParentDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browseDirectory = new FolderBrowserDialog();
            if (browseDirectory.ShowDialog() == DialogResult.OK)
            {
                string directory = browseDirectory.SelectedPath;
                textBoxParentDirectory.Text = directory;
                processDirectory(directory);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxParentDirectory.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private string changeMp3(FileInfo fileInfo, string directory)
        {
            using (var mp3 = TagLib.File.Create(fileInfo.FullName))
            {
                var newFileName = string.Format("{0} {1}", mp3.Tag.Track, mp3.Tag.Title);

                try
                {
                    string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
                    Regex r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));

                    newFileName = r.Replace(newFileName, "");

                    if (File.Exists(directory + newFileName + ".mp3"))
                    {
                        alreadyExist++;
                        return fileInfo.Name;
                    }

                    else
                    {
                        File.Move(fileInfo.FullName, directory + newFileName + ".mp3");
                        return fileInfo.Name;
                    }
                    
                }

                catch (Exception ex)
                {
                    errors += ex.Message + Environment.NewLine + fileInfo.FullName + Environment.NewLine + Environment.NewLine;
                }
            }

            return "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (string file in listDirectories.Items)
            {
                FileInfo info = new FileInfo(file);
                string directory = Path.GetDirectoryName(file) + "\\";

                SomeDelegate sd = changeMp3;
                IAsyncResult asyncRes = sd.BeginInvoke(info, directory, null, null);
                string result = sd.EndInvoke(asyncRes);
                labelStatus.Text = result;
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show(errors + Environment.NewLine + alreadyExist.ToString());
            labelStatus.Text = "Ready";
        }
    }
}
