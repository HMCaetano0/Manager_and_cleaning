using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace Shortcut_Manager
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        Ini IniFile = new Ini(Application.StartupPath + "\\Config.ini");
        ImageList Imagelist = new ImageList();
        string current_partition = Path.GetPathRoot(Environment.SystemDirectory);
        public static string Edit_TxbName = "";
        public static string Edit_TxbPath = "";
        public static string Edit_Folder = "";
        public static string Edit_Category = "";
        public static string Edit_ChkRunAsAdministrator = "";
        public static string Edit_Language = "";

        public void Language_en_us()
        {
            IniFile.Write("Config00123456789", "Language", "en-us");
            metroTabPage1.Text = "Manager";
            metroTabPage2.Text = "Settings";
            testeToolStripMenuItem.Text = "Edit";
            removeToolStripMenuItem.Text = "Remove";
            openFolderToolStripMenuItem.Text = "Open Folder";
            checkIntegrityToolStripMenuItem.Text = "Check Integrity";
            cbb_category.Items.Clear();
            cbb_category.Items.Add("All");
            cbb_category.Items.Add("Apps");
            cbb_category.Items.Add("Games");
            txb_program.WaterMark = "Program";
            columnHeader1.Text = "Program";
            columnHeader2.Text = "Path";
            columnHeader3.Text = "Adm";
            columnHeader4.Text = "SizeFile";
            columnHeader5.Text = "Integrity";
            label1.Text = "New Data";
            cbb_file_folder.Items.Clear();
            cbb_file_folder.Items.Add("File");
            cbb_file_folder.Items.Add("Folder");
            cbb_add_category.Items.Clear();
            cbb_add_category.Items.Add("Apps");
            cbb_add_category.Items.Add("Games");
            txb_name.WaterMark = "Name";
            txb_path.WaterMark = "Path";
            chk_run_as_administrator.Text = "Open as administrator";
            chk_alphabet.Text = "Alphabet";
            btn_save.Text = "Save";
            chk_start_with_windows.Text = "Start with Windows";
            rdb_language_en_us.Text = "Language en-US";
            rdb_language_pt_br.Text = "Language pt-BR";
            btn_reset_program.Text = "Reset Program";
            btn_unnecessary_files.Text = "Delete unnecessary files";
        }

        public void Language_pt_br()
        {
            IniFile.Write("Config00123456789", "Language", "pt-br");
            metroTabPage1.Text = "Atalhos";
            metroTabPage2.Text = "Configurações";
            testeToolStripMenuItem.Text = "Editar";
            removeToolStripMenuItem.Text = "Remover";
            openFolderToolStripMenuItem.Text = "Abrir Pasta";
            checkIntegrityToolStripMenuItem.Text = "Checar Integridade";
            cbb_category.Items.Clear();
            cbb_category.Items.Add("Todos");
            cbb_category.Items.Add("Apps");
            cbb_category.Items.Add("Jogos");
            txb_program.WaterMark = "Programas";
            columnHeader1.Text = "Programa";
            columnHeader2.Text = "Pasta";
            columnHeader3.Text = "Adm";
            columnHeader4.Text = "Tamanho";
            columnHeader5.Text = "Integridade";
            label1.Text = "Novos dados";
            cbb_file_folder.Items.Clear();
            cbb_file_folder.Items.Add("Arquivo");
            cbb_file_folder.Items.Add("Pasta");
            cbb_add_category.Items.Clear();
            cbb_add_category.Items.Add("Apps");
            cbb_add_category.Items.Add("Jogos");
            txb_name.WaterMark = "Nome";
            txb_path.WaterMark = "Pasta";
            chk_run_as_administrator.Text = "Executar como Adm";
            chk_alphabet.Text = "Alfabeto";
            btn_save.Text = "Salvar";
            chk_start_with_windows.Text = "Abrir com Windows";
            rdb_language_en_us.Text = "Linguagem en-US";
            rdb_language_pt_br.Text = "Linguagem pt-BR";
            btn_reset_program.Text = "Resetar Programa";
            btn_unnecessary_files.Text = "Deletar arquivos desnecessários";
        }

        public void Ini_exists()
        {
            if (File.Exists(Application.StartupPath + "\\Config.ini"))
            {
                if (IniFile.GetSectionNames()[0] != "Config00123456789") // Verificar se a função inicial existe
                {
                    if (File.Exists(Application.StartupPath + "\\Config.ini.bak"))
                    {
                        File.Delete(Application.StartupPath + "\\Config.ini");
                        File.Move(Application.StartupPath + "\\Config.ini.bak", Application.StartupPath + "\\Config.ini");
                    }

                    if (IniFile.GetSectionNames()[0] != "Config00123456789") // Verificar se a função inicial existe
                    {
                        File.Delete(Application.StartupPath + "\\Config.ini");
                        MessageBox.Show("Corrupted configuration file, restarting program with new file", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Restart();
                        Environment.Exit(0);
                    }
                    Refresh_ListView();
                }
            }
        }

        public string GetFileSize(long number)
        {
            string suffix = " B ";
            double tmp = number;
            if (tmp > 1024) { tmp = tmp / 1024; suffix = " KB"; }
            if (tmp > 1024) { tmp = tmp / 1024; suffix = " MB"; }
            if (tmp > 1024) { tmp = tmp / 1024; suffix = " GB"; }
            if (tmp > 1024) { tmp = tmp / 1024; suffix = " TB"; }
            return tmp.ToString("n") + suffix;
        }

        public static string CryptXor(string path) {
            var Crypt = 0;
            var BytesFile = File.ReadAllBytes(path);
            for (int i = 0; i < BytesFile.Length; i++)
            {
                if (Crypt > 0)
                    Crypt += (BytesFile[i] ^ BytesFile[i - 1] ^ BytesFile[0] ^ BytesFile.Length);
                else
                    Crypt += BytesFile[i] ^ BytesFile.Length;
            }
            return Crypt.ToString("x");
        }

        public void CheckExistsFiles()
        {
            try
            {
                if (IniFile.Read(IniFile.GetSectionNames()[listView1.SelectedItems[0].Index], "Folder") == "false" &&
                        !File.Exists(listView1.SelectedItems[0].SubItems[1].Text))
                {
                    if (rdb_language_en_us.Checked)
                        MessageBox.Show("File removed from destination folder!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Arquivo não encontrado na pasta destino!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    for (int i = 1; i < IniFile.GetSectionNames().Length; i++)
                    {
                        if (!File.Exists(IniFile.Read(IniFile.GetSectionNames()[i], "Path")))
                        {
                            if (rdb_language_en_us.Checked)
                            {
                                MessageBox.Show("'" + IniFile.Read(IniFile.GetSectionNames()[i], "Path") + "'" +
                                    " was not found and has been removed!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("'" + IniFile.Read(IniFile.GetSectionNames()[i], "Path") + "'" +
                                    " não foi encontrado e foi removido!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            IniFile.Clear_Section(IniFile.GetSectionNames()[i]);
                            Imagelist.Images.Clear();
                        }
                    }
                    Refresh_ListView();
                    return;
                }

                if (IniFile.Read(IniFile.GetSectionNames()[listView1.SelectedItems[0].Index], "Folder") == "true" &&
                    !Directory.Exists(listView1.SelectedItems[0].SubItems[1].Text))
                {
                    if (rdb_language_en_us.Checked)
                        MessageBox.Show("File removed from destination folder!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Arquivo não encontrado na pasta destino!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    for (int i = 1; i < IniFile.GetSectionNames().Length; i++)
                    {
                        if (!Directory.Exists(IniFile.Read(IniFile.GetSectionNames()[i], "Path")))
                        {
                            if (rdb_language_en_us.Checked)
                            {
                                MessageBox.Show("'" + IniFile.Read(IniFile.GetSectionNames()[i], "Path") + "'" +
                                    " was not found and has been removed!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("'" + IniFile.Read(IniFile.GetSectionNames()[i], "Path") + "'" +
                                    " não foi encontrado e foi removido!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            IniFile.Clear_Section(IniFile.GetSectionNames()[i]);
                            Imagelist.Images.Clear();
                        }
                    }
                    Refresh_ListView();
                    return;

                }
            }
            catch (Exception) { }
        }

        public void Execute_Administrator()
        {
            Ini_exists(); // Verificar se está tudo OK com a configuração do arquivo!
            try
            {
                CheckExistsFiles();

                if (listView1.SelectedItems[0].SubItems[2].Text == "true")
                {
                    ProcessStartInfo info = new ProcessStartInfo(listView1.SelectedItems[0].SubItems[1].Text);
                    info.UseShellExecute = true;
                    info.Verb = "runas";
                    Process.Start(info);
                    txb_program.Text = " ";
                }
                else
                {
                    ProcessStartInfo info = new ProcessStartInfo(listView1.SelectedItems[0].SubItems[1].Text);
                    info.UseShellExecute = true;
                    Process.Start(info);
                }
            }
            catch (Exception)
            {
                ProcessStartInfo info = new ProcessStartInfo(listView1.SelectedItems[0].SubItems[1].Text);
                info.UseShellExecute = true;
                Process.Start(info);
                IniFile.Write(listView1.SelectedItems[0].Text, "Run_administrator", "false"); // Desabilitar Executar como Admnistrador
                Refresh_ListView();
            }
        }

        public void Refresh_ListView()
        {
            Ini_exists(); // Verificar se está tudo OK com a configuração do arquivo!
            try
            {
                listView1.Items.Clear();
                Imagelist.Images.Clear();
                CheckExistsFiles();
                for (int i = 1; i < IniFile.GetSectionNames().Length; i++)
                {
                    switch (cbb_category.SelectedIndex)
                    {
                        case 0: // Todos
                            if (IniFile.Read(IniFile.GetSectionNames()[i], "Folder") == "true")
                            {
                                Image img = new Bitmap(Properties.Resources.folder_40px);
                                Imagelist.Images.Add("image" + i, img);
                                listView1.SmallImageList = Imagelist;
                                ListViewItem item = new ListViewItem(IniFile.Read(IniFile.GetSectionNames()[i], "Name"));
                                item.ImageKey = "image" + i; // Adicionar 1 a 1 
                                item.SubItems.Add(IniFile.Read(IniFile.GetSectionNames()[i], "Path"));
                                listView1.Items.Add(item); // Load New ListView
                            }
                            else // Folder False
                            {
                                var filePath = IniFile.Read(IniFile.GetSectionNames()[i], "Path");
                                var theIcon = IconFromFilePath(filePath); // Capturar icones dos aplicativos
                                Icon.ExtractAssociatedIcon(filePath);
                                Imagelist.Images.Add("image" + i, theIcon.ToBitmap()); // Converter de ico para image
                                listView1.SmallImageList = Imagelist;
                                ListViewItem item = new ListViewItem(IniFile.Read(IniFile.GetSectionNames()[i], "Name"));
                                item.ImageKey = "image" + i; // Adicionar 1 a 1 
                                item.SubItems.Add(IniFile.Read(IniFile.GetSectionNames()[i], "Path"));
                                item.SubItems.Add(IniFile.Read(IniFile.GetSectionNames()[i], "Run_administrator"));
                                item.SubItems.Add(IniFile.Read(IniFile.GetSectionNames()[i], "SizeFile"));
                                item.SubItems.Add(IniFile.Read(IniFile.GetSectionNames()[i], "CryptXor"));
                                listView1.Items.Add(item); // Load New ListView
                            }
                        break;

                        case 1: // Apps
                            if(IniFile.Read(IniFile.GetSectionNames()[i], "Category") == "apps")
                            {
                                if (IniFile.Read(IniFile.GetSectionNames()[i], "Folder") == "true")
                                {
                                    Image img = new Bitmap(Properties.Resources.folder_40px);
                                    Imagelist.Images.Add("image" + i, img);
                                    listView1.SmallImageList = Imagelist;
                                    ListViewItem item = new ListViewItem(IniFile.Read(IniFile.GetSectionNames()[i], "Name"));
                                    item.ImageKey = "image" + i; // Adicionar 1 a 1 
                                    item.SubItems.Add(IniFile.Read(IniFile.GetSectionNames()[i], "Path"));
                                    listView1.Items.Add(item); // Load New ListView
                                }
                                else // Folder False
                                {
                                    var filePath = IniFile.Read(IniFile.GetSectionNames()[i], "Path");
                                    var theIcon = IconFromFilePath(filePath); // Capturar icones dos aplicativos
                                    Icon.ExtractAssociatedIcon(filePath);
                                    Imagelist.Images.Add("image" + i, theIcon.ToBitmap()); // Converter de ico para image
                                    listView1.SmallImageList = Imagelist;
                                    ListViewItem item = new ListViewItem(IniFile.Read(IniFile.GetSectionNames()[i], "Name"));
                                    item.ImageKey = "image" + i; // Adicionar 1 a 1 
                                    item.SubItems.Add(IniFile.Read(IniFile.GetSectionNames()[i], "Path"));
                                    item.SubItems.Add(IniFile.Read(IniFile.GetSectionNames()[i], "Run_administrator"));
                                    item.SubItems.Add(IniFile.Read(IniFile.GetSectionNames()[i], "SizeFile"));
                                    item.SubItems.Add(IniFile.Read(IniFile.GetSectionNames()[i], "CryptXor"));
                                    listView1.Items.Add(item); // Load New ListView
                                }
                            }
                        break;


                        case 2: // Games
                            if (IniFile.Read(IniFile.GetSectionNames()[i], "Category") == "games")
                            {
                                if (IniFile.Read(IniFile.GetSectionNames()[i], "Folder") == "true")
                                {
                                    Image img = new Bitmap(Properties.Resources.folder_40px);
                                    Imagelist.Images.Add("image" + i, img);
                                    listView1.SmallImageList = Imagelist;
                                    ListViewItem item = new ListViewItem(IniFile.Read(IniFile.GetSectionNames()[i], "Name"));
                                    item.ImageKey = "image" + i; // Adicionar 1 a 1 
                                    item.SubItems.Add(IniFile.Read(IniFile.GetSectionNames()[i], "Path"));
                                    listView1.Items.Add(item); // Load New ListView
                                }
                                else // Folder False
                                {
                                    var filePath = IniFile.Read(IniFile.GetSectionNames()[i], "Path");
                                    var theIcon = IconFromFilePath(filePath); // Capturar icones dos aplicativos
                                    Icon.ExtractAssociatedIcon(filePath);
                                    Imagelist.Images.Add("image" + i, theIcon.ToBitmap()); // Converter de ico para image
                                    listView1.SmallImageList = Imagelist;
                                    ListViewItem item = new ListViewItem(IniFile.Read(IniFile.GetSectionNames()[i], "Name"));
                                    item.ImageKey = "image" + i; // Adicionar 1 a 1 
                                    item.SubItems.Add(IniFile.Read(IniFile.GetSectionNames()[i], "Path"));
                                    item.SubItems.Add(IniFile.Read(IniFile.GetSectionNames()[i], "Run_administrator"));
                                    item.SubItems.Add(IniFile.Read(IniFile.GetSectionNames()[i], "SizeFile"));
                                    item.SubItems.Add(IniFile.Read(IniFile.GetSectionNames()[i], "CryptXor"));
                                    listView1.Items.Add(item); // Load New ListView
                                }
                            }
                            break;
                    }
                }
            }
            catch (Exception) { }
        }

        public void ClearFolder(string FolderName)
        {
            DirectoryInfo dir = new DirectoryInfo(FolderName);

            foreach (FileInfo fi in dir.GetFiles())
            {
                try
                {
                    fi.Delete();
                }
                catch (Exception) { } // Ignore all exceptions
            }

            foreach (DirectoryInfo di in dir.GetDirectories())
            {
                ClearFolder(di.FullName);
                try
                {
                    di.Delete();
                }
                catch (Exception) { } // Ignore all exceptions
            }
        }

        public static Icon IconFromFilePath(string filePath)
        {
            var result = (Icon)null;
            try
            {
                result = Icon.ExtractAssociatedIcon(filePath);
            }
            catch (Exception) { }
            return result;
        }

        public Form1()
        {
            this.InitializeComponent();
            metroTabControl1.SelectTab(0);

            if (!File.Exists(Application.StartupPath + "\\Config.ini"))
            {
                if (File.Exists(Application.StartupPath + "\\Config.ini.bak"))
                    File.Copy(Application.StartupPath + "\\Config.ini.bak", Application.StartupPath + "\\Config.ini");
                else
                {
                    File.Create(Application.StartupPath + "\\Config.ini").Close();
                    IniFile.Write("Config00123456789", "Alphabet_Checked", "no");
                    IniFile.Write("Config00123456789", "FirstAcess", "yes");
                    IniFile.Write("Config00123456789", "Language", "en-us");
                    rdb_language_en_us.Checked = true;
                    Language_en_us();
                }
            }
            else
            {
                if (IniFile.Read("Config00123456789", "Language") == "en-us")
                {
                    rdb_language_en_us.Checked = true;
                    Language_en_us();
                }

                if (IniFile.Read("Config00123456789", "Language") == "pt-br")
                {
                    rdb_language_pt_br.Checked = true;
                    Language_pt_br();
                }

                if (cbb_category.SelectedValue == null)
                    cbb_category.SelectedIndex = 0;
                Refresh_ListView();
            }

            if (Process.GetCurrentProcess().MainModule.ModuleName != "Shortcut Manager v2.exe")
            {
                if (rdb_language_en_us.Checked)
                    MessageBox.Show("Name changed, please do not rename!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Nome alterado, por favor, não altere o nome do aplicativo!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void btn_search_file_folder_Click(object sender, EventArgs e)
        {
            Ini_exists(); // Verificar se está tudo OK com a configuração do arquivo!
            if(cbb_category.SelectedValue == null)
                cbb_category.SelectedIndex = 0;
            if (cbb_file_folder.SelectedItem == null)
            {
                if (rdb_language_en_us.Checked)
                    MessageBox.Show("Choose an option beside!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Selecione alguma opção ao lado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(cbb_file_folder.SelectedItem.ToString() == "File" || cbb_file_folder.SelectedItem.ToString() == "Arquivo")
            {
                chk_run_as_administrator.Enabled = true;
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "All files|*.*", ValidateNames = true, CheckPathExists = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                        foreach (string f in ofd.FileNames)
                        {
                            FileInfo fi = new FileInfo(f);
                            txb_name.Text = Path.GetFileNameWithoutExtension(fi.Name);
                            txb_path.Text = fi.FullName;
                        }
                }
            }
            else
                chk_run_as_administrator.Enabled = false;

            if (cbb_file_folder.SelectedItem.ToString() == "Folder" || cbb_file_folder.SelectedItem.ToString() == "Pasta")
                using (FolderBrowserDialog ofd = new FolderBrowserDialog())
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        txb_name.Text = new DirectoryInfo(ofd.SelectedPath).Name;
                        txb_path.Text = ofd.SelectedPath;
                        txb_path.ReadOnly = true;
                    }
                }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (cbb_category.SelectedValue == null) cbb_category.SelectedIndex = 0;

            try
            {
                Ini_exists(); // Verificar se está tudo OK com a configuração do arquivo!
                if (txb_name.Text == "" || txb_path.Text == "")
                {
                    if (rdb_language_en_us.Checked)
                        MessageBox.Show("No files to save!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Sem arquivos para salvar!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (cbb_add_category.SelectedItem == null)
                    {
                        if (rdb_language_en_us.Checked)
                            MessageBox.Show("Choose a category!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Selecione alguma categoria!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (IniFile.Read("Config00123456789", "FirstAcess") == "no")
                    {
                        for (int i = 1; i < IniFile.GetSectionNames().Length; i++)
                        {
                            if (IniFile.GetSectionNames()[i] == txb_name.Text)
                            {
                                if (rdb_language_en_us.Checked)
                                    MessageBox.Show("Name in use, change!",
                                                    "Info",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Error);
                                else
                                    MessageBox.Show("Nome em uso, altere!",
                                                    "Info",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Error);
                                return;
                            }

                            for (int j = 0; j < 2; j++)
                            {
                                if (IniFile.Read(IniFile.GetSectionNames()[i], IniFile.GetEntryNames(IniFile.GetSectionNames()[i])[j]) == txb_path.Text)
                                {
                                    if (rdb_language_en_us.Checked)
                                        MessageBox.Show("File in use, change!",
                                                    "Info",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Error);
                                    else
                                        MessageBox.Show("Arquivo em uso, altere!",
                                                    "Info",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }
                    }


                    if (cbb_file_folder.SelectedItem.ToString() == "File" || cbb_file_folder.SelectedItem.ToString() == "Arquivo") // Only File
                    {
                        if (!File.Exists(txb_path.Text))
                        {
                            MessageBox.Show("Arquivo não encontrado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        IniFile.Write(txb_name.Text, "Name", txb_name.Text);
                        IniFile.Write(txb_name.Text, "Path", txb_path.Text);
                        IniFile.Write(txb_name.Text, "Folder", "False");
                        if(cbb_add_category.SelectedItem.ToString() == "Apps")
                            IniFile.Write(txb_name.Text, "Category", "apps");

                        if (cbb_add_category.SelectedItem.ToString() == "Games" ||
                            cbb_add_category.SelectedItem.ToString() == "Jogos")
                            IniFile.Write(txb_name.Text, "Category", "games");

                        if (chk_run_as_administrator.Checked)
                            IniFile.Write(txb_name.Text, "Run_administrator", "true");
                        else
                            IniFile.Write(txb_name.Text, "Run_administrator", "false");

                        IniFile.Write(txb_name.Text, "SizeFile", GetFileSize(File.OpenRead(txb_path.Text).Length));
                        IniFile.Write(txb_name.Text, "CryptXor", CryptXor(txb_path.Text));
                    }
                    else // Only Folder
                    {
                        if (!Directory.Exists(txb_path.Text))
                        {
                            MessageBox.Show("Pasta não encontrada!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        IniFile.Write(txb_name.Text, "Name", txb_name.Text);
                        IniFile.Write(txb_name.Text, "Path", txb_path.Text);
                        IniFile.Write(txb_name.Text, "Folder", "True");
                        if (cbb_add_category.SelectedItem.ToString() == "Apps")
                            IniFile.Write(txb_name.Text, "Category", "apps");
                        
                        if (cbb_add_category.SelectedItem.ToString() == "Games" ||
                                cbb_add_category.SelectedItem.ToString() == "Jogos")
                        IniFile.Write(txb_name.Text, "Category", "games");
                    }

                    IniFile.Write("Config00123456789", "FirstAcess", "no");
                    Refresh_ListView();
                }

                if (File.Exists(Application.StartupPath + "\\Config.ini"))
                {
                    if (File.Exists(Application.StartupPath + "\\Config.ini.bak"))
                        File.Delete(Application.StartupPath + "\\Config.ini.bak");
                    File.Copy(Application.StartupPath + "\\Config.ini", Application.StartupPath + "\\Config.ini.bak");
                }
                if (rdb_language_en_us.Checked)
                    MessageBox.Show("Item added successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Item adicionado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception) { }
        }

        private void chk_alphabet_CheckedChanged(object sender, EventArgs e)
        {
            Ini_exists(); // Verificar se está tudo OK com a configuração do arquivo!
            if (chk_alphabet.Checked == true)
            {
                IniFile.Write("Config00123456789", "Alphabet_Checked", "yes");
                listView1.Sorting = SortOrder.Ascending;
            }
            else
            {
                listView1.Items.Clear();
                IniFile.Write("Config00123456789", "Alphabet_Checked", "no");
                listView1.Sorting = SortOrder.None;
                Refresh_ListView();
            }
        }

        private void listView1_MouseUp(object sender, MouseEventArgs e)
        {
            Ini_exists(); // Verificar se está tudo OK com a configuração do arquivo!
            try
            {
                txb_program.Text = listView1.SelectedItems[0].Text;
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                    contextMenuStrip.Show(Cursor.Position);
            }
            catch (Exception)  { }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            Execute_Administrator();
        }

        private void txb_program_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                Ini_exists(); // Verificar se está tudo OK com a configuração do arquivo!
                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.Text.ToLower().StartsWith(txb_program.Text.ToLower()))
                    {
                        item.Selected = true;
                        item.BackColor = Color.CornflowerBlue;
                        item.ForeColor = Color.White;
                        if (e.KeyCode == Keys.Enter)
                        {
                            Execute_Administrator();
                            return;
                        }
                    }
                    else
                    {
                        item.Selected = false;
                        item.BackColor = Color.White;
                        item.ForeColor = Color.Black;
                    }
                }


                if (e.KeyCode == Keys.Enter)
                {
                    if (rdb_language_en_us.Checked)
                        MessageBox.Show("No items found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Nenhum item encontrado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception) { }
        }

        private void chk_start_with_windows_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string startUpFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);

                if (chk_start_with_windows.Checked)
                {
                    IWshRuntimeLibrary.WshShell wshShell = new IWshRuntimeLibrary.WshShell();
                    IWshRuntimeLibrary.IWshShortcut shortcut;
                    shortcut = (IWshRuntimeLibrary.IWshShortcut)wshShell.CreateShortcut(startUpFolderPath + "\\" + Application.ProductName + ".lnk");
                    shortcut.TargetPath = Application.ExecutablePath;
                    shortcut.WorkingDirectory = Application.StartupPath;
                    shortcut.Description = "Shortcut Manager";
                    shortcut.Save();
                }
                else
                    if(File.Exists(startUpFolderPath + "\\" + Application.ProductName + ".lnk"))
                        File.Delete(startUpFolderPath + "\\" + Application.ProductName + ".lnk");
            }
            catch (Exception) { }
        }

        private void btn_unnecessary_files_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdb_language_en_us.Checked)
                    MessageBox.Show("Do not close the application, It may take some time!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Não feche a aplicação, pode demorar um pouco!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFolder(Path.GetTempPath());
                ClearFolder(current_partition + @"\Windows\SoftwareDistribution\Download");
                ClearFolder(current_partition + @"\Windows\Prefetch");
                ClearFolder(current_partition + @"\Windows\Installer");
                Process.Start(current_partition + @"\WINDOWS\system32\cleanmgr.exe");
                if (rdb_language_en_us.Checked)
                    MessageBox.Show("Successfully deleted files!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Arquivos deletados com sucesso!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception) { }
        }

        private void btn_reset_program_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdb_language_en_us.Checked)
                {
                    if (MessageBox.Show("Are you sure you want to reset the program?",
                        "Info",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        if (File.Exists(Application.StartupPath + "\\Config.ini"))
                        {
                            if (File.Exists(Application.StartupPath + "\\Config.ini.bak"))
                                File.Delete(Application.StartupPath + "\\Config.ini.bak");
                            File.Delete(Application.StartupPath + "\\Config.ini");
                            Application.Restart();
                            Environment.Exit(0);
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show("Tem certeza que deseja resetar o programa?",
                        "Info",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        if (File.Exists(Application.StartupPath + "\\Config.ini"))
                        {
                            if (File.Exists(Application.StartupPath + "\\Config.ini.bak"))
                                File.Delete(Application.StartupPath + "\\Config.ini.bak");
                            File.Delete(Application.StartupPath + "\\Config.ini");
                            Application.Restart();
                            Environment.Exit(0);
                        }
                    }
                }
            }
            catch (Exception) { }
        }

        private void cbb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refresh_ListView();
        }

        private void rdb_language_en_us_CheckedChanged(object sender, EventArgs e)
        {
            Language_en_us();
        }

        private void rdb_language_pt_br_CheckedChanged(object sender, EventArgs e)
        {
            Language_pt_br();
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ini_exists(); // Verificar se está tudo OK com a configuração do arquivo!
            Edit_TxbName = listView1.SelectedItems[0].Text;
            Edit_TxbPath = IniFile.Read(listView1.SelectedItems[0].Text, "Path");
            Edit_Folder = IniFile.Read(listView1.SelectedItems[0].Text, "Folder");
            Edit_Category = IniFile.Read(listView1.SelectedItems[0].Text, "Category");
            Edit_ChkRunAsAdministrator = IniFile.Read(listView1.SelectedItems[0].Text, "Run_administrator");
            if (rdb_language_en_us.Checked)
                Edit_Language = "en-us";
            else
                Edit_Language = "pt-br";

            Form2 f2 = new Form2();
            f2.ShowDialog();
            Refresh_ListView();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ini_exists(); // Verificar se está tudo OK com a configuração do arquivo!
            if (rdb_language_en_us.Checked)
            {
                if (MessageBox.Show("Are you sure you want to remove?",
                "info",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    IniFile.Clear_Section(listView1.SelectedItems[0].Text);
                    Imagelist.Images.Clear();
                    txb_program.Text = "";
                }
                else
                    return;
            }
            else
            {
                if (MessageBox.Show("Tem certeza que deseja remover?",
                "info",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    IniFile.Clear_Section(listView1.SelectedItems[0].Text);
                    Imagelist.Images.Clear();
                    txb_program.Text = "";
                }
                else
                    return;
            }
            Refresh_ListView();
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ini_exists(); // Verificar se está tudo OK com a configuração do arquivo!

            if (File.Exists(listView1.SelectedItems[0].SubItems[1].Text))
                Process.Start(Path.GetDirectoryName(listView1.SelectedItems[0].SubItems[1].Text));
            else
            {
                if (rdb_language_en_us.Checked)
                    MessageBox.Show("Folder not found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Pasta não encontrada!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkIntegrityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ini_exists(); // Verificar se está tudo OK com a configuração do arquivo!
            if (rdb_language_en_us.Checked)
                if (CryptXor(IniFile.Read(listView1.SelectedItems[0].Text, "Path")) != IniFile.Read(listView1.SelectedItems[0].Text, "CryptXor"))
                    MessageBox.Show("File with Invalid Integrity!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("File with valid Integrity!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                if (CryptXor(IniFile.Read(listView1.SelectedItems[0].Text, "Path")) != IniFile.Read(listView1.SelectedItems[0].Text, "CryptXor"))
                    MessageBox.Show("Arquivo com Integridade inválida!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Arquivo com Integridade válida!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && listView1.SelectedItems.Count == 1)
            {
                Ini_exists(); // Verificar se está tudo OK com a configuração do arquivo!

                if (rdb_language_en_us.Checked)
                {
                    if (MessageBox.Show("Are you sure you want to remove?",
                    "info",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        IniFile.Clear_Section(listView1.SelectedItems[0].Text);
                        Imagelist.Images.Clear();
                        txb_program.Text = "";
                    }
                    else
                        return;
                }
                else
                {
                    if (MessageBox.Show("Tem certeza que deseja remover?",
                    "info",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        IniFile.Clear_Section(listView1.SelectedItems[0].Text);
                        Imagelist.Images.Clear();
                        txb_program.Text = "";
                    }
                    else
                        return;
                }
                Refresh_ListView();
            }
        }
    }
}
