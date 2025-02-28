using BlackOps3MapLanguageFixer.Properties;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackOps3MapLanguageFixer {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private const string workshopFolder = "\\steamapps\\workshop\\content\\311210\\";
		private const string gameFolder = "\\steamapps\\common\\Call of Duty Black Ops III\\";
		private string fullFolder;
		private int filesCounter = 0;

		public static string GetSpecificSteamLibraryPath() {
			if (IsAdministrator()) {
				return FindSteamLibraryPathWithWorkshopContent();
			} else {
				Console.WriteLine("Insufficient privileges. Steam library path not retrieved.");
				return null;
			}
		}

		public static bool IsAdministrator() {
			WindowsIdentity identity = WindowsIdentity.GetCurrent();
			WindowsPrincipal principal = new WindowsPrincipal(identity);
			return principal.IsInRole(WindowsBuiltInRole.Administrator);
		}

		private static string FindSteamLibraryPathWithWorkshopContent() {
			try {
				string steamPath = GetSteamPathFromRegistry();

				if (!string.IsNullOrEmpty(steamPath)) {
					string libraryFoldersVdfPath = Path.Combine(steamPath, "steamapps", "libraryfolders.vdf");

					if (File.Exists(libraryFoldersVdfPath)) {
						string[] lines = File.ReadAllLines(libraryFoldersVdfPath);

						foreach (string line in lines) {
							if (line.Contains("\"path\"")) {
								string path = line.Split('"')[3];
								string normalizedPath = path.Replace("\\\\", "\\");
								string workshopContentPath = Path.Combine(normalizedPath, "steamapps", "workshop", "content", "311210");

								if (Directory.Exists(workshopContentPath)) {
									return normalizedPath; // Found the path!
								}
							}
						}
					}
				}
			} catch (Exception ex) {
				Console.WriteLine($"Error finding Steam library path: {ex.Message}");
			}

			return null; // Path not found.
		}

		public static string GetSteamPathFromRegistry() {
			try {
				using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Valve\Steam")) {
					if (key != null) {
						object steamPathObject = key.GetValue("SteamPath");
						if (steamPathObject != null) {
							return steamPathObject.ToString();
						}
					}
				}
			} catch (Exception ex) {
				Console.WriteLine($"Error getting Steam path: {ex.Message}");
			}

			return null;
		}

		private void Form1_Load(object sender, EventArgs e) {
			Settings.Default.Reload();
			fullFolder = Properties.Settings.Default.steamfolder + workshopFolder;
			if (IsAdministrator()) {
				autoDetectSteamLibraryFolderrequiresAdministratorToolStripMenuItem.ForeColor = Color.FromArgb(0, 192, 0);
			}
			filesCounter = 0;
			loadComboBox();
		}

		private void loadComboBox() {
			foreach (object item in comboBox1.Items) {
				if (Settings.Default.gamelang != null && item.ToString().EndsWith(Settings.Default.gamelang)) {
					comboBox1.SelectedItem = item;
					break;
				}
			}
		}
		private async void button1_Click(object sender, EventArgs e) {
			filesCounter = 0;
			await Fix();
			MessageBox.Show("Fixed (" + filesCounter + ") files.");
		}

		public async Task Fix() {
			await Task.Run(() => {
				if (!System.IO.Directory.Exists(fullFolder)) {
					MessageBox.Show("Unknown steam path: '" + Settings.Default.steamfolder + "' please change it to your steam folder.");
					return;
				}
				if (Settings.Default.gamelang == null || Settings.Default.gamelang.Equals("")) {
					MessageBox.Show("You didn't select your game language", "Game language", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				Array.ForEach(Directory.GetDirectories(fullFolder), mapPath => {
					//DirectoryInfo dir = new DirectoryInfo(mapPath);
					//FileInfo[] filesInfo = dir.GetFiles("en_*.ff OR en_*.xpak");
					var filteredFiles = Directory
					.EnumerateFiles(mapPath)
					.Where(file => (file.ToLower().EndsWith(".ff") && Path.GetFileName(file).StartsWith("en_")) || (file.ToLower().EndsWith(".xpak") && Path.GetFileName(file).StartsWith("en_")))
					.Select(filePath => new FileInfo(filePath))
					.ToArray();

					bool fixsounds = Settings.Default.fixsounds;

					string sndPath = null;
					if (fixsounds) {
						sndPath = Directory.GetDirectories(mapPath)
						.Where(dirName => Path.GetFileName(dirName).Equals("snd"))
						.FirstOrDefault();
					}

					if (Settings.Default.renamefix) {
						Array.ForEach(filteredFiles, file => {
							string oldSimpleName = file.Name;
							string newName = file.FullName.Replace("en_", Settings.Default.gamelang + "_");
							if (!File.Exists(newName)) {
								file.MoveTo(newName);
								String newSimpleName = new FileInfo(newName).Name;
								richTextBox1.Invoke((MethodInvoker)delegate {
									richTextBox1.AppendText("> Renamed '" + oldSimpleName + "' to '" + newSimpleName + "'\n");
								});

								filesCounter++;
							}
						});
						if (fixsounds && sndPath != null) {
							string englishsndpath = Directory.GetDirectories(sndPath)
							.Where(dirName => Path.GetFileName(dirName).Equals("en"))
							.FirstOrDefault();
							if (englishsndpath != null) {
								string[] parts = englishsndpath.Split(new[] { Path.DirectorySeparatorChar }, StringSplitOptions.None);
								int lastEnIndex = Array.LastIndexOf(parts, "en");

								if (lastEnIndex == -1) {
									Console.WriteLine("'en' not found in the directory path.");
									return;
								}

								parts[lastEnIndex] = Settings.Default.gamelang;
								string destinationDirectory = string.Join(Path.DirectorySeparatorChar.ToString(), parts);
								Directory.CreateDirectory(destinationDirectory);
								CopyFilesWithEnReplacement(englishsndpath, destinationDirectory, Settings.Default.gamelang);
							}
						}
					} else {

						Array.ForEach(filteredFiles, file => {
							string oldSimpleName = file.Name;
							string newName = file.FullName.Replace("en_", Settings.Default.gamelang + "_");
							if (!File.Exists(newName)) {
								file.CopyTo(newName, Settings.Default.overwrite);
								String newSimpleName = new FileInfo(newName).Name;
								richTextBox1.Invoke((MethodInvoker)delegate {
									richTextBox1.AppendText("> Copied '" + oldSimpleName + "' as '" + newSimpleName + "'\n");
								});
								filesCounter++;
							}
						});
						if (fixsounds && sndPath != null) {
							string englishsndpath = Directory.GetDirectories(sndPath)
							.Where(dirName => Path.GetFileName(dirName).Equals("en"))
							.FirstOrDefault();
							if (englishsndpath != null) {
								string[] parts = englishsndpath.Split(new[] { Path.DirectorySeparatorChar }, StringSplitOptions.None);
								int lastEnIndex = Array.LastIndexOf(parts, "en");

								if (lastEnIndex == -1) {
									Console.WriteLine("'en' not found in the directory path.");
									return;
								}

								parts[lastEnIndex] = Settings.Default.gamelang;
								string destinationDirectory = string.Join(Path.DirectorySeparatorChar.ToString(), parts);
								Directory.CreateDirectory(destinationDirectory);
								CopyFilesWithEnReplacement(englishsndpath, destinationDirectory, Settings.Default.gamelang);
							}
						}
					}
				});
			});
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
			//Settings.Default.gamelang = comboBox1.SelectedItem.ToString();
			string language = comboBox1.SelectedItem.ToString();
			string shortcut = language.Substring(language.IndexOf("-") + 2, language.Length - language.IndexOf("-") - 2);
			Settings.Default.gamelang = shortcut;
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
			Settings.Default.Save();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
			Settings.Default.Save();
			MessageBox.Show("Settings saved.");
		}

		private void changeSteamFolderToolStripMenuItem_Click(object sender, EventArgs e) {
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			if (fbd.ShowDialog() == DialogResult.OK) {
				Settings.Default.steamfolder = fbd.SelectedPath;
				fullFolder = Properties.Settings.Default.steamfolder + workshopFolder;
				Settings.Default.Save();
			}
		}

		private void openSteamFolderInExplorerToolStripMenuItem_Click(object sender, EventArgs e) {
			Process.Start("explorer.exe", Settings.Default.steamfolder);
		}

		private void openBO3WorkshopFolderToolStripMenuItem_Click(object sender, EventArgs e) {
			Process.Start("explorer.exe", fullFolder);
		}

		private async void button2_Click(object sender, EventArgs e) {
			await Fix();
			if (filesCounter == 0) {
				richTextBox1.Invoke((MethodInvoker)delegate {
					richTextBox1.AppendText("0 Files to fix.\n");
				});
			}
			FileInfo t7Patch = new FileInfo(Settings.Default.steamfolder + gameFolder + "t7patch_2.03.exe");
			string t7PatchPath = Directory.EnumerateFiles(Settings.Default.steamfolder + gameFolder)
				.Where(f => f.Contains("t7patch") && f.EndsWith(".exe"))
				.First();
			t7Patch = new FileInfo(t7PatchPath);
			if (t7Patch.Exists) {
				richTextBox1.Invoke((MethodInvoker)delegate {
					richTextBox1.AppendText("Found T7 Patch. Starting...\n");
				});
				Process.Start(t7Patch.FullName);
			}
			richTextBox1.Invoke((MethodInvoker)delegate {
				richTextBox1.AppendText("Starting game...\n");
			});
			await Task.Run(() => {
				Thread.Sleep(3000);
			});
			Process.Start(Settings.Default.steamfolder + gameFolder + "BlackOps3.exe");
		}

		private void comboBox1_ControlAdded(object sender, ControlEventArgs e) {

		}

		private void button3_Click(object sender, EventArgs e) {
			if (!File.Exists(Settings.Default.steamfolder + gameFolder + "localization.txt")) {
				MessageBox.Show("Unable to detect language (localization.txt file does not exist). " +
					"Incorrect steam folder?", "Auto Detection", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			string[] lines = File.ReadAllLines(Settings.Default.steamfolder + gameFolder + "localization.txt");
			string firstLine = lines[0].ToLower().Trim();
			switch (firstLine) {
				case "englisharabic":
					Settings.Default.gamelang = "ea";
					break;
				case "french":
					Settings.Default.gamelang = "fr";
					break;
				case "italian":
					Settings.Default.gamelang = "it";
					break;
				case "spanish":
					Settings.Default.gamelang = "es";
					break;
				case "german":
					Settings.Default.gamelang = "ge";
					break;
				case "portuguese":
					Settings.Default.gamelang = "bp";
					break;
				case "russian":
					Settings.Default.gamelang = "ru";
					break;
				case "polish":
					Settings.Default.gamelang = "po";
					break;
				case "japanese":
					Settings.Default.gamelang = "ja";
					break;
				case "traditionalchinese":
					Settings.Default.gamelang = "tc";
					break;
				case "simplifiedchinese":
					Settings.Default.gamelang = "sc";
					break;
				case "english":
					Settings.Default.gamelang = "en";
					break;
				default:
					MessageBox.Show("Unable to detect language");
					break;
			}
			loadComboBox();
		}

		private void settingsToolStripMenuItem_Click(object sender, EventArgs e) {
			SettingsForm settingsForm = new SettingsForm();
			settingsForm.ShowDialog();
		}

		private void autoDetectSteamLibraryFolderrequiresAdministratorToolStripMenuItem_Click(object sender, EventArgs e) {
			string x = GetSpecificSteamLibraryPath();
			if (x == null) {
				MessageBox.Show("Failed to detect folder (Not Administrator?).", "Steam library detection", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			} else {
				Settings.Default.steamfolder = x;
				MessageBox.Show("Folder has been set to: " + x, "Auto Detection", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
			MessageBox.Show("Developer: Sandwicha\n\n" +
				"Steam library folder auto detection needs Administrator Privileges " +
				"because it uses the registry to find the path.\n" +
				"Auto language detection uses localization.txt first line to find matching language.",
				"About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void CopyFilesWithEnReplacement(string sourceDirectory, string destinationDirectory, string replacementString) {
			string[] files = Directory.GetFiles(sourceDirectory);

			foreach (string file in files) {
				string fileName = Path.GetFileName(file);

				if (fileName.ToLower().Contains(".en.")) // Check if ".en." exists
				{
					string newFileName = fileName.ToLower().Replace(".en.", "." + replacementString + "."); // Replace ".en."
					string destinationFile = Path.Combine(destinationDirectory, newFileName);
					if (!File.Exists(destinationFile)) {
						richTextBox1.Invoke((MethodInvoker)delegate {
							richTextBox1.AppendText("> (SND) Copied '" + fileName + "' as '" + newFileName + "'\n");
						});
						filesCounter++;
					}
					File.Copy(file, destinationFile, true); // Overwrite if exists

				} else {
					//Copy files that do not have the .en.
					string destinationFile = Path.Combine(destinationDirectory, fileName);
					File.Copy(file, destinationFile, true);
				}
			}
		}
	}
}
