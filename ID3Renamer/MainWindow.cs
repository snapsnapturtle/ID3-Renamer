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
using System.Reflection;

namespace ID3Renamer
{
    public partial class MainWindow : Form
    {
        string errors;

        int fileCount;
        int currentNumber;
        int alreadyExist = 0;
        int changed = 0;

        delegate string SomeDelegate(FileInfo fileInfo, string directory);

        public MainWindow()
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
                fileCount = 0;
                listDirectories.Items.Clear();

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
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            textBoxParentDirectory.Text = directory;
            textBoxParentDirectory.Text = directory;
            processDirectory(directory);
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
                        currentNumber++;
                        return fileInfo.Name;
                    }

                    else
                    {
                        File.Move(fileInfo.FullName, directory + newFileName + ".mp3");
                        currentNumber++;
                        changed++;
                        return fileInfo.Name;
                    }
                    
                }

                catch (Exception ex)
                {
                    currentNumber++;
                    errors += ex.Message + Environment.NewLine + fileInfo.FullName + Environment.NewLine + Environment.NewLine;
                }
            }
            
            return "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            progressBar.Maximum = listDirectories.Items.Count;
            lockCrontrols();
            panel.Visible = true;
            buttonCTC.Visible = false;
            buttonExit.Visible = false;
            labelErrorReporting.Text = "Working...";
            textBoxErrors.Text = "Renaming Files";
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
                backgroundWorker.ReportProgress(1);

                string output = result;
                try { output = result.Substring(0, 40); } catch(Exception ex) {}

                labelStatus.Text = output;
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            buttonCTC.Visible = true;
            buttonExit.Visible = true;
            labelErrorReporting.Text = "Error Reporting";
            textBoxErrors.Text = changed.ToString() + " Files have been renamed" + Environment.NewLine;
            if (alreadyExist != 0) textBoxErrors.Text += "No changes made to " + alreadyExist.ToString() + " Files";
            textBoxErrors.Text += Environment.NewLine + Environment.NewLine;
            textBoxErrors.Text += errors;
            panel.Visible = true;
            labelStatus.Text = "Ready";
            progressBar.Visible = false;
            progressBar.Maximum = 100;
            listDirectories.Items.Clear();
            unlockCrontrols();
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = currentNumber;
        }

        private void lockCrontrols()
        {
            textBoxParentDirectory.Enabled = false;
            buttonStart.Enabled = false;
            listDirectories.Enabled = false;
            buttonFindFiles.Enabled = false;
            buttonStart.Enabled = false;
            buttonBrowseParentDirectory.Enabled = false;
        }

        private void unlockCrontrols()
        {
            textBoxParentDirectory.Enabled = true;
            buttonStart.Enabled = true;
            listDirectories.Enabled = true;
            buttonFindFiles.Enabled = true;
            buttonStart.Enabled = true;
            buttonBrowseParentDirectory.Enabled = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            processDirectory(textBoxParentDirectory.Text);
            panel.Visible = false;
        }

        private void buttonCTC_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(textBoxErrors.Text);
            labelStatus.Text = "Report copied...";
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            backgroundWorker.CancelAsync();
        }
    }
}
