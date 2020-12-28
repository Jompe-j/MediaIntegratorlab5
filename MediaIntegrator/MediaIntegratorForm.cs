using System;
using System.Diagnostics;
using System.IO;
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
            MessageBox.Show($@" new file! names {e.Name}");

            var fr = File.ReadAllLines(e.FullPath);

            foreach (var s in fr) {
                Debug.WriteLine(s);
            }

            var inventory = new InventoryMigrator();
            var xmlInventory = inventory.GenerateXml(fr);

            xmlInventory.Save(Path.Combine(_targetFolderPath, "inventory.xml"));
        }
    }
}