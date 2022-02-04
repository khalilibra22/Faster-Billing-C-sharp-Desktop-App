namespace Facturation
{
    partial class ConfigPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.indicatorMenuBtn = new System.Windows.Forms.Panel();
            this.buyingBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.sellPointBtn = new System.Windows.Forms.Button();
            this.supplierBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.clientsBtn = new System.Windows.Forms.Button();
            this.productsBtn = new System.Windows.Forms.Button();
            this.invoiceBtn = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LastLoginTxt = new System.Windows.Forms.Label();
            this.RoleTxt = new System.Windows.Forms.Label();
            this.Deconnexion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserNameTxt = new System.Windows.Forms.Label();
            this.profilImg = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.statistiques1 = new Facturation.Controls.Statistiques();
            this.factures1 = new Facturation.Controls.Factures();
            this.produits1 = new Facturation.Controls.produits();
            this.clients1 = new Facturation.Controls.Clients();
            this.appUesrSettings1 = new Facturation.Controls.AppUesrSettings();
            this.suppliers1 = new Facturation.Controls.Suppliers();
            this.deplacements1 = new Facturation.Controls.Deplacements();
            this.buying1 = new Facturation.Controls.Buying();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilImg)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.panel1.Controls.Add(this.indicatorMenuBtn);
            this.panel1.Controls.Add(this.buyingBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.sellPointBtn);
            this.panel1.Controls.Add(this.supplierBtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.clientsBtn);
            this.panel1.Controls.Add(this.productsBtn);
            this.panel1.Controls.Add(this.invoiceBtn);
            this.panel1.Controls.Add(this.Home);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 750);
            this.panel1.TabIndex = 0;
            // 
            // indicatorMenuBtn
            // 
            this.indicatorMenuBtn.BackColor = System.Drawing.Color.White;
            this.indicatorMenuBtn.Location = new System.Drawing.Point(0, 256);
            this.indicatorMenuBtn.Name = "indicatorMenuBtn";
            this.indicatorMenuBtn.Size = new System.Drawing.Size(5, 53);
            this.indicatorMenuBtn.TabIndex = 19;
            // 
            // buyingBtn
            // 
            this.buyingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buyingBtn.FlatAppearance.BorderSize = 0;
            this.buyingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyingBtn.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyingBtn.ForeColor = System.Drawing.Color.White;
            this.buyingBtn.Image = ((System.Drawing.Image)(resources.GetObject("buyingBtn.Image")));
            this.buyingBtn.Location = new System.Drawing.Point(0, 492);
            this.buyingBtn.Name = "buyingBtn";
            this.buyingBtn.Size = new System.Drawing.Size(241, 53);
            this.buyingBtn.TabIndex = 26;
            this.buyingBtn.Text = "  Achats";
            this.buyingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buyingBtn.UseVisualStyleBackColor = true;
            this.buyingBtn.Click += new System.EventHandler(this.buyingBtn_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(1, 731);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Développé par DOUIS Ibrahim Khalil";
            // 
            // sellPointBtn
            // 
            this.sellPointBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sellPointBtn.FlatAppearance.BorderSize = 0;
            this.sellPointBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellPointBtn.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellPointBtn.ForeColor = System.Drawing.Color.White;
            this.sellPointBtn.Image = ((System.Drawing.Image)(resources.GetObject("sellPointBtn.Image")));
            this.sellPointBtn.Location = new System.Drawing.Point(0, 610);
            this.sellPointBtn.Name = "sellPointBtn";
            this.sellPointBtn.Size = new System.Drawing.Size(241, 53);
            this.sellPointBtn.TabIndex = 24;
            this.sellPointBtn.Text = " Déplacements";
            this.sellPointBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sellPointBtn.UseVisualStyleBackColor = true;
            this.sellPointBtn.Click += new System.EventHandler(this.sellPointBtn_Click);
            // 
            // supplierBtn
            // 
            this.supplierBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supplierBtn.FlatAppearance.BorderSize = 0;
            this.supplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplierBtn.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierBtn.ForeColor = System.Drawing.Color.White;
            this.supplierBtn.Image = ((System.Drawing.Image)(resources.GetObject("supplierBtn.Image")));
            this.supplierBtn.Location = new System.Drawing.Point(1, 551);
            this.supplierBtn.Name = "supplierBtn";
            this.supplierBtn.Size = new System.Drawing.Size(241, 53);
            this.supplierBtn.TabIndex = 23;
            this.supplierBtn.Text = " Fournisseurs";
            this.supplierBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.supplierBtn.UseVisualStyleBackColor = true;
            this.supplierBtn.Click += new System.EventHandler(this.supplierBtn_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(1, 708);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "© 2020 FASTER";
            // 
            // clientsBtn
            // 
            this.clientsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientsBtn.FlatAppearance.BorderSize = 0;
            this.clientsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsBtn.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsBtn.ForeColor = System.Drawing.Color.White;
            this.clientsBtn.Image = ((System.Drawing.Image)(resources.GetObject("clientsBtn.Image")));
            this.clientsBtn.Location = new System.Drawing.Point(1, 433);
            this.clientsBtn.Name = "clientsBtn";
            this.clientsBtn.Size = new System.Drawing.Size(241, 53);
            this.clientsBtn.TabIndex = 17;
            this.clientsBtn.Text = "   Clients";
            this.clientsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clientsBtn.UseVisualStyleBackColor = true;
            this.clientsBtn.Click += new System.EventHandler(this.clientsBtn_Click);
            // 
            // productsBtn
            // 
            this.productsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productsBtn.FlatAppearance.BorderSize = 0;
            this.productsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsBtn.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsBtn.ForeColor = System.Drawing.Color.White;
            this.productsBtn.Image = ((System.Drawing.Image)(resources.GetObject("productsBtn.Image")));
            this.productsBtn.Location = new System.Drawing.Point(0, 374);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Size = new System.Drawing.Size(241, 53);
            this.productsBtn.TabIndex = 16;
            this.productsBtn.Text = "    Produits";
            this.productsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.productsBtn.UseVisualStyleBackColor = true;
            this.productsBtn.Click += new System.EventHandler(this.productsBtn_Click);
            // 
            // invoiceBtn
            // 
            this.invoiceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.invoiceBtn.FlatAppearance.BorderSize = 0;
            this.invoiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invoiceBtn.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceBtn.ForeColor = System.Drawing.Color.White;
            this.invoiceBtn.Image = ((System.Drawing.Image)(resources.GetObject("invoiceBtn.Image")));
            this.invoiceBtn.Location = new System.Drawing.Point(0, 315);
            this.invoiceBtn.Name = "invoiceBtn";
            this.invoiceBtn.Size = new System.Drawing.Size(241, 53);
            this.invoiceBtn.TabIndex = 15;
            this.invoiceBtn.Text = "   Comptabilité";
            this.invoiceBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.invoiceBtn.UseVisualStyleBackColor = true;
            this.invoiceBtn.Click += new System.EventHandler(this.invoiceBtn_Click);
            // 
            // Home
            // 
            this.Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.White;
            this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
            this.Home.Location = new System.Drawing.Point(0, 256);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(241, 53);
            this.Home.TabIndex = 14;
            this.Home.Text = "   Dashboard";
            this.Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(102)))), ((int)(((byte)(183)))));
            this.panel3.Controls.Add(this.LastLoginTxt);
            this.panel3.Controls.Add(this.RoleTxt);
            this.panel3.Controls.Add(this.Deconnexion);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.UserNameTxt);
            this.panel3.Controls.Add(this.profilImg);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 231);
            this.panel3.TabIndex = 0;
            // 
            // LastLoginTxt
            // 
            this.LastLoginTxt.AutoSize = true;
            this.LastLoginTxt.Font = new System.Drawing.Font("Poppins SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastLoginTxt.ForeColor = System.Drawing.Color.White;
            this.LastLoginTxt.Location = new System.Drawing.Point(95, 171);
            this.LastLoginTxt.Name = "LastLoginTxt";
            this.LastLoginTxt.Size = new System.Drawing.Size(70, 23);
            this.LastLoginTxt.TabIndex = 14;
            this.LastLoginTxt.Text = "11/07/2019";
            // 
            // RoleTxt
            // 
            this.RoleTxt.AutoSize = true;
            this.RoleTxt.Font = new System.Drawing.Font("Poppins SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleTxt.ForeColor = System.Drawing.Color.White;
            this.RoleTxt.Location = new System.Drawing.Point(59, 145);
            this.RoleTxt.Name = "RoleTxt";
            this.RoleTxt.Size = new System.Drawing.Size(89, 23);
            this.RoleTxt.TabIndex = 13;
            this.RoleTxt.Text = "Superviseur";
            // 
            // Deconnexion
            // 
            this.Deconnexion.AutoSize = true;
            this.Deconnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deconnexion.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deconnexion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.Deconnexion.Location = new System.Drawing.Point(11, 197);
            this.Deconnexion.Name = "Deconnexion";
            this.Deconnexion.Size = new System.Drawing.Size(113, 26);
            this.Deconnexion.TabIndex = 12;
            this.Deconnexion.Text = "Déconnexion";
            this.Deconnexion.Click += new System.EventHandler(this.Deconnexion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Last login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Rôle:";
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.AutoSize = true;
            this.UserNameTxt.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTxt.ForeColor = System.Drawing.Color.White;
            this.UserNameTxt.Location = new System.Drawing.Point(58, 107);
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(98, 28);
            this.UserNameTxt.TabIndex = 9;
            this.UserNameTxt.Text = "Username";
            // 
            // profilImg
            // 
            this.profilImg.Image = ((System.Drawing.Image)(resources.GetObject("profilImg.Image")));
            this.profilImg.Location = new System.Drawing.Point(68, 32);
            this.profilImg.Name = "profilImg";
            this.profilImg.Size = new System.Drawing.Size(80, 80);
            this.profilImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.profilImg.TabIndex = 8;
            this.profilImg.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(102)))), ((int)(((byte)(183)))));
            this.panel2.Controls.Add(this.settingsBtn);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.exitBtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(241, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1129, 53);
            this.panel2.TabIndex = 1;
            // 
            // settingsBtn
            // 
            this.settingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.settingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.settingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.ForeColor = System.Drawing.Color.White;
            this.settingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("settingsBtn.Image")));
            this.settingsBtn.Location = new System.Drawing.Point(1017, 0);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(53, 53);
            this.settingsBtn.TabIndex = 16;
            this.settingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.settingsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click_1);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(845, 8);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(804, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(763, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.Location = new System.Drawing.Point(1076, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(53, 53);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Billing";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 42);
            this.label4.TabIndex = 2;
            this.label4.Text = "FASTER";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // statistiques1
            // 
            this.statistiques1.BackColor = System.Drawing.Color.White;
            this.statistiques1.Location = new System.Drawing.Point(248, 61);
            this.statistiques1.Name = "statistiques1";
            this.statistiques1.Size = new System.Drawing.Size(1111, 679);
            this.statistiques1.TabIndex = 6;
            // 
            // factures1
            // 
            this.factures1.BackColor = System.Drawing.Color.White;
            this.factures1.Location = new System.Drawing.Point(248, 61);
            this.factures1.Name = "factures1";
            this.factures1.Size = new System.Drawing.Size(1111, 679);
            this.factures1.TabIndex = 5;
            // 
            // produits1
            // 
            this.produits1.BackColor = System.Drawing.Color.White;
            this.produits1.Location = new System.Drawing.Point(248, 61);
            this.produits1.Name = "produits1";
            this.produits1.Size = new System.Drawing.Size(1111, 679);
            this.produits1.TabIndex = 4;
            // 
            // clients1
            // 
            this.clients1.BackColor = System.Drawing.Color.White;
            this.clients1.Location = new System.Drawing.Point(248, 61);
            this.clients1.Name = "clients1";
            this.clients1.Size = new System.Drawing.Size(1111, 679);
            this.clients1.TabIndex = 3;
            // 
            // appUesrSettings1
            // 
            this.appUesrSettings1.BackColor = System.Drawing.Color.White;
            this.appUesrSettings1.Location = new System.Drawing.Point(248, 61);
            this.appUesrSettings1.Name = "appUesrSettings1";
            this.appUesrSettings1.Size = new System.Drawing.Size(1111, 679);
            this.appUesrSettings1.TabIndex = 2;
            // 
            // suppliers1
            // 
            this.suppliers1.Location = new System.Drawing.Point(248, 61);
            this.suppliers1.Name = "suppliers1";
            this.suppliers1.Size = new System.Drawing.Size(1111, 679);
            this.suppliers1.TabIndex = 7;
            // 
            // deplacements1
            // 
            this.deplacements1.Location = new System.Drawing.Point(248, 61);
            this.deplacements1.Name = "deplacements1";
            this.deplacements1.Size = new System.Drawing.Size(1111, 679);
            this.deplacements1.TabIndex = 8;
            // 
            // buying1
            // 
            this.buying1.Location = new System.Drawing.Point(248, 61);
            this.buying1.Name = "buying1";
            this.buying1.Size = new System.Drawing.Size(1111, 679);
            this.buying1.TabIndex = 9;
            // 
            // ConfigPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.statistiques1);
            this.Controls.Add(this.factures1);
            this.Controls.Add(this.produits1);
            this.Controls.Add(this.clients1);
            this.Controls.Add(this.appUesrSettings1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.suppliers1);
            this.Controls.Add(this.deplacements1);
            this.Controls.Add(this.buying1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FASTER Billing";
            this.Load += new System.EventHandler(this.ConfigPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilImg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LastLoginTxt;
        private System.Windows.Forms.Label RoleTxt;
        private System.Windows.Forms.Label Deconnexion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label UserNameTxt;
        private System.Windows.Forms.PictureBox profilImg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button clientsBtn;
        private System.Windows.Forms.Button productsBtn;
        private System.Windows.Forms.Button invoiceBtn;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Panel indicatorMenuBtn;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Controls.AppUesrSettings appUesrSettings1;
        private Controls.Clients clients1;
        private Controls.produits produits1;
        private Controls.Factures factures1;
        private Controls.Statistiques statistiques1;
        private System.Windows.Forms.Button sellPointBtn;
        private System.Windows.Forms.Button supplierBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button buyingBtn;
        private Controls.Suppliers suppliers1;
        private Controls.Deplacements deplacements1;
        private Controls.Buying buying1;
        //private Controls.Clients clients1;
    }
}