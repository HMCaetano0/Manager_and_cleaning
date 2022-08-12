namespace Shortcut_Manager
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.cbb_category = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txb_program = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdb_language_en_us = new System.Windows.Forms.RadioButton();
            this.rdb_language_pt_br = new System.Windows.Forms.RadioButton();
            this.btn_reset_program = new MetroFramework.Controls.MetroButton();
            this.btn_unnecessary_files = new MetroFramework.Controls.MetroButton();
            this.chk_start_with_windows = new MetroFramework.Controls.MetroCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbb_add_category = new System.Windows.Forms.ComboBox();
            this.chk_alphabet = new MetroFramework.Controls.MetroCheckBox();
            this.cbb_file_folder = new System.Windows.Forms.ComboBox();
            this.btn_save = new MetroFramework.Controls.MetroButton();
            this.chk_run_as_administrator = new MetroFramework.Controls.MetroCheckBox();
            this.txb_path = new MetroFramework.Controls.MetroTextBox();
            this.txb_name = new MetroFramework.Controls.MetroTextBox();
            this.btn_search_file_folder = new MetroFramework.Controls.MetroButton();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkIntegrityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.AllowDrop = true;
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.metroTabControl1.Location = new System.Drawing.Point(10, 22);
            this.metroTabControl1.Multiline = true;
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(585, 429);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.cbb_category);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.listView1);
            this.metroTabPage1.Controls.Add(this.txb_program);
            this.metroTabPage1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(577, 384);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Manager";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // cbb_category
            // 
            this.cbb_category.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_category.BackColor = System.Drawing.Color.White;
            this.cbb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_category.FormattingEnabled = true;
            this.cbb_category.Items.AddRange(new object[] {
            "All",
            "Apps",
            "Games"});
            this.cbb_category.Location = new System.Drawing.Point(6, 12);
            this.cbb_category.Name = "cbb_category";
            this.cbb_category.Size = new System.Drawing.Size(563, 21);
            this.cbb_category.TabIndex = 9;
            this.cbb_category.SelectedIndexChanged += new System.EventHandler(this.cbb_category_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(197, 367);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(183, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Developer Cyb3r_1nj3ct0r";
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 61);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(565, 306);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            this.listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseUp);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "";
            this.columnHeader1.Text = "Program";
            this.columnHeader1.Width = 131;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "";
            this.columnHeader2.Text = "Path";
            this.columnHeader2.Width = 201;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adm";
            this.columnHeader3.Width = 51;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SizeFile";
            this.columnHeader4.Width = 77;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Integrity";
            this.columnHeader5.Width = 101;
            // 
            // txb_program
            // 
            this.txb_program.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txb_program.CustomButton.Image = null;
            this.txb_program.CustomButton.Location = new System.Drawing.Point(543, 1);
            this.txb_program.CustomButton.Name = "";
            this.txb_program.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_program.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_program.CustomButton.TabIndex = 1;
            this.txb_program.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_program.CustomButton.UseSelectable = true;
            this.txb_program.CustomButton.Visible = false;
            this.txb_program.Lines = new string[0];
            this.txb_program.Location = new System.Drawing.Point(6, 36);
            this.txb_program.MaxLength = 32767;
            this.txb_program.Name = "txb_program";
            this.txb_program.PasswordChar = '\0';
            this.txb_program.PromptText = "Program";
            this.txb_program.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_program.SelectedText = "";
            this.txb_program.SelectionLength = 0;
            this.txb_program.SelectionStart = 0;
            this.txb_program.ShortcutsEnabled = true;
            this.txb_program.Size = new System.Drawing.Size(565, 23);
            this.txb_program.TabIndex = 3;
            this.txb_program.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_program.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_program.UseSelectable = true;
            this.txb_program.WaterMark = "Program";
            this.txb_program.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_program.WaterMarkFont = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_program.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_program_KeyDown);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.label3);
            this.metroTabPage2.Controls.Add(this.panel3);
            this.metroTabPage2.Controls.Add(this.label1);
            this.metroTabPage2.Controls.Add(this.panel1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(577, 384);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Settings";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Configs";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.rdb_language_en_us);
            this.panel3.Controls.Add(this.rdb_language_pt_br);
            this.panel3.Controls.Add(this.btn_reset_program);
            this.panel3.Controls.Add(this.btn_unnecessary_files);
            this.panel3.Controls.Add(this.chk_start_with_windows);
            this.panel3.Location = new System.Drawing.Point(173, 222);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 145);
            this.panel3.TabIndex = 6;
            // 
            // rdb_language_en_us
            // 
            this.rdb_language_en_us.AutoSize = true;
            this.rdb_language_en_us.Checked = true;
            this.rdb_language_en_us.Location = new System.Drawing.Point(9, 35);
            this.rdb_language_en_us.Name = "rdb_language_en_us";
            this.rdb_language_en_us.Size = new System.Drawing.Size(106, 17);
            this.rdb_language_en_us.TabIndex = 13;
            this.rdb_language_en_us.TabStop = true;
            this.rdb_language_en_us.Text = "Language en-US";
            this.rdb_language_en_us.UseVisualStyleBackColor = true;
            this.rdb_language_en_us.CheckedChanged += new System.EventHandler(this.rdb_language_en_us_CheckedChanged);
            // 
            // rdb_language_pt_br
            // 
            this.rdb_language_pt_br.AutoSize = true;
            this.rdb_language_pt_br.Location = new System.Drawing.Point(9, 54);
            this.rdb_language_pt_br.Name = "rdb_language_pt_br";
            this.rdb_language_pt_br.Size = new System.Drawing.Size(103, 17);
            this.rdb_language_pt_br.TabIndex = 12;
            this.rdb_language_pt_br.Text = "Language pt-BR";
            this.rdb_language_pt_br.UseVisualStyleBackColor = true;
            this.rdb_language_pt_br.CheckedChanged += new System.EventHandler(this.rdb_language_pt_br_CheckedChanged);
            // 
            // btn_reset_program
            // 
            this.btn_reset_program.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reset_program.Location = new System.Drawing.Point(9, 77);
            this.btn_reset_program.Name = "btn_reset_program";
            this.btn_reset_program.Size = new System.Drawing.Size(211, 23);
            this.btn_reset_program.TabIndex = 11;
            this.btn_reset_program.Text = "Reset Program";
            this.btn_reset_program.UseSelectable = true;
            this.btn_reset_program.Click += new System.EventHandler(this.btn_reset_program_Click);
            // 
            // btn_unnecessary_files
            // 
            this.btn_unnecessary_files.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_unnecessary_files.Location = new System.Drawing.Point(9, 102);
            this.btn_unnecessary_files.Name = "btn_unnecessary_files";
            this.btn_unnecessary_files.Size = new System.Drawing.Size(211, 23);
            this.btn_unnecessary_files.TabIndex = 10;
            this.btn_unnecessary_files.Text = "Delete unnecessary files";
            this.btn_unnecessary_files.UseSelectable = true;
            this.btn_unnecessary_files.Click += new System.EventHandler(this.btn_unnecessary_files_Click);
            // 
            // chk_start_with_windows
            // 
            this.chk_start_with_windows.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_start_with_windows.AutoSize = true;
            this.chk_start_with_windows.Location = new System.Drawing.Point(9, 18);
            this.chk_start_with_windows.Name = "chk_start_with_windows";
            this.chk_start_with_windows.Size = new System.Drawing.Size(125, 15);
            this.chk_start_with_windows.TabIndex = 7;
            this.chk_start_with_windows.Text = "Start with Windows";
            this.chk_start_with_windows.UseSelectable = true;
            this.chk_start_with_windows.CheckedChanged += new System.EventHandler(this.chk_start_with_windows_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Data";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbb_add_category);
            this.panel1.Controls.Add(this.chk_alphabet);
            this.panel1.Controls.Add(this.cbb_file_folder);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.chk_run_as_administrator);
            this.panel1.Controls.Add(this.txb_path);
            this.panel1.Controls.Add(this.txb_name);
            this.panel1.Controls.Add(this.btn_search_file_folder);
            this.panel1.Location = new System.Drawing.Point(173, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 183);
            this.panel1.TabIndex = 2;
            // 
            // cbb_add_category
            // 
            this.cbb_add_category.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_add_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_add_category.FormattingEnabled = true;
            this.cbb_add_category.Items.AddRange(new object[] {
            "Apps",
            "Games"});
            this.cbb_add_category.Location = new System.Drawing.Point(9, 41);
            this.cbb_add_category.Name = "cbb_add_category";
            this.cbb_add_category.Size = new System.Drawing.Size(211, 21);
            this.cbb_add_category.TabIndex = 10;
            // 
            // chk_alphabet
            // 
            this.chk_alphabet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chk_alphabet.AutoSize = true;
            this.chk_alphabet.Location = new System.Drawing.Point(149, 120);
            this.chk_alphabet.Name = "chk_alphabet";
            this.chk_alphabet.Size = new System.Drawing.Size(71, 15);
            this.chk_alphabet.TabIndex = 9;
            this.chk_alphabet.Text = "Alphabet";
            this.chk_alphabet.UseSelectable = true;
            this.chk_alphabet.CheckedChanged += new System.EventHandler(this.chk_alphabet_CheckedChanged);
            // 
            // cbb_file_folder
            // 
            this.cbb_file_folder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_file_folder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_file_folder.FormattingEnabled = true;
            this.cbb_file_folder.Items.AddRange(new object[] {
            "File",
            "Folder"});
            this.cbb_file_folder.Location = new System.Drawing.Point(9, 17);
            this.cbb_file_folder.Name = "cbb_file_folder";
            this.cbb_file_folder.Size = new System.Drawing.Size(178, 21);
            this.cbb_file_folder.TabIndex = 8;
            this.cbb_file_folder.Tag = "";
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.Location = new System.Drawing.Point(9, 141);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(211, 23);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseSelectable = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // chk_run_as_administrator
            // 
            this.chk_run_as_administrator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chk_run_as_administrator.AutoSize = true;
            this.chk_run_as_administrator.Location = new System.Drawing.Point(9, 120);
            this.chk_run_as_administrator.Name = "chk_run_as_administrator";
            this.chk_run_as_administrator.Size = new System.Drawing.Size(140, 15);
            this.chk_run_as_administrator.TabIndex = 6;
            this.chk_run_as_administrator.Text = "Open as administrator";
            this.chk_run_as_administrator.UseSelectable = true;
            // 
            // txb_path
            // 
            this.txb_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_path.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            // 
            // 
            // 
            this.txb_path.CustomButton.Image = null;
            this.txb_path.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.txb_path.CustomButton.Name = "";
            this.txb_path.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_path.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_path.CustomButton.TabIndex = 1;
            this.txb_path.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_path.CustomButton.UseSelectable = true;
            this.txb_path.CustomButton.Visible = false;
            this.txb_path.Lines = new string[0];
            this.txb_path.Location = new System.Drawing.Point(9, 94);
            this.txb_path.MaxLength = 32767;
            this.txb_path.Name = "txb_path";
            this.txb_path.PasswordChar = '\0';
            this.txb_path.PromptText = "Path";
            this.txb_path.ReadOnly = true;
            this.txb_path.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_path.SelectedText = "";
            this.txb_path.SelectionLength = 0;
            this.txb_path.SelectionStart = 0;
            this.txb_path.ShortcutsEnabled = true;
            this.txb_path.Size = new System.Drawing.Size(211, 23);
            this.txb_path.TabIndex = 5;
            this.txb_path.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_path.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_path.UseSelectable = true;
            this.txb_path.WaterMark = "Path";
            this.txb_path.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_path.WaterMarkFont = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txb_name
            // 
            this.txb_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txb_name.CustomButton.Image = null;
            this.txb_name.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.txb_name.CustomButton.Name = "";
            this.txb_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_name.CustomButton.TabIndex = 1;
            this.txb_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_name.CustomButton.UseSelectable = true;
            this.txb_name.CustomButton.Visible = false;
            this.txb_name.Lines = new string[0];
            this.txb_name.Location = new System.Drawing.Point(9, 68);
            this.txb_name.MaxLength = 32767;
            this.txb_name.Name = "txb_name";
            this.txb_name.PasswordChar = '\0';
            this.txb_name.PromptText = "Name";
            this.txb_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_name.SelectedText = "";
            this.txb_name.SelectionLength = 0;
            this.txb_name.SelectionStart = 0;
            this.txb_name.ShortcutsEnabled = true;
            this.txb_name.Size = new System.Drawing.Size(211, 23);
            this.txb_name.TabIndex = 4;
            this.txb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_name.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_name.UseSelectable = true;
            this.txb_name.WaterMark = "Name";
            this.txb_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_name.WaterMarkFont = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_search_file_folder
            // 
            this.btn_search_file_folder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search_file_folder.Location = new System.Drawing.Point(189, 17);
            this.btn_search_file_folder.Name = "btn_search_file_folder";
            this.btn_search_file_folder.Size = new System.Drawing.Size(31, 21);
            this.btn_search_file_folder.TabIndex = 0;
            this.btn_search_file_folder.Text = "...";
            this.btn_search_file_folder.UseSelectable = true;
            this.btn_search_file_folder.Click += new System.EventHandler(this.btn_search_file_folder_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.openFolderToolStripMenuItem,
            this.checkIntegrityToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip.Size = new System.Drawing.Size(155, 92);
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.testeToolStripMenuItem.Text = "Edit";
            this.testeToolStripMenuItem.Click += new System.EventHandler(this.testeToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.openFolderToolStripMenuItem.Text = "Open Folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // checkIntegrityToolStripMenuItem
            // 
            this.checkIntegrityToolStripMenuItem.Name = "checkIntegrityToolStripMenuItem";
            this.checkIntegrityToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.checkIntegrityToolStripMenuItem.Text = "Check Integrity";
            this.checkIntegrityToolStripMenuItem.Click += new System.EventHandler(this.checkIntegrityToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(606, 459);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTextBox txb_program;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox txb_path;
        private MetroFramework.Controls.MetroTextBox txb_name;
        private MetroFramework.Controls.MetroButton btn_search_file_folder;
        private MetroFramework.Controls.MetroCheckBox chk_run_as_administrator;
        private MetroFramework.Controls.MetroButton btn_save;
        private System.Windows.Forms.ComboBox cbb_file_folder;
        private MetroFramework.Controls.MetroCheckBox chk_alphabet;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroCheckBox chk_start_with_windows;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private MetroFramework.Controls.MetroButton btn_unnecessary_files;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btn_reset_program;
        private System.Windows.Forms.ComboBox cbb_category;
        private System.Windows.Forms.ComboBox cbb_add_category;
        private System.Windows.Forms.RadioButton rdb_language_en_us;
        private System.Windows.Forms.RadioButton rdb_language_pt_br;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripMenuItem checkIntegrityToolStripMenuItem;
    }
}

