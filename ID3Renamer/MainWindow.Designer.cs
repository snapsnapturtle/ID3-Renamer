namespace ID3Renamer
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStart = new System.Windows.Forms.Button();
            this.listDirectories = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxParentDirectory = new System.Windows.Forms.TextBox();
            this.buttonBrowseParentDirectory = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelAlpha = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(222, 189);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "List Files";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // listDirectories
            // 
            this.listDirectories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listDirectories.FormattingEnabled = true;
            this.listDirectories.Location = new System.Drawing.Point(12, 38);
            this.listDirectories.Name = "listDirectories";
            this.listDirectories.ScrollAlwaysVisible = true;
            this.listDirectories.Size = new System.Drawing.Size(391, 145);
            this.listDirectories.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Firebrick;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 218);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(415, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip";
            // 
            // labelStatus
            // 
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(39, 17);
            this.labelStatus.Text = "Ready";
            // 
            // textBoxParentDirectory
            // 
            this.textBoxParentDirectory.Location = new System.Drawing.Point(12, 12);
            this.textBoxParentDirectory.Name = "textBoxParentDirectory";
            this.textBoxParentDirectory.Size = new System.Drawing.Size(321, 20);
            this.textBoxParentDirectory.TabIndex = 3;
            // 
            // buttonBrowseParentDirectory
            // 
            this.buttonBrowseParentDirectory.Location = new System.Drawing.Point(339, 11);
            this.buttonBrowseParentDirectory.Name = "buttonBrowseParentDirectory";
            this.buttonBrowseParentDirectory.Size = new System.Drawing.Size(64, 22);
            this.buttonBrowseParentDirectory.TabIndex = 4;
            this.buttonBrowseParentDirectory.Text = "Browse";
            this.buttonBrowseParentDirectory.UseVisualStyleBackColor = true;
            this.buttonBrowseParentDirectory.Click += new System.EventHandler(this.buttonBrowseParentDirectory_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Change Files";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(280, 223);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(123, 13);
            this.progressBar.TabIndex = 6;
            this.progressBar.Visible = false;
            // 
            // labelAlpha
            // 
            this.labelAlpha.AutoSize = true;
            this.labelAlpha.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelAlpha.ForeColor = System.Drawing.Color.LightGray;
            this.labelAlpha.Location = new System.Drawing.Point(5, 181);
            this.labelAlpha.Name = "labelAlpha";
            this.labelAlpha.Size = new System.Drawing.Size(107, 37);
            this.labelAlpha.TabIndex = 7;
            this.labelAlpha.Text = "ALPHA";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(415, 240);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxParentDirectory);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listDirectories);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonBrowseParentDirectory);
            this.Controls.Add(this.labelAlpha);
            this.Name = "MainWindow";
            this.Text = "ID3 Renamer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ListBox listDirectories;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelStatus;
        private System.Windows.Forms.TextBox textBoxParentDirectory;
        private System.Windows.Forms.Button buttonBrowseParentDirectory;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelAlpha;
    }
}

