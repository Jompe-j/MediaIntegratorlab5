namespace MediaIntegrator {
    partial class MediaIntegratorForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.watchedFolderButton = new System.Windows.Forms.Button();
            this.targetFolderButton = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.watchedFolderLabel = new System.Windows.Forms.Label();
            this.targetFolderLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // watchedFolderButton
            // 
            this.watchedFolderButton.Location = new System.Drawing.Point(12, 12);
            this.watchedFolderButton.Name = "watchedFolderButton";
            this.watchedFolderButton.Size = new System.Drawing.Size(111, 42);
            this.watchedFolderButton.TabIndex = 0;
            this.watchedFolderButton.Text = "Select folder to watch";
            this.watchedFolderButton.UseVisualStyleBackColor = true;
            this.watchedFolderButton.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // targetFolderButton
            // 
            this.targetFolderButton.Location = new System.Drawing.Point(12, 60);
            this.targetFolderButton.Name = "targetFolderButton";
            this.targetFolderButton.Size = new System.Drawing.Size(111, 42);
            this.targetFolderButton.TabIndex = 0;
            this.targetFolderButton.Text = "Select save folder";
            this.targetFolderButton.UseVisualStyleBackColor = true;
            this.targetFolderButton.Click += new System.EventHandler(this.targetFolderButton_Click);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(12, 108);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(111, 42);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "Run Watcher";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runWatcher_Click);
            // 
            // watchedFolderLabel
            // 
            this.watchedFolderLabel.Location = new System.Drawing.Point(129, 27);
            this.watchedFolderLabel.Name = "watchedFolderLabel";
            this.watchedFolderLabel.Size = new System.Drawing.Size(223, 25);
            this.watchedFolderLabel.TabIndex = 1;
            // 
            // targetFolderLabel
            // 
            this.targetFolderLabel.Location = new System.Drawing.Point(129, 75);
            this.targetFolderLabel.Name = "targetFolderLabel";
            this.targetFolderLabel.Size = new System.Drawing.Size(223, 25);
            this.targetFolderLabel.TabIndex = 1;
            // 
            // statusLabel
            // 
            this.statusLabel.Location = new System.Drawing.Point(129, 123);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(223, 25);
            this.statusLabel.TabIndex = 1;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.Filter = "*.csv";
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(this.file_Created);
            // 
            // MediaIntegratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 165);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.targetFolderLabel);
            this.Controls.Add(this.watchedFolderLabel);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.targetFolderButton);
            this.Controls.Add(this.watchedFolderButton);
            this.Name = "MediaIntegratorForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.IO.FileSystemWatcher fileSystemWatcher1;

        private System.Windows.Forms.Label targetFolderLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label watchedFolderLabel;

        private System.Windows.Forms.Button targetFolderButton;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button watchedFolderButton;

        #endregion
    }
}