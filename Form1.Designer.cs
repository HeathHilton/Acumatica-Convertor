namespace Acumatica_Convertor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblMethodTitle = new Label();
            imageList1 = new ImageList(components);
            pictureBox4 = new PictureBox();
            importPathLbl = new Label();
            setImportBtn = new Button();
            exportPathLbl = new Label();
            setExportBtn = new Button();
            label2 = new Label();
            taxStatusLBL = new Label();
            jobNumET = new TextBox();
            exportBtn = new Button();
            exemptCB = new ComboBox();
            btnQView = new Button();
            cbChangeOrder = new CheckBox();
            cbMilesToInstall = new CheckBox();
            gbCSVImport = new GroupBox();
            rtbJetOutputPreview = new RichTextBox();
            BtnMargin = new Button();
            BtnSalesforce = new Button();
            imageLogo = new PictureBox();
            label1 = new Label();
            imageJet = new PictureBox();
            imageMargin = new PictureBox();
            imageSalesforce = new PictureBox();
            gbVersion = new GroupBox();
            imageInfo = new PictureBox();
            lblVersion = new Label();
            pictureBox1 = new PictureBox();
            exitBtn = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            BtnJetParts = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            gbCSVImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageJet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageMargin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageSalesforce).BeginInit();
            gbVersion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitBtn).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblMethodTitle
            // 
            lblMethodTitle.Font = new Font("Tahoma", 28.125F, FontStyle.Regular, GraphicsUnit.Point);
            lblMethodTitle.ForeColor = Color.Black;
            lblMethodTitle.Location = new Point(492, 48);
            lblMethodTitle.Margin = new Padding(0);
            lblMethodTitle.Name = "lblMethodTitle";
            lblMethodTitle.Size = new Size(1000, 135);
            lblMethodTitle.TabIndex = 2;
            lblMethodTitle.Text = "Select a task to begin ...";
            lblMethodTitle.TextAlign = ContentAlignment.BottomLeft;
            lblMethodTitle.Click += lblMethodTitle_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Image = Properties.Resources.Grey_Line;
            pictureBox4.Location = new Point(492, 198);
            pictureBox4.MinimumSize = new Size(750, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Padding = new Padding(0, 0, 50, 0);
            pictureBox4.Size = new Size(1000, 5);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // importPathLbl
            // 
            importPathLbl.BackColor = Color.Transparent;
            importPathLbl.ForeColor = Color.DimGray;
            importPathLbl.ImageAlign = ContentAlignment.MiddleRight;
            importPathLbl.Location = new Point(213, 81);
            importPathLbl.Margin = new Padding(6, 0, 6, 0);
            importPathLbl.Name = "importPathLbl";
            importPathLbl.RightToLeft = RightToLeft.No;
            importPathLbl.Size = new Size(435, 80);
            importPathLbl.TabIndex = 33;
            importPathLbl.Text = "Import Path";
            importPathLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // setImportBtn
            // 
            setImportBtn.BackColor = Color.DarkGray;
            setImportBtn.Location = new Point(9, 75);
            setImportBtn.Margin = new Padding(6);
            setImportBtn.Name = "setImportBtn";
            setImportBtn.Size = new Size(192, 49);
            setImportBtn.TabIndex = 4;
            setImportBtn.Text = "Set Import Path";
            setImportBtn.UseVisualStyleBackColor = false;
            setImportBtn.Click += setImportBtn_Click;
            // 
            // exportPathLbl
            // 
            exportPathLbl.BackColor = Color.Transparent;
            exportPathLbl.ForeColor = Color.DimGray;
            exportPathLbl.ImageAlign = ContentAlignment.MiddleRight;
            exportPathLbl.Location = new Point(832, 81);
            exportPathLbl.Margin = new Padding(6, 0, 6, 0);
            exportPathLbl.Name = "exportPathLbl";
            exportPathLbl.RightToLeft = RightToLeft.No;
            exportPathLbl.Size = new Size(435, 80);
            exportPathLbl.TabIndex = 34;
            exportPathLbl.Text = "Export Path";
            exportPathLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // setExportBtn
            // 
            setExportBtn.BackColor = Color.DarkGray;
            setExportBtn.Location = new Point(660, 75);
            setExportBtn.Margin = new Padding(6);
            setExportBtn.Name = "setExportBtn";
            setExportBtn.Size = new Size(147, 49);
            setExportBtn.TabIndex = 6;
            setExportBtn.Text = "Set Export Path";
            setExportBtn.UseVisualStyleBackColor = false;
            setExportBtn.Click += setExportBtn_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.DarkGray;
            label2.Location = new Point(69, 19);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(4);
            label2.Size = new Size(126, 45);
            label2.TabIndex = 36;
            label2.Text = "Job Number:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // taxStatusLBL
            // 
            taxStatusLBL.AutoSize = true;
            taxStatusLBL.BackColor = Color.DarkGray;
            taxStatusLBL.Location = new Point(844, 30);
            taxStatusLBL.Margin = new Padding(6, 0, 6, 0);
            taxStatusLBL.Name = "taxStatusLBL";
            taxStatusLBL.Padding = new Padding(4);
            taxStatusLBL.Size = new Size(78, 22);
            taxStatusLBL.TabIndex = 38;
            taxStatusLBL.Text = "Tax Status:";
            // 
            // jobNumET
            // 
            jobNumET.Location = new Point(210, 30);
            jobNumET.Margin = new Padding(4, 2, 4, 2);
            jobNumET.MaxLength = 9;
            jobNumET.Name = "jobNumET";
            jobNumET.PlaceholderText = "Qx-##-###";
            jobNumET.Size = new Size(150, 22);
            jobNumET.TabIndex = 0;
            // 
            // exportBtn
            // 
            exportBtn.BackColor = Color.DarkGray;
            exportBtn.Location = new Point(660, 127);
            exportBtn.Margin = new Padding(6);
            exportBtn.Name = "exportBtn";
            exportBtn.Size = new Size(147, 42);
            exportBtn.TabIndex = 7;
            exportBtn.Text = "Export";
            exportBtn.UseVisualStyleBackColor = false;
            exportBtn.Click += exportBtn_Click;
            // 
            // exemptCB
            // 
            exemptCB.FormattingEnabled = true;
            exemptCB.Items.AddRange(new object[] { " ", "Exempt", "Non-Exempt" });
            exemptCB.Location = new Point(947, 30);
            exemptCB.Margin = new Padding(6);
            exemptCB.Name = "exemptCB";
            exemptCB.Size = new Size(179, 22);
            exemptCB.TabIndex = 3;
            // 
            // btnQView
            // 
            btnQView.BackColor = Color.DarkGray;
            btnQView.Location = new Point(9, 127);
            btnQView.Margin = new Padding(6);
            btnQView.Name = "btnQView";
            btnQView.Size = new Size(192, 42);
            btnQView.TabIndex = 5;
            btnQView.Text = "Quick View";
            btnQView.UseVisualStyleBackColor = false;
            btnQView.Click += btnQView_Click;
            // 
            // cbChangeOrder
            // 
            cbChangeOrder.ForeColor = Color.Black;
            cbChangeOrder.Location = new Point(394, 19);
            cbChangeOrder.Margin = new Padding(0);
            cbChangeOrder.Name = "cbChangeOrder";
            cbChangeOrder.Size = new Size(200, 45);
            cbChangeOrder.TabIndex = 1;
            cbChangeOrder.Text = "Change Order";
            cbChangeOrder.UseVisualStyleBackColor = true;
            // 
            // cbMilesToInstall
            // 
            cbMilesToInstall.Checked = true;
            cbMilesToInstall.CheckState = CheckState.Checked;
            cbMilesToInstall.ForeColor = Color.Black;
            cbMilesToInstall.Location = new Point(615, 19);
            cbMilesToInstall.Margin = new Padding(0);
            cbMilesToInstall.Name = "cbMilesToInstall";
            cbMilesToInstall.Size = new Size(200, 45);
            cbMilesToInstall.TabIndex = 2;
            cbMilesToInstall.Text = "Mileage on Install";
            cbMilesToInstall.UseVisualStyleBackColor = true;
            cbMilesToInstall.CheckedChanged += cbMilesToInstall_CheckedChanged;
            // 
            // gbCSVImport
            // 
            gbCSVImport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbCSVImport.AutoSize = true;
            gbCSVImport.Controls.Add(cbMilesToInstall);
            gbCSVImport.Controls.Add(cbChangeOrder);
            gbCSVImport.Controls.Add(btnQView);
            gbCSVImport.Controls.Add(exemptCB);
            gbCSVImport.Controls.Add(exportBtn);
            gbCSVImport.Controls.Add(jobNumET);
            gbCSVImport.Controls.Add(taxStatusLBL);
            gbCSVImport.Controls.Add(label2);
            gbCSVImport.Controls.Add(setExportBtn);
            gbCSVImport.Controls.Add(exportPathLbl);
            gbCSVImport.Controls.Add(setImportBtn);
            gbCSVImport.Controls.Add(importPathLbl);
            gbCSVImport.Controls.Add(rtbJetOutputPreview);
            gbCSVImport.Location = new Point(492, 227);
            gbCSVImport.Name = "gbCSVImport";
            gbCSVImport.Size = new Size(1408, 900);
            gbCSVImport.TabIndex = 0;
            gbCSVImport.TabStop = false;
            gbCSVImport.Visible = false;
            // 
            // rtbJetOutputPreview
            // 
            rtbJetOutputPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbJetOutputPreview.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rtbJetOutputPreview.Location = new Point(9, 178);
            rtbJetOutputPreview.Name = "rtbJetOutputPreview";
            rtbJetOutputPreview.Size = new Size(1380, 703);
            rtbJetOutputPreview.TabIndex = 8;
            rtbJetOutputPreview.Text = "";
            rtbJetOutputPreview.WordWrap = false;
            // 
            // BtnMargin
            // 
            BtnMargin.AutoSize = true;
            BtnMargin.BackColor = Color.Transparent;
            BtnMargin.FlatAppearance.BorderColor = Color.FromArgb(13, 131, 221);
            BtnMargin.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 131, 221);
            BtnMargin.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 131, 221);
            BtnMargin.FlatStyle = FlatStyle.Flat;
            BtnMargin.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnMargin.ForeColor = Color.Transparent;
            BtnMargin.ImageAlign = ContentAlignment.MiddleLeft;
            BtnMargin.Location = new Point(181, 466);
            BtnMargin.Margin = new Padding(0);
            BtnMargin.Name = "BtnMargin";
            BtnMargin.Size = new Size(251, 79);
            BtnMargin.TabIndex = 7;
            BtnMargin.Text = "Margin Worksheet";
            BtnMargin.TextAlign = ContentAlignment.MiddleRight;
            BtnMargin.UseVisualStyleBackColor = false;
            BtnMargin.Click += BtnMargin_Click;
            // 
            // BtnSalesforce
            // 
            BtnSalesforce.AutoSize = true;
            BtnSalesforce.BackColor = Color.Transparent;
            BtnSalesforce.FlatAppearance.BorderColor = Color.FromArgb(13, 131, 221);
            BtnSalesforce.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 131, 221);
            BtnSalesforce.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 131, 221);
            BtnSalesforce.FlatStyle = FlatStyle.Flat;
            BtnSalesforce.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSalesforce.ForeColor = Color.Transparent;
            BtnSalesforce.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSalesforce.Location = new Point(181, 566);
            BtnSalesforce.Margin = new Padding(0);
            BtnSalesforce.Name = "BtnSalesforce";
            BtnSalesforce.Size = new Size(251, 79);
            BtnSalesforce.TabIndex = 7;
            BtnSalesforce.Text = "Salesforce";
            BtnSalesforce.TextAlign = ContentAlignment.MiddleRight;
            BtnSalesforce.UseVisualStyleBackColor = false;
            BtnSalesforce.Click += BtnSalesforce_Click;
            // 
            // imageLogo
            // 
            imageLogo.BackgroundImageLayout = ImageLayout.Stretch;
            imageLogo.Image = Properties.Resources.Envelop_Logo___EN_only;
            imageLogo.Location = new Point(106, 48);
            imageLogo.MaximumSize = new Size(300, 300);
            imageLogo.Name = "imageLogo";
            imageLogo.Size = new Size(250, 250);
            imageLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            imageLogo.TabIndex = 0;
            imageLogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(124, 328);
            label1.Name = "label1";
            label1.Size = new Size(210, 14);
            label1.TabIndex = 2;
            label1.Text = "_____________________________";
            // 
            // imageJet
            // 
            imageJet.BackColor = Color.Transparent;
            imageJet.BackgroundImageLayout = ImageLayout.Stretch;
            imageJet.Image = Properties.Resources.Parts_Icon;
            imageJet.Location = new Point(46, 378);
            imageJet.Margin = new Padding(0);
            imageJet.MaximumSize = new Size(150, 150);
            imageJet.Name = "imageJet";
            imageJet.Size = new Size(60, 60);
            imageJet.SizeMode = PictureBoxSizeMode.StretchImage;
            imageJet.TabIndex = 3;
            imageJet.TabStop = false;
            imageJet.Click += imageJet_Click;
            // 
            // imageMargin
            // 
            imageMargin.BackColor = Color.Transparent;
            imageMargin.BackgroundImageLayout = ImageLayout.Stretch;
            imageMargin.Image = Properties.Resources.Margin_Icon;
            imageMargin.Location = new Point(46, 478);
            imageMargin.Margin = new Padding(0);
            imageMargin.MaximumSize = new Size(150, 150);
            imageMargin.Name = "imageMargin";
            imageMargin.Size = new Size(60, 60);
            imageMargin.SizeMode = PictureBoxSizeMode.StretchImage;
            imageMargin.TabIndex = 5;
            imageMargin.TabStop = false;
            imageMargin.Click += imageMargin_Click;
            // 
            // imageSalesforce
            // 
            imageSalesforce.BackColor = Color.Transparent;
            imageSalesforce.BackgroundImageLayout = ImageLayout.Stretch;
            imageSalesforce.Image = (Image)resources.GetObject("imageSalesforce.Image");
            imageSalesforce.Location = new Point(46, 578);
            imageSalesforce.Margin = new Padding(0);
            imageSalesforce.MaximumSize = new Size(150, 150);
            imageSalesforce.Name = "imageSalesforce";
            imageSalesforce.Size = new Size(60, 60);
            imageSalesforce.SizeMode = PictureBoxSizeMode.StretchImage;
            imageSalesforce.TabIndex = 5;
            imageSalesforce.TabStop = false;
            imageSalesforce.Click += imageMargin_Click;
            // 
            // gbVersion
            // 
            gbVersion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            gbVersion.Controls.Add(imageInfo);
            gbVersion.Controls.Add(lblVersion);
            gbVersion.FlatStyle = FlatStyle.Flat;
            gbVersion.ForeColor = Color.Transparent;
            gbVersion.Location = new Point(67, 964);
            gbVersion.Name = "gbVersion";
            gbVersion.Size = new Size(321, 114);
            gbVersion.TabIndex = 10;
            gbVersion.TabStop = false;
            // 
            // imageInfo
            // 
            imageInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            imageInfo.BackColor = Color.Transparent;
            imageInfo.BackgroundImageLayout = ImageLayout.Stretch;
            imageInfo.Image = Properties.Resources.info;
            imageInfo.Location = new Point(132, 21);
            imageInfo.Margin = new Padding(3, 3, 3, 60);
            imageInfo.MaximumSize = new Size(150, 150);
            imageInfo.Name = "imageInfo";
            imageInfo.Size = new Size(60, 60);
            imageInfo.SizeMode = PictureBoxSizeMode.StretchImage;
            imageInfo.TabIndex = 9;
            imageInfo.TabStop = false;
            imageInfo.Click += imageInfo_Click;
            // 
            // lblVersion
            // 
            lblVersion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblVersion.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblVersion.ForeColor = Color.Black;
            lblVersion.ImageAlign = ContentAlignment.BottomCenter;
            lblVersion.Location = new Point(3, 83);
            lblVersion.Margin = new Padding(0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(315, 25);
            lblVersion.TabIndex = 8;
            lblVersion.Text = "v#.#####";
            lblVersion.TextAlign = ContentAlignment.BottomCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.New_Icon;
            pictureBox1.Location = new Point(147, 887);
            pictureBox1.MaximumSize = new Size(150, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += newBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            exitBtn.BackColor = Color.Transparent;
            exitBtn.BackgroundImageLayout = ImageLayout.Stretch;
            exitBtn.Image = Properties.Resources.Exit_Icon;
            exitBtn.Location = new Point(258, 887);
            exitBtn.MaximumSize = new Size(150, 150);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(60, 60);
            exitBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            exitBtn.TabIndex = 11;
            exitBtn.TabStop = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(13, 131, 221);
            panel1.Controls.Add(exitBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(gbVersion);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(imageSalesforce);
            panel1.Controls.Add(imageMargin);
            panel1.Controls.Add(imageJet);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(imageLogo);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(BtnSalesforce);
            panel1.Controls.Add(BtnJetParts);
            panel1.Controls.Add(BtnMargin);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(456, 1181);
            panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(46, 678);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.MaximumSize = new Size(150, 150);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            pictureBox2.Click += imageMargin_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderColor = Color.FromArgb(13, 131, 221);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 131, 221);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 131, 221);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Transparent;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(181, 666);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(251, 79);
            button1.TabIndex = 7;
            button1.Text = "Datasheet Submittal";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += BtnSalesforce_Click;
            // 
            // BtnJetParts
            // 
            BtnJetParts.AutoSize = true;
            BtnJetParts.BackColor = Color.Transparent;
            BtnJetParts.FlatAppearance.BorderColor = Color.FromArgb(13, 131, 221);
            BtnJetParts.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 131, 221);
            BtnJetParts.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 131, 221);
            BtnJetParts.FlatStyle = FlatStyle.Flat;
            BtnJetParts.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnJetParts.ForeColor = Color.Transparent;
            BtnJetParts.ImageAlign = ContentAlignment.MiddleLeft;
            BtnJetParts.Location = new Point(181, 366);
            BtnJetParts.Margin = new Padding(0);
            BtnJetParts.Name = "BtnJetParts";
            BtnJetParts.Size = new Size(251, 79);
            BtnJetParts.TabIndex = 7;
            BtnJetParts.Text = "PO Ordering";
            BtnJetParts.TextAlign = ContentAlignment.MiddleRight;
            BtnJetParts.UseVisualStyleBackColor = false;
            BtnJetParts.Click += BtnJetParts_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(251, 253, 254);
            ClientSize = new Size(1912, 1139);
            Controls.Add(gbCSVImport);
            Controls.Add(panel1);
            Controls.Add(pictureBox4);
            Controls.Add(lblMethodTitle);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Transparent;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acumatica Convertor";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            gbCSVImport.ResumeLayout(false);
            gbCSVImport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imageLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageJet).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageMargin).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageSalesforce).EndInit();
            gbVersion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imageInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitBtn).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList imageList1;
        private Label lblMethodTitle;
        private Label label3;
        private PictureBox pictureBox4;
        private Button btnJetParts;
        private Button importBtn;
        private Button closeBtn;
        private Button newBtn;
        private Label importPathLbl;
        private Button setImportBtn;
        private Label exportPathLbl;
        private Button setExportBtn;
        private Label label2;
        private Label taxStatusLBL;
        private TextBox jobNumET;
        private Button exportBtn;
        private ComboBox exemptCB;
        private Button btnQView;
        private CheckBox cbChangeOrder;
        private CheckBox cbMilesToInstall;
        private GroupBox gbCSVImport;
        private RichTextBox rtbJetOutputPreview;
        private Button BtnMargin;
        private Button BtnSalesforce;
        private PictureBox imageLogo;
        private Label label1;
        private PictureBox imageJet;
        private PictureBox imageMargin;
        private PictureBox imageSalesforce;
        private GroupBox gbVersion;
        private PictureBox imageInfo;
        private Label lblVersion;
        private PictureBox pictureBox1;
        private PictureBox exitBtn;
        private Panel panel1;
        private Button BtnJetParts;
        private PictureBox pictureBox2;
        private Button button1;
    }
}