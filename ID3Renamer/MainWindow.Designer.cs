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
            this.buttonFindFiles = new System.Windows.Forms.Button();
            this.listDirectories = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxParentDirectory = new System.Windows.Forms.TextBox();
            this.buttonBrowseParentDirectory = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panel = new System.Windows.Forms.Panel();
            this.buttonCTC = new System.Windows.Forms.Button();
            this.textBoxErrors = new System.Windows.Forms.TextBox();
            this.labelErrorReporting = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFindFiles
            // 
            this.buttonFindFiles.Location = new System.Drawing.Point(222, 189);
            this.buttonFindFiles.Name = "buttonFindFiles";
            this.buttonFindFiles.Size = new System.Drawing.Size(75, 23);
            this.buttonFindFiles.TabIndex = 0;
            this.buttonFindFiles.Text = "List Files";
            this.buttonFindFiles.UseVisualStyleBackColor = true;
            this.buttonFindFiles.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // listDirectories
            // 
            this.listDirectories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(303, 189);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 23);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Change Files";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
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
            // panel
            // 
            this.panel.Controls.Add(this.buttonCTC);
            this.panel.Controls.Add(this.textBoxErrors);
            this.panel.Controls.Add(this.labelErrorReporting);
            this.panel.Controls.Add(this.buttonExit);
            this.panel.Location = new System.Drawing.Point(0, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(415, 214);
            this.panel.TabIndex = 8;
            this.panel.Visible = false;
            // 
            // buttonCTC
            // 
            this.buttonCTC.Location = new System.Drawing.Point(222, 178);
            this.buttonCTC.Name = "buttonCTC";
            this.buttonCTC.Size = new System.Drawing.Size(111, 23);
            this.buttonCTC.TabIndex = 3;
            this.buttonCTC.Text = "Copy To Clipboard";
            this.buttonCTC.UseVisualStyleBackColor = true;
            this.buttonCTC.Click += new System.EventHandler(this.buttonCTC_Click);
            // 
            // textBoxErrors
            // 
            this.textBoxErrors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxErrors.CausesValidation = false;
            this.textBoxErrors.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxErrors.Location = new System.Drawing.Point(17, 36);
            this.textBoxErrors.MaxLength = 3276753;
            this.textBoxErrors.Multiline = true;
            this.textBoxErrors.Name = "textBoxErrors";
            this.textBoxErrors.Size = new System.Drawing.Size(385, 136);
            this.textBoxErrors.TabIndex = 2;
            // 
            // labelErrorReporting
            // 
            this.labelErrorReporting.AutoSize = true;
            this.labelErrorReporting.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.labelErrorReporting.Location = new System.Drawing.Point(12, 9);
            this.labelErrorReporting.Name = "labelErrorReporting";
            this.labelErrorReporting.Size = new System.Drawing.Size(61, 23);
            this.labelErrorReporting.TabIndex = 1;
            this.labelErrorReporting.Text = "Report";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(339, 178);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(64, 23);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Back";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(415, 240);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxParentDirectory);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listDirectories);
            this.Controls.Add(this.buttonFindFiles);
            this.Controls.Add(this.buttonBrowseParentDirectory);
            this.Name = "MainWindow";
            this.Text = "ID3 Renamer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFindFiles;
        private System.Windows.Forms.ListBox listDirectories;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelStatus;
        private System.Windows.Forms.TextBox textBoxParentDirectory;
        private System.Windows.Forms.Button buttonBrowseParentDirectory;
        private System.Windows.Forms.Button buttonStart;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonCTC;
        private System.Windows.Forms.TextBox textBoxErrors;
        private System.Windows.Forms.Label labelErrorReporting;
    }
}

