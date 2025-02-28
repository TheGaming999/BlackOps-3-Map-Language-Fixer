namespace BlackOps3MapLanguageFixer {
	partial class Form1 {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeSteamFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openSteamFolderInExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openBO3WorkshopFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.autoDetectSteamLibraryFolderrequiresAdministratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.menuStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Gray;
			this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(16, 4, 0, 4);
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.menuStrip1.Size = new System.Drawing.Size(1062, 35);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeSteamFolderToolStripMenuItem,
            this.openSteamFolderInExplorerToolStripMenuItem,
            this.openBO3WorkshopFolderToolStripMenuItem,
            this.autoDetectSteamLibraryFolderrequiresAdministratorToolStripMenuItem});
			this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(49, 27);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// changeSteamFolderToolStripMenuItem
			// 
			this.changeSteamFolderToolStripMenuItem.Name = "changeSteamFolderToolStripMenuItem";
			this.changeSteamFolderToolStripMenuItem.Size = new System.Drawing.Size(577, 28);
			this.changeSteamFolderToolStripMenuItem.Text = "Change steam library folder";
			this.changeSteamFolderToolStripMenuItem.Click += new System.EventHandler(this.changeSteamFolderToolStripMenuItem_Click);
			// 
			// openSteamFolderInExplorerToolStripMenuItem
			// 
			this.openSteamFolderInExplorerToolStripMenuItem.Name = "openSteamFolderInExplorerToolStripMenuItem";
			this.openSteamFolderInExplorerToolStripMenuItem.Size = new System.Drawing.Size(577, 28);
			this.openSteamFolderInExplorerToolStripMenuItem.Text = "Open steam library folder in explorer";
			this.openSteamFolderInExplorerToolStripMenuItem.Click += new System.EventHandler(this.openSteamFolderInExplorerToolStripMenuItem_Click);
			// 
			// openBO3WorkshopFolderToolStripMenuItem
			// 
			this.openBO3WorkshopFolderToolStripMenuItem.Name = "openBO3WorkshopFolderToolStripMenuItem";
			this.openBO3WorkshopFolderToolStripMenuItem.Size = new System.Drawing.Size(577, 28);
			this.openBO3WorkshopFolderToolStripMenuItem.Text = "Open BO3 workshop folder in explorer";
			this.openBO3WorkshopFolderToolStripMenuItem.Click += new System.EventHandler(this.openBO3WorkshopFolderToolStripMenuItem_Click);
			// 
			// autoDetectSteamLibraryFolderrequiresAdministratorToolStripMenuItem
			// 
			this.autoDetectSteamLibraryFolderrequiresAdministratorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.autoDetectSteamLibraryFolderrequiresAdministratorToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
			this.autoDetectSteamLibraryFolderrequiresAdministratorToolStripMenuItem.Name = "autoDetectSteamLibraryFolderrequiresAdministratorToolStripMenuItem";
			this.autoDetectSteamLibraryFolderrequiresAdministratorToolStripMenuItem.Size = new System.Drawing.Size(577, 28);
			this.autoDetectSteamLibraryFolderrequiresAdministratorToolStripMenuItem.Text = "Auto detect steam library folder (requires Run as Administrator)";
			this.autoDetectSteamLibraryFolderrequiresAdministratorToolStripMenuItem.Click += new System.EventHandler(this.autoDetectSteamLibraryFolderrequiresAdministratorToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.saveToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 27);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
			this.settingsToolStripMenuItem.Text = "Settings";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 27);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Location = new System.Drawing.Point(688, 6);
			this.button1.Margin = new System.Windows.Forms.Padding(6);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(117, 45);
			this.button1.TabIndex = 1;
			this.button1.Text = "FIX";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Location = new System.Drawing.Point(817, 6);
			this.button2.Margin = new System.Windows.Forms.Padding(6);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(213, 45);
			this.button2.TabIndex = 2;
			this.button2.Text = "FIX AND RUN";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.Color.Silver;
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox1.ForeColor = System.Drawing.Color.Blue;
			this.richTextBox1.Location = new System.Drawing.Point(3, 3);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(1056, 366);
			this.richTextBox1.TabIndex = 3;
			this.richTextBox1.Text = "";
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.SystemColors.Menu;
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "English - en",
            "EnglishArabic - ea",
            "French - fr",
            "German - ge",
            "Italian - it",
            "Japanese - ja",
            "Polish - po",
            "Portuguese - bp",
            "Russian - ru",
            "Simplified Chinese - sc",
            "Spanish - es",
            "Traditional Chinese - tc"});
			this.comboBox1.Location = new System.Drawing.Point(243, 3);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(301, 33);
			this.comboBox1.Sorted = true;
			this.comboBox1.TabIndex = 4;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			this.comboBox1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.comboBox1_ControlAdded);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(234, 32);
			this.label1.TabIndex = 5;
			this.label1.Text = "Game Language:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.UseMnemonic = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.button3.FlatAppearance.BorderSize = 2;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(553, 6);
			this.button3.Margin = new System.Windows.Forms.Padding(6);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(123, 69);
			this.button3.TabIndex = 6;
			this.button3.Text = "< Detect Language";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 35);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1062, 465);
			this.tableLayoutPanel1.TabIndex = 7;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this.comboBox1);
			this.flowLayoutPanel1.Controls.Add(this.button3);
			this.flowLayoutPanel1.Controls.Add(this.button1);
			this.flowLayoutPanel1.Controls.Add(this.button2);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 375);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1056, 87);
			this.flowLayoutPanel1.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1062, 500);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(6);
			this.MinimumSize = new System.Drawing.Size(630, 345);
			this.Name = "Form1";
			this.Text = "BO3 Map Language Fixer v0.2";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changeSteamFolderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openSteamFolderInExplorerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openBO3WorkshopFolderToolStripMenuItem;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ToolStripMenuItem autoDetectSteamLibraryFolderrequiresAdministratorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	}
}

