using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Shortcut_Manager
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        Ini IniFile = new Ini(Application.StartupPath + "\\Config.ini");

        public Form2()
        {
            InitializeComponent();

            if(Form1.Edit_Language == "en-us")
            {
                txb_name.WaterMark = "Name";
                txb_path.WaterMark = "Path";
                cbb_category.Items.Clear();
                cbb_category.Items.Add("Apps");
                cbb_category.Items.Add("Games");
                chk_run_as_administrator.Text = "Run as administrator";
            }
            else
            {
                txb_name.WaterMark = "Nome";
                txb_path.WaterMark = "Pasta";
                cbb_category.Items.Clear();
                cbb_category.Items.Add("Apps");
                cbb_category.Items.Add("Jogos");
                chk_run_as_administrator.Text = "Executar como Adm";
            }

            txb_name.Text = Form1.Edit_TxbName;
            txb_path.Text = Form1.Edit_TxbPath;

            if (Form1.Edit_Category == "apps")
                cbb_category.SelectedIndex = 0;

            if (Form1.Edit_Category == "games")
                cbb_category.SelectedIndex = 1;

            if (Form1.Edit_Category == "jogos")
                cbb_category.SelectedIndex = 1;

            if (Form1.Edit_ChkRunAsAdministrator == "true")
                chk_run_as_administrator.Checked = true;
            else
                chk_run_as_administrator.Checked = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (Form1.Edit_Folder == "false")
            {
                if (File.Exists(txb_path.Text))
                {
                    IniFile.Clear_Section(Form1.Edit_TxbName); // Deletar antigo
                    IniFile.Write(txb_name.Text, "Name", txb_name.Text);
                    IniFile.Write(txb_name.Text, "Path", txb_path.Text);
                    IniFile.Write(txb_name.Text, "Folder", Form1.Edit_Folder);

                    if (cbb_category.SelectedItem.ToString() == "Apps")
                        IniFile.Write(txb_name.Text, "Category", "apps");

                    if (cbb_category.SelectedItem.ToString() == "Games" || cbb_category.SelectedItem.ToString() == "Jogos")
                        IniFile.Write(txb_name.Text, "Category", "games");

                    if (chk_run_as_administrator.Checked)
                        IniFile.Write(txb_name.Text, "Run_administrator", "true");
                    else
                        IniFile.Write(txb_name.Text, "Run_administrator", "false");

                    if (Form1.Edit_Language == "en-us")
                        MessageBox.Show("Successfully edited!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Editado com Sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    if (Form1.Edit_Language == "en-us")
                        MessageBox.Show("File moved or removed!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Arquivo movido ou removido!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (Form1.Edit_Folder == "true")
            {
                if (Directory.Exists(txb_path.Text))
                {
                    IniFile.Clear_Section(Form1.Edit_TxbName); // Deletar antigo
                    IniFile.Write(txb_name.Text, "Name", txb_name.Text);
                    IniFile.Write(txb_name.Text, "Path", txb_path.Text);
                    IniFile.Write(txb_name.Text, "Folder", Form1.Edit_Folder);

                    if (cbb_category.SelectedItem.ToString() == "Apps")
                        IniFile.Write(txb_name.Text, "Category", "apps");

                    if (cbb_category.SelectedItem.ToString() == "Games" || cbb_category.SelectedItem.ToString() == "Jogos")
                        IniFile.Write(txb_name.Text, "Category", "games");


                    if (chk_run_as_administrator.Checked)
                        IniFile.Write(txb_name.Text, "Run_administrator", "true");
                    else
                        IniFile.Write(txb_name.Text, "Run_administrator", "false");

                    if (Form1.Edit_Language == "en-us")
                        MessageBox.Show("Successfully edited!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Editado com Sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    if (Form1.Edit_Language == "en-us")
                        MessageBox.Show("Folder moved or removed!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Pasta movida ou removida!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
