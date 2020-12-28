namespace addPrefix
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.foldreListView = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.directoryLabel = new System.Windows.Forms.Label();
            this.folderBtn = new System.Windows.Forms.Button();
            this.AddPrefBtn = new System.Windows.Forms.Button();
            this.prefixTextBox = new System.Windows.Forms.TextBox();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.canselPrefixBtn = new System.Windows.Forms.Button();
            this.smallIconsPicture = new System.Windows.Forms.PictureBox();
            this.listPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.smallIconsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // foldreListView
            // 
            this.foldreListView.HideSelection = false;
            this.foldreListView.Location = new System.Drawing.Point(12, 63);
            this.foldreListView.Name = "foldreListView";
            this.foldreListView.Size = new System.Drawing.Size(308, 386);
            this.foldreListView.SmallImageList = this.imageList1;
            this.foldreListView.TabIndex = 0;
            this.foldreListView.UseCompatibleStateImageBehavior = false;
            this.foldreListView.View = System.Windows.Forms.View.List;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "10.png");
            this.imageList1.Images.SetKeyName(1, "List-PNG-Clipart.png");
            this.imageList1.Images.SetKeyName(2, "smallicons.png");
            // 
            // directoryLabel
            // 
            this.directoryLabel.AutoSize = true;
            this.directoryLabel.Location = new System.Drawing.Point(12, 452);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(35, 13);
            this.directoryLabel.TabIndex = 1;
            this.directoryLabel.Text = "curDir";
            this.directoryLabel.Visible = false;
            // 
            // folderBtn
            // 
            this.folderBtn.Location = new System.Drawing.Point(12, 8);
            this.folderBtn.Name = "folderBtn";
            this.folderBtn.Size = new System.Drawing.Size(91, 24);
            this.folderBtn.TabIndex = 2;
            this.folderBtn.Text = "FOLDER";
            this.folderBtn.UseVisualStyleBackColor = true;
            this.folderBtn.Click += new System.EventHandler(this.folderBtn_Click);
            // 
            // AddPrefBtn
            // 
            this.AddPrefBtn.Enabled = false;
            this.AddPrefBtn.Location = new System.Drawing.Point(237, 34);
            this.AddPrefBtn.Name = "AddPrefBtn";
            this.AddPrefBtn.Size = new System.Drawing.Size(91, 23);
            this.AddPrefBtn.TabIndex = 3;
            this.AddPrefBtn.Text = "ADD PREFIX";
            this.AddPrefBtn.UseVisualStyleBackColor = true;
            this.AddPrefBtn.Click += new System.EventHandler(this.AddPrefBtn_Click);
            // 
            // prefixTextBox
            // 
            this.prefixTextBox.Location = new System.Drawing.Point(237, 8);
            this.prefixTextBox.Name = "prefixTextBox";
            this.prefixTextBox.Size = new System.Drawing.Size(91, 20);
            this.prefixTextBox.TabIndex = 4;
            this.prefixTextBox.TextChanged += new System.EventHandler(this.prefixTextBox_TextChanged);
            // 
            // fbd
            // 
            this.fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // canselPrefixBtn
            // 
            this.canselPrefixBtn.Enabled = false;
            this.canselPrefixBtn.Location = new System.Drawing.Point(206, 34);
            this.canselPrefixBtn.Name = "canselPrefixBtn";
            this.canselPrefixBtn.Size = new System.Drawing.Size(25, 23);
            this.canselPrefixBtn.TabIndex = 5;
            this.canselPrefixBtn.Text = "🠔";
            this.canselPrefixBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.canselPrefixBtn.UseVisualStyleBackColor = true;
            this.canselPrefixBtn.Click += new System.EventHandler(this.canselPrefixBtn_Click);
            // 
            // smallIconsPicture
            // 
            this.smallIconsPicture.Image = ((System.Drawing.Image)(resources.GetObject("smallIconsPicture.Image")));
            this.smallIconsPicture.Location = new System.Drawing.Point(179, 8);
            this.smallIconsPicture.Name = "smallIconsPicture";
            this.smallIconsPicture.Size = new System.Drawing.Size(21, 20);
            this.smallIconsPicture.TabIndex = 6;
            this.smallIconsPicture.TabStop = false;
            this.smallIconsPicture.Click += new System.EventHandler(this.smallIconsPicture_Click);
            // 
            // listPicture
            // 
            this.listPicture.Image = ((System.Drawing.Image)(resources.GetObject("listPicture.Image")));
            this.listPicture.Location = new System.Drawing.Point(206, 8);
            this.listPicture.Name = "listPicture";
            this.listPicture.Size = new System.Drawing.Size(25, 20);
            this.listPicture.TabIndex = 7;
            this.listPicture.TabStop = false;
            this.listPicture.Click += new System.EventHandler(this.listPicture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 471);
            this.Controls.Add(this.listPicture);
            this.Controls.Add(this.smallIconsPicture);
            this.Controls.Add(this.canselPrefixBtn);
            this.Controls.Add(this.prefixTextBox);
            this.Controls.Add(this.AddPrefBtn);
            this.Controls.Add(this.folderBtn);
            this.Controls.Add(this.directoryLabel);
            this.Controls.Add(this.foldreListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "PrefixAdder";
            ((System.ComponentModel.ISupportInitialize)(this.smallIconsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView foldreListView;
        private System.Windows.Forms.Label directoryLabel;
        private System.Windows.Forms.Button folderBtn;
        private System.Windows.Forms.Button AddPrefBtn;
        private System.Windows.Forms.TextBox prefixTextBox;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button canselPrefixBtn;
        private System.Windows.Forms.PictureBox smallIconsPicture;
        private System.Windows.Forms.PictureBox listPicture;
    }
}

