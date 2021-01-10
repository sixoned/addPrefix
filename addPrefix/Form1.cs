using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace addPrefix
{
   
    public partial class Form1 : Form
    {
        string[] files, mirrorFiles, cancellNames;
        IniFile myIniFile, startIniFile;
        public void checkPrefix(string str) {
            if (str.Contains("\\") | str.Contains("/") |
                str.Contains(":") | str.Contains("*") |
                str.Contains("?") | str.Contains(":") |
                str.Contains(Convert.ToString('"')) |
                str.Contains("<") | str.Contains(">") |
                str.Contains("|") | str.Contains("+"))
            {
                directoryLabel.Text = "НЕДОПУСТИМЫЙ СИМВОЛ ПРЕФИКСА!";             
                AddPrefBtn.Enabled = false;
                canselPrefixBtn.Enabled = false;
            }
            else {
                directoryLabel.Text = fbd.SelectedPath;
                AddPrefBtn.Enabled = true;
                canselPrefixBtn.Enabled = true;
            }
        }
        void refreshListView() {

            List<myFile> myFilesList = new List<myFile>();
            files = Directory.GetFiles(fbd.SelectedPath);
            mirrorFiles = Directory.GetFiles(fbd.SelectedPath);

            directoryLabel.Visible = true;
            directoryLabel.Text = fbd.SelectedPath;
            for (int i = 0; i < files.Length; i++)
            {
                string fileName = files[i].Remove(0, files[i].LastIndexOf('\\') + 1);
                string fileCreationDate = File.GetCreationTime(mirrorFiles[i]).ToString();
                FileInfo file = new FileInfo(mirrorFiles[i]);
                long fileSize = file.Length;
                

                fileCreationDate =  fileCreationDate.Substring(0, fileCreationDate.LastIndexOf(' '));                         
                myFilesList.Add(new myFile(fileName, fileCreationDate, commonFunctions.BytesToString(fileSize)));
              
                foldreListView.Items.Add(new ListViewItem(new[] { myFilesList[i].fileName,
                                         myFilesList[i].creationDate ,myFilesList[i].fileSize}));
                foldreListView.Items[i].ImageIndex = 0;
            }
            if (!File.Exists("settings.ini"))
            {
                myIniFile = new IniFile("settings.ini");
                myIniFile.Write("Last directory", fbd.SelectedPath);
            }
            else {
                File.Delete("settings.ini");
                myIniFile = new IniFile("settings.ini");
                myIniFile.Write("Last directory", fbd.SelectedPath);
            }
           
        }
        
        public Form1()
        {
            InitializeComponent();
        }
        private void canselPrefixBtn_Click(object sender, EventArgs e)
        {
            AddPrefBtn.Enabled = true;
            canselPrefixBtn.Enabled = false;
            for (int i = 0; i < foldreListView.Items.Count; i++)
            {
                File.Move(directoryLabel.Text + "\\" + foldreListView.Items[i].Text,
                    directoryLabel.Text + "\\"   + cancellNames[i]);
            }
            foldreListView.Items.Clear();
            refreshListView();
            prefixTextBox.Text = String.Empty;
        }

        private void prefixTextBox_TextChanged(object sender, EventArgs e)
        {
            checkPrefix(prefixTextBox.Text);
        }

        private void smallIconsPicture_Click(object sender, EventArgs e)
        {
            if (foldreListView.Items.Count > 0)
            {
                foldreListView.View = View.SmallIcon;
                smallIconsPicture.BorderStyle = BorderStyle.Fixed3D;
                listPicture.BorderStyle = BorderStyle.None;
                tableIconPicture.BorderStyle = BorderStyle.None;
            }
        }

        private void listPicture_Click(object sender, EventArgs e)
        {
            if (foldreListView.Items.Count > 0)
            {
                foldreListView.View = View.List;
                listPicture.BorderStyle = BorderStyle.Fixed3D;
                smallIconsPicture.BorderStyle = BorderStyle.None;
                tableIconPicture.BorderStyle = BorderStyle.None;
            }
        }

        private void plusPrefixBtn_Click(object sender, EventArgs e)
        {
            AddPrefBtn.Enabled = true;
            plusPrefixBtn.Enabled = false;
            prefixTextBox.Text = String.Empty;
        }

        private void tableIconPicture_Click(object sender, EventArgs e)
        {
            if (foldreListView.Items.Count > 0)
            {
                foldreListView.View = View.Details;
                tableIconPicture.BorderStyle = BorderStyle.Fixed3D;
                smallIconsPicture.BorderStyle = BorderStyle.None;
                listPicture.BorderStyle = BorderStyle.None;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("settings.ini"))
            {
                try
                {
                    startIniFile = new IniFile(@"settings.ini");

                    List<myFile> myFilesList = new List<myFile>();
                    files = Directory.GetFiles(startIniFile.Read("Last directory"));
                    mirrorFiles = Directory.GetFiles(startIniFile.Read("Last directory"));

                    directoryLabel.Visible = true;
                    directoryLabel.Text = startIniFile.Read("Last directory");
                    for (int i = 0; i < files.Length; i++)
                    {
                        string fileName = files[i].Remove(0, files[i].LastIndexOf('\\') + 1);
                        string fileCreationDate = File.GetCreationTime(mirrorFiles[i]).ToString();
                        FileInfo file = new FileInfo(mirrorFiles[i]);
                        long fileSize = file.Length;


                        fileCreationDate = fileCreationDate.Substring(0, fileCreationDate.LastIndexOf(' '));
                        myFilesList.Add(new myFile(fileName, fileCreationDate, commonFunctions.BytesToString(fileSize)));

                        foldreListView.Items.Add(new ListViewItem(new[] { myFilesList[i].fileName,
                                         myFilesList[i].creationDate ,myFilesList[i].fileSize}));
                        foldreListView.Items[i].ImageIndex = 0;
                    }
                }

                catch {
                    File.Delete("settings.ini");
                }
            }
        }

        private void folderBtn_Click(object sender, EventArgs e)
        {
            
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                tableIconPicture.BorderStyle = BorderStyle.Fixed3D;
                AddPrefBtn.Enabled = true;
                foldreListView.Items.Clear();
                refreshListView();

            }
        }

        private void AddPrefBtn_Click(object sender, EventArgs e)
        {
            AddPrefBtn.Enabled = false;
            canselPrefixBtn.Enabled = true;
            plusPrefixBtn.Enabled = true;
            string addingPrefix = prefixTextBox.Text;
            cancellNames = new string[foldreListView.Items.Count];   
            for (int i = 0; i < foldreListView.Items.Count; i++) {
                cancellNames[i] = foldreListView.Items[i].Text;
            }
            for (int i = 0; i < foldreListView.Items.Count; i++)
            {
                File.Move(directoryLabel.Text + "\\" + foldreListView.Items[i].Text,
                    directoryLabel.Text + "\\" + addingPrefix + foldreListView.Items[i].Text);
            }
            foldreListView.Items.Clear();
            refreshListView();
        }
    }
}
