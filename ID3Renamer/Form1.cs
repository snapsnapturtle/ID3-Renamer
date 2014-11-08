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

namespace ID3Renamer
{
    public partial class Form1 : Form
    {

        int fileCount;

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

                if (fileCount == 1) labelStatus.Text = fileCount + " Item Loaded";
                else labelStatus.Text = fileCount + " Items Loaded";
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
    }
}
