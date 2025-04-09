
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace JavaJDKDetector
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadJDKs();
        }

        private void LoadJDKs()
        {
            string[] possiblePaths = {
                @"C:\Program Files\Java\",
                @"C:\Program Files (x86)\Java\"
            };

            foreach (var basePath in possiblePaths)
            {
                if (Directory.Exists(basePath))
                {
                    var jdkDirs = Directory.GetDirectories(basePath, "jdk*", SearchOption.TopDirectoryOnly);
                    foreach (var dir in jdkDirs)
                    {
                        comboBoxJDKs.Items.Add(dir);
                    }
                }
            }

            if (comboBoxJDKs.Items.Count > 0)
            {
                comboBoxJDKs.SelectedIndex = 0;
                textBoxPath.Text = comboBoxJDKs.SelectedItem.ToString();
            }
        }

        private void btnSetJAVA_HOME_Click(object sender, EventArgs e)
        {
            string selectedPath = comboBoxJDKs.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedPath))
            {
                Environment.SetEnvironmentVariable("JAVA_HOME", selectedPath, EnvironmentVariableTarget.User);
                MessageBox.Show($"JAVA_HOME set to:\n{selectedPath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBoxJDKs_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxPath.Text = comboBoxJDKs.SelectedItem?.ToString();
        }

        private void btnCopyPath_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxPath.Text))
            {
                Clipboard.SetText(textBoxPath.Text);
                MessageBox.Show("Path copied to clipboard.", "Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
