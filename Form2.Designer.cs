namespace Shortcut_Manager
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btn_save = new MetroFramework.Controls.MetroButton();
            this.chk_run_as_administrator = new MetroFramework.Controls.MetroCheckBox();
            this.txb_path = new MetroFramework.Controls.MetroTextBox();
            this.txb_name = new MetroFramework.Controls.MetroTextBox();
            this.cbb_category = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.Location = new System.Drawing.Point(54, 153);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(211, 23);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Save";
            this.btn_save.UseSelectable = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // chk_run_as_administrator
            // 
            this.chk_run_as_administrator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chk_run_as_administrator.AutoSize = true;
            this.chk_run_as_administrator.Location = new System.Drawing.Point(93, 132);
            this.chk_run_as_administrator.Name = "chk_run_as_administrator";
            this.chk_run_as_administrator.Size = new System.Drawing.Size(132, 15);
            this.chk_run_as_administrator.TabIndex = 10;
            this.chk_run_as_administrator.Text = "Run as administrator";
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
            this.txb_path.Location = new System.Drawing.Point(54, 78);
            this.txb_path.MaxLength = 32767;
            this.txb_path.Name = "txb_path";
            this.txb_path.PasswordChar = '\0';
            this.txb_path.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_path.SelectedText = "";
            this.txb_path.SelectionLength = 0;
            this.txb_path.SelectionStart = 0;
            this.txb_path.ShortcutsEnabled = true;
            this.txb_path.Size = new System.Drawing.Size(211, 23);
            this.txb_path.TabIndex = 9;
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
            this.txb_name.Location = new System.Drawing.Point(54, 49);
            this.txb_name.MaxLength = 32767;
            this.txb_name.Name = "txb_name";
            this.txb_name.PasswordChar = '\0';
            this.txb_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_name.SelectedText = "";
            this.txb_name.SelectionLength = 0;
            this.txb_name.SelectionStart = 0;
            this.txb_name.ShortcutsEnabled = true;
            this.txb_name.Size = new System.Drawing.Size(211, 23);
            this.txb_name.TabIndex = 8;
            this.txb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_name.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_name.UseSelectable = true;
            this.txb_name.WaterMark = "Name";
            this.txb_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_name.WaterMarkFont = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cbb_category
            // 
            this.cbb_category.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_category.FormattingEnabled = true;
            this.cbb_category.Items.AddRange(new object[] {
            "Apps",
            "Games"});
            this.cbb_category.Location = new System.Drawing.Point(54, 105);
            this.cbb_category.Name = "cbb_category";
            this.cbb_category.Size = new System.Drawing.Size(211, 21);
            this.cbb_category.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 200);
            this.Controls.Add(this.cbb_category);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.chk_run_as_administrator);
            this.Controls.Add(this.txb_path);
            this.Controls.Add(this.txb_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Resizable = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_save;
        private MetroFramework.Controls.MetroCheckBox chk_run_as_administrator;
        private MetroFramework.Controls.MetroTextBox txb_path;
        private MetroFramework.Controls.MetroTextBox txb_name;
        private System.Windows.Forms.ComboBox cbb_category;
    }
}