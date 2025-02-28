using BlackOps3MapLanguageFixer.Properties;
using System;
using System.Windows.Forms;

namespace BlackOps3MapLanguageFixer {
	public partial class SettingsForm : Form {
		public SettingsForm() {
			InitializeComponent();
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e) {
			if (radioButton1.Checked) {
				Settings.Default.renamefix = true;
			}
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e) {
			if (radioButton2.Checked) {
				Settings.Default.renamefix = false;
			}

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e) {
			if (checkBox1.Checked) {
				Settings.Default.overwrite = true;
			} else {
				Settings.Default.overwrite = false;
			}
		}

		private void SettingsForm_Load(object sender, EventArgs e) {
			textBox1.Text = Settings.Default.steamfolder;
			radioButton1.Checked = Settings.Default.renamefix;
			radioButton2.Checked = !Settings.Default.renamefix;
			checkBox1.Checked = Settings.Default.overwrite;
			checkBox2.Checked = Settings.Default.fixsounds;
		}

		private void button1_Click(object sender, EventArgs e) {
			FolderBrowserDialog dialog = new FolderBrowserDialog();
			if (dialog.ShowDialog() == DialogResult.OK) {
				textBox1.Text = dialog.SelectedPath;
				Settings.Default.steamfolder = textBox1.Text;
				Settings.Default.Save();
			}
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e) {
			if (checkBox2.Checked) {
				Settings.Default.fixsounds = true;
			} else {
				Settings.Default.fixsounds = false;
			}
		}
	}
}
