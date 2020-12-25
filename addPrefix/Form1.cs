﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace addPrefix
{
   
    public partial class Form1 : Form
    {
        void refreshListView() {


            files = Directory.GetFiles(fbd.SelectedPath);
            mirrorFiles = Directory.GetFiles(fbd.SelectedPath);

            directoryLabel.Visible = true;
            directoryLabel.Text = fbd.SelectedPath;
            for (int i = 0; i < files.Length; i++)
            {
                ListViewItem folderItem = new ListViewItem();
                folderItem.Text = files[i].Remove(0, files[i].LastIndexOf('\\') + 1);
                foldreListView.Items.Add(folderItem);
                foldreListView.Items[i].ImageIndex = 0;
            }

        }
        string[] files, mirrorFiles, cancellNames;
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
        }

        private void folderBtn_Click(object sender, EventArgs e)
        {
            
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                AddPrefBtn.Enabled = true;
                foldreListView.Items.Clear();
                refreshListView();

            }
        }

        private void AddPrefBtn_Click(object sender, EventArgs e)
        {
            AddPrefBtn.Enabled = false;
            canselPrefixBtn.Enabled = true;
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