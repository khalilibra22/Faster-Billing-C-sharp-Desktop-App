namespace Facturation.Controls
{
    partial class Suppliers
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suppliers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchBtn = new System.Windows.Forms.PictureBox();
            this.SuppBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.wilayaBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.addressBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.emailBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.makePaymentBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.Annule = new System.Windows.Forms.Label();
            this.AppliquerModifs = new System.Windows.Forms.Button();
            this.ADDBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.suppliersGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditBtn = new System.Windows.Forms.Button();
            this.panelOfPayement = new System.Windows.Forms.Panel();
            this.closeAll = new Bunifu.Framework.UI.BunifuImageButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pyAmountBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.pyClientName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.pyClientId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.doPaymentBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makePaymentBtn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersGridView)).BeginInit();
            this.panelOfPayement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeAll)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.Location = new System.Drawing.Point(1041, 106);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(25, 25);
            this.searchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchBtn.TabIndex = 143;
            this.searchBtn.TabStop = false;
            // 
            // SuppBtn
            // 
            this.SuppBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SuppBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SuppBtn.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.SuppBtn.Image = ((System.Drawing.Image)(resources.GetObject("SuppBtn.Image")));
            this.SuppBtn.Location = new System.Drawing.Point(418, 557);
            this.SuppBtn.Name = "SuppBtn";
            this.SuppBtn.Size = new System.Drawing.Size(224, 41);
            this.SuppBtn.TabIndex = 137;
            this.SuppBtn.Text = "  SUPPRIMER";
            this.SuppBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SuppBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SuppBtn.UseVisualStyleBackColor = true;
            this.SuppBtn.Click += new System.EventHandler(this.SuppBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(102)))), ((int)(((byte)(183)))));
            this.label5.Location = new System.Drawing.Point(619, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 28);
            this.label5.TabIndex = 135;
            this.label5.Text = "Rechercher par nom";
            // 
            // wilayaBox
            // 
            this.wilayaBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.wilayaBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.wilayaBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.wilayaBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.wilayaBox.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wilayaBox.ForeColor = System.Drawing.Color.Gray;
            this.wilayaBox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.wilayaBox.HintText = "ORAN...";
            this.wilayaBox.isPassword = false;
            this.wilayaBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.wilayaBox.LineIdleColor = System.Drawing.Color.Gray;
            this.wilayaBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.wilayaBox.LineThickness = 5;
            this.wilayaBox.Location = new System.Drawing.Point(32, 188);
            this.wilayaBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.wilayaBox.MaxLength = 32767;
            this.wilayaBox.Name = "wilayaBox";
            this.wilayaBox.Size = new System.Drawing.Size(292, 38);
            this.wilayaBox.TabIndex = 89;
            this.wilayaBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.label7.Location = new System.Drawing.Point(28, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 28);
            this.label7.TabIndex = 88;
            this.label7.Text = "Wilaya / Commune";
            // 
            // addressBox
            // 
            this.addressBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.addressBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.addressBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.addressBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressBox.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBox.ForeColor = System.Drawing.Color.Gray;
            this.addressBox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.addressBox.HintText = "abcd...";
            this.addressBox.isPassword = false;
            this.addressBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.addressBox.LineIdleColor = System.Drawing.Color.Gray;
            this.addressBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.addressBox.LineThickness = 5;
            this.addressBox.Location = new System.Drawing.Point(33, 115);
            this.addressBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addressBox.MaxLength = 32767;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(292, 38);
            this.addressBox.TabIndex = 87;
            this.addressBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // emailBox
            // 
            this.emailBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.emailBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.emailBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.emailBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailBox.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.ForeColor = System.Drawing.Color.Gray;
            this.emailBox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.emailBox.HintText = "email@em....";
            this.emailBox.isPassword = false;
            this.emailBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.emailBox.LineIdleColor = System.Drawing.Color.Gray;
            this.emailBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.emailBox.LineThickness = 5;
            this.emailBox.Location = new System.Drawing.Point(33, 327);
            this.emailBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.emailBox.MaxLength = 32767;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(292, 38);
            this.emailBox.TabIndex = 86;
            this.emailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.label4.Location = new System.Drawing.Point(29, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 28);
            this.label4.TabIndex = 85;
            this.label4.Text = "Email";
            // 
            // phoneBox
            // 
            this.phoneBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.phoneBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.phoneBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.phoneBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneBox.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneBox.ForeColor = System.Drawing.Color.Gray;
            this.phoneBox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.phoneBox.HintText = "0660...";
            this.phoneBox.isPassword = false;
            this.phoneBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.phoneBox.LineIdleColor = System.Drawing.Color.Gray;
            this.phoneBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.phoneBox.LineThickness = 5;
            this.phoneBox.Location = new System.Drawing.Point(33, 254);
            this.phoneBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.phoneBox.MaxLength = 32767;
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(292, 38);
            this.phoneBox.TabIndex = 84;
            this.phoneBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.label3.Location = new System.Drawing.Point(29, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 28);
            this.label3.TabIndex = 83;
            this.label3.Text = "N° de téléphone";
            // 
            // NameBox
            // 
            this.NameBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.NameBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.NameBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.NameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameBox.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.ForeColor = System.Drawing.Color.Gray;
            this.NameBox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.NameBox.HintText = "abcd...";
            this.NameBox.isPassword = false;
            this.NameBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.NameBox.LineIdleColor = System.Drawing.Color.Gray;
            this.NameBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.NameBox.LineThickness = 5;
            this.NameBox.Location = new System.Drawing.Point(33, 44);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NameBox.MaxLength = 32767;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(292, 38);
            this.NameBox.TabIndex = 82;
            this.NameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.label2.Location = new System.Drawing.Point(29, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 28);
            this.label2.TabIndex = 80;
            this.label2.Text = "Adresse";
            // 
            // makePaymentBtn
            // 
            this.makePaymentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.makePaymentBtn.Image = ((System.Drawing.Image)(resources.GetObject("makePaymentBtn.Image")));
            this.makePaymentBtn.ImageActive = null;
            this.makePaymentBtn.Location = new System.Drawing.Point(1033, 558);
            this.makePaymentBtn.Name = "makePaymentBtn";
            this.makePaymentBtn.Size = new System.Drawing.Size(35, 35);
            this.makePaymentBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.makePaymentBtn.TabIndex = 144;
            this.makePaymentBtn.TabStop = false;
            this.makePaymentBtn.Zoom = 10;
            this.makePaymentBtn.Click += new System.EventHandler(this.makePaymentBtn_Click);
            // 
            // Annule
            // 
            this.Annule.AutoSize = true;
            this.Annule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Annule.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Annule.ForeColor = System.Drawing.Color.Gray;
            this.Annule.Location = new System.Drawing.Point(288, 5);
            this.Annule.Name = "Annule";
            this.Annule.Size = new System.Drawing.Size(63, 22);
            this.Annule.TabIndex = 79;
            this.Annule.Text = "ANNULER";
            this.Annule.Click += new System.EventHandler(this.Annule_Click);
            // 
            // AppliquerModifs
            // 
            this.AppliquerModifs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AppliquerModifs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppliquerModifs.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppliquerModifs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.AppliquerModifs.Image = ((System.Drawing.Image)(resources.GetObject("AppliquerModifs.Image")));
            this.AppliquerModifs.Location = new System.Drawing.Point(34, 396);
            this.AppliquerModifs.Name = "AppliquerModifs";
            this.AppliquerModifs.Size = new System.Drawing.Size(292, 41);
            this.AppliquerModifs.TabIndex = 39;
            this.AppliquerModifs.Text = "  EFFECTUER";
            this.AppliquerModifs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AppliquerModifs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AppliquerModifs.UseVisualStyleBackColor = true;
            this.AppliquerModifs.Click += new System.EventHandler(this.AppliquerModifs_Click);
            // 
            // ADDBtn
            // 
            this.ADDBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ADDBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ADDBtn.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(171)))), ((int)(((byte)(119)))));
            this.ADDBtn.Image = ((System.Drawing.Image)(resources.GetObject("ADDBtn.Image")));
            this.ADDBtn.Location = new System.Drawing.Point(34, 396);
            this.ADDBtn.Name = "ADDBtn";
            this.ADDBtn.Size = new System.Drawing.Size(292, 41);
            this.ADDBtn.TabIndex = 30;
            this.ADDBtn.Text = "  AJOUTER";
            this.ADDBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ADDBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ADDBtn.UseVisualStyleBackColor = true;
            this.ADDBtn.Click += new System.EventHandler(this.ADDBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nom de fournisseur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.label6.Location = new System.Drawing.Point(35, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 36);
            this.label6.TabIndex = 140;
            this.label6.Text = "Gestion Des Fournisseurs";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.wilayaBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.addressBox);
            this.panel1.Controls.Add(this.emailBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.phoneBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Annule);
            this.panel1.Controls.Add(this.AppliquerModifs);
            this.panel1.Controls.Add(this.ADDBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.panel1.Location = new System.Drawing.Point(35, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 453);
            this.panel1.TabIndex = 139;
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.BorderColorFocused = System.Drawing.Color.Blue;
            this.searchTxtBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(102)))), ((int)(((byte)(183)))));
            this.searchTxtBox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.searchTxtBox.BorderThickness = 2;
            this.searchTxtBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchTxtBox.isPassword = false;
            this.searchTxtBox.Location = new System.Drawing.Point(795, 100);
            this.searchTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTxtBox.MaxLength = 32767;
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(276, 38);
            this.searchTxtBox.TabIndex = 142;
            this.searchTxtBox.Text = "abcd....";
            this.searchTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchTxtBox.OnValueChanged += new System.EventHandler(this.searchTxtBox_OnValueChanged);
            this.searchTxtBox.Enter += new System.EventHandler(this.searchTxtBox_Enter);
            this.searchTxtBox.Leave += new System.EventHandler(this.searchTxtBox_Leave);
            // 
            // suppliersGridView
            // 
            this.suppliersGridView.AllowUserToAddRows = false;
            this.suppliersGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliersGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.suppliersGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.suppliersGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.suppliersGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(102)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Poppins", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.suppliersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.suppliersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4,
            this.Column6});
            this.suppliersGridView.DoubleBuffered = true;
            this.suppliersGridView.EnableHeadersVisualStyles = false;
            this.suppliersGridView.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(102)))), ((int)(((byte)(183)))));
            this.suppliersGridView.HeaderForeColor = System.Drawing.Color.White;
            this.suppliersGridView.Location = new System.Drawing.Point(418, 145);
            this.suppliersGridView.Name = "suppliersGridView";
            this.suppliersGridView.ReadOnly = true;
            this.suppliersGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.suppliersGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliersGridView.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.suppliersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.suppliersGridView.Size = new System.Drawing.Size(653, 406);
            this.suppliersGridView.TabIndex = 141;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "N°";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 96;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Nom";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Adresse";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column5.HeaderText = "N° tél";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 69;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column4.HeaderText = "Email";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 71;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column6.HeaderText = "Dette";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 69;
            // 
            // EditBtn
            // 
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(114)))), ((int)(((byte)(5)))));
            this.EditBtn.Image = ((System.Drawing.Image)(resources.GetObject("EditBtn.Image")));
            this.EditBtn.Location = new System.Drawing.Point(648, 557);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(224, 41);
            this.EditBtn.TabIndex = 138;
            this.EditBtn.Text = "  MODIFIER";
            this.EditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // panelOfPayement
            // 
            this.panelOfPayement.Controls.Add(this.closeAll);
            this.panelOfPayement.Controls.Add(this.label8);
            this.panelOfPayement.Controls.Add(this.panel3);
            this.panelOfPayement.Controls.Add(this.pictureBox4);
            this.panelOfPayement.Location = new System.Drawing.Point(29, 61);
            this.panelOfPayement.Name = "panelOfPayement";
            this.panelOfPayement.Size = new System.Drawing.Size(1052, 567);
            this.panelOfPayement.TabIndex = 145;
            // 
            // closeAll
            // 
            this.closeAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeAll.Image = ((System.Drawing.Image)(resources.GetObject("closeAll.Image")));
            this.closeAll.ImageActive = null;
            this.closeAll.Location = new System.Drawing.Point(890, 53);
            this.closeAll.Name = "closeAll";
            this.closeAll.Size = new System.Drawing.Size(35, 35);
            this.closeAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeAll.TabIndex = 136;
            this.closeAll.TabStop = false;
            this.closeAll.Zoom = 10;
            this.closeAll.Click += new System.EventHandler(this.closeAll_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.label8.Location = new System.Drawing.Point(563, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 36);
            this.label8.TabIndex = 135;
            this.label8.Text = "VERSSEMENTS";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pyAmountBox);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.pyClientName);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.pyClientId);
            this.panel3.Controls.Add(this.doPaymentBtn);
            this.panel3.Controls.Add(this.label14);
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.panel3.Location = new System.Drawing.Point(569, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 336);
            this.panel3.TabIndex = 134;
            // 
            // pyAmountBox
            // 
            this.pyAmountBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.pyAmountBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.pyAmountBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.pyAmountBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pyAmountBox.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pyAmountBox.ForeColor = System.Drawing.Color.Gray;
            this.pyAmountBox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.pyAmountBox.HintText = "123...";
            this.pyAmountBox.isPassword = false;
            this.pyAmountBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.pyAmountBox.LineIdleColor = System.Drawing.Color.Gray;
            this.pyAmountBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.pyAmountBox.LineThickness = 5;
            this.pyAmountBox.Location = new System.Drawing.Point(31, 201);
            this.pyAmountBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pyAmountBox.MaxLength = 32767;
            this.pyAmountBox.Name = "pyAmountBox";
            this.pyAmountBox.Size = new System.Drawing.Size(292, 38);
            this.pyAmountBox.TabIndex = 86;
            this.pyAmountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.label10.Location = new System.Drawing.Point(28, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 28);
            this.label10.TabIndex = 85;
            this.label10.Text = "Montant";
            // 
            // pyClientName
            // 
            this.pyClientName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.pyClientName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.pyClientName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.pyClientName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pyClientName.Enabled = false;
            this.pyClientName.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pyClientName.ForeColor = System.Drawing.Color.Gray;
            this.pyClientName.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.pyClientName.HintText = "abcd...";
            this.pyClientName.isPassword = false;
            this.pyClientName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.pyClientName.LineIdleColor = System.Drawing.Color.Gray;
            this.pyClientName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.pyClientName.LineThickness = 5;
            this.pyClientName.Location = new System.Drawing.Point(31, 122);
            this.pyClientName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pyClientName.MaxLength = 32767;
            this.pyClientName.Name = "pyClientName";
            this.pyClientName.Size = new System.Drawing.Size(292, 38);
            this.pyClientName.TabIndex = 84;
            this.pyClientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.label9.Location = new System.Drawing.Point(28, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 28);
            this.label9.TabIndex = 83;
            this.label9.Text = "Nom De Fournisseur";
            // 
            // pyClientId
            // 
            this.pyClientId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.pyClientId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.pyClientId.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.pyClientId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pyClientId.Enabled = false;
            this.pyClientId.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pyClientId.ForeColor = System.Drawing.Color.Gray;
            this.pyClientId.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.pyClientId.HintText = "abcd...";
            this.pyClientId.isPassword = false;
            this.pyClientId.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.pyClientId.LineIdleColor = System.Drawing.Color.Gray;
            this.pyClientId.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.pyClientId.LineThickness = 5;
            this.pyClientId.Location = new System.Drawing.Point(33, 44);
            this.pyClientId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pyClientId.MaxLength = 32767;
            this.pyClientId.Name = "pyClientId";
            this.pyClientId.Size = new System.Drawing.Size(292, 38);
            this.pyClientId.TabIndex = 82;
            this.pyClientId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // doPaymentBtn
            // 
            this.doPaymentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doPaymentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doPaymentBtn.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doPaymentBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(93)))));
            this.doPaymentBtn.Image = ((System.Drawing.Image)(resources.GetObject("doPaymentBtn.Image")));
            this.doPaymentBtn.Location = new System.Drawing.Point(33, 279);
            this.doPaymentBtn.Name = "doPaymentBtn";
            this.doPaymentBtn.Size = new System.Drawing.Size(292, 41);
            this.doPaymentBtn.TabIndex = 30;
            this.doPaymentBtn.Text = "  EFFECTUER";
            this.doPaymentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.doPaymentBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.doPaymentBtn.UseVisualStyleBackColor = true;
            this.doPaymentBtn.Click += new System.EventHandler(this.doPaymentBtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.label14.Location = new System.Drawing.Point(30, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 28);
            this.label14.TabIndex = 24;
            this.label14.Text = "N° Fournisseur";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(108, 93);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(414, 328);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 133;
            this.pictureBox4.TabStop = false;
            // 
            // Suppliers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelOfPayement);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.SuppBtn);
            this.Controls.Add(this.makePaymentBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.suppliersGridView);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.label5);
            this.Name = "Suppliers";
            this.Size = new System.Drawing.Size(1111, 679);
            this.Load += new System.EventHandler(this.Suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makePaymentBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersGridView)).EndInit();
            this.panelOfPayement.ResumeLayout(false);
            this.panelOfPayement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeAll)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox searchBtn;
        private System.Windows.Forms.Button SuppBtn;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox wilayaBox;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox addressBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox emailBox;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox phoneBox;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NameBox;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton makePaymentBtn;
        private System.Windows.Forms.Label Annule;
        private System.Windows.Forms.Button AppliquerModifs;
        private System.Windows.Forms.Button ADDBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox searchTxtBox;
        private Bunifu.Framework.UI.BunifuCustomDataGrid suppliersGridView;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel panelOfPayement;
        private Bunifu.Framework.UI.BunifuImageButton closeAll;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pyAmountBox;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pyClientName;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pyClientId;
        private System.Windows.Forms.Button doPaymentBtn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
