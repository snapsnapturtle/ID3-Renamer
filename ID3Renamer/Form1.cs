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

namespace ID3Renamer
{
    public partial class Form1 : Form
    {

        int fileCount;
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
                    File.Move(fileInfo.FullName, directory + newFileName + ".mp3");
                    string finished = fileInfo.Name + newFileName;
                    return finished;
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
