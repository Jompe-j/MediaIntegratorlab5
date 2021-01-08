using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace MediaIntegrator {
    public partial class MediaIntegratorForm : Form {
        private string _watchFolderPath;
        private string _targetFolderPath;

        public MediaIntegratorForm() {
            InitializeComponent();
        }

        private void runWatcher_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(_watchFolderPath) || string.IsNullOrWhiteSpace(_targetFolderPath)) return;

            statusLabel.Text = "Running...";
            fileSystemWatcher1.Path = _watchFolderPath;
            fileSystemWatcher1.EnableRaisingEvents = true;
        }

        private void selectFolder_Click(object sender, EventArgs e) {
            fileSystemWatcher1.EnableRaisingEvents = false;
            var fbd = new FolderBrowserDialog();
            var result = fbd.ShowDialog();

            if (result != DialogResult.OK || string.IsNullOrWhiteSpace(fbd.SelectedPath)) return;

            _watchFolderPath = fbd.SelectedPath;
            watchedFolderLabel.Text = _watchFolderPath;
        }

        private void targetFolderButton_Click(object sender, EventArgs e) {
            fileSystemWatcher1.EnableRaisingEvents = false;
            var fbd = new FolderBrowserDialog();
            var result = fbd.ShowDialog();

            if (result != DialogResult.OK || string.IsNullOrWhiteSpace(fbd.SelectedPath)) return;

            _targetFolderPath = fbd.SelectedPath;
            targetFolderLabel.Text = _targetFolderPath;
        }

        private void file_Created(object sender, FileSystemEventArgs e) {
            var worked = true;
            var tries = 0;
            do {
                try {
                    var allLines = File.ReadAllLines(e.FullPath);

                    var xmlInventory = InventoryMigrator.GenerateSimpleMediaXmlFromMyStoreCsv(allLines);

                    xmlInventory.Save(Path.Combine(_targetFolderPath, "inventory.xml"));
                }
                catch (IOException exception) {
                    Debug.WriteLine(exception);
                    //Handles issues if several files are put into the watched folder to quickly. 
                    worked = false;
                    if (tries < 10) {
                        tries++;
                        Thread.Sleep(500);
                    }
                    else {
                        worked = true;
                    }
                }
            } while (!worked);
        }
    }
}