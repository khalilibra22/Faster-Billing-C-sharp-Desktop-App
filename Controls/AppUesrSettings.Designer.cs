namespace Facturation.Controls
{
    partial class AppUesrSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppUesrSettings));
            this.PageTitle = new System.Windows.Forms.Label();
            this.CreationPanel = new System.Windows.Forms.Panel();
            this.lisible2 = new LollipopCheckBox();
            this.newPW = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.newUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.AdminRadio = new LollipopRadioButton();
            this.SuperVRadio = new LollipopRadioButton();
            this.NewCompteBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MyInfoPanel = new System.Windows.Forms.Panel();
            this.userPW = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.userNUBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Lisible1 = new LollipopCheckBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CompanyAddressBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.CompanyActivityBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.comapnyNameBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.companyBankInfo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.companyFiscalId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.companyNRC = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label14 = new System.Windows.Forms.Label();
            this.companyEmailBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label13 = new System.Windows.Forms.Label();
            this.CompanyPhoneBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label12 = new System.Windows.Forms.Label();
            this.companyWilayaBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.saveCompanyInfo = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.generalReportBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.label17 = new System.Windows.Forms.Label();
            this.nisNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label18 = new System.Windows.Forms.Label();
            this.articleNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CreationPanel.SuspendLayout();
            this.MyInfoPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalReportBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // PageTitle
            // 
            this.PageTitle.AutoSize = true;
            this.PageTitle.Font = new System.Drawing.Font("Poppins SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.PageTitle.Location = new System.Drawing.Point(50, 17);
            this.PageTitle.Name = "PageTitle";
            this.PageTitle.Size = new System.Drawing.Size(135, 36);
            this.PageTitle.TabIndex = 51;
            this.PageTitle.Text = "Paramètres";
            // 
            // CreationPanel
            // 
            this.CreationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CreationPanel.Controls.Add(this.lisible2);
            this.CreationPanel.Controls.Add(this.newPW);
            this.CreationPanel.Controls.Add(this.newUsername);
            this.CreationPanel.Controls.Add(this.AdminRadio);
            this.CreationPanel.Controls.Add(this.SuperVRadio);
            this.CreationPanel.Controls.Add(this.NewCompteBtn);
            this.CreationPanel.Controls.Add(this.label4);
            this.CreationPanel.Controls.Add(this.label5);
            this.CreationPanel.Controls.Add(this.label7);
            this.CreationPanel.Location = new System.Drawing.Point(56, 337);
            this.CreationPanel.Name = "CreationPanel";
            this.CreationPanel.Size = new System.Drawing.Size(472, 304);
            this.CreationPanel.TabIndex = 50;
            // 
            // lisible2
            // 
            this.lisible2.AutoSize = true;
            this.lisible2.CheckColor = "#27429D";
            this.lisible2.Location = new System.Drawing.Point(374, 168);
            this.lisible2.Name = "lisible2";
            this.lisible2.Size = new System.Drawing.Size(64, 20);
            this.lisible2.TabIndex = 88;
            this.lisible2.Text = "Lisible";
            this.lisible2.UseVisualStyleBackColor = true;
            this.lisible2.CheckedChanged += new System.EventHandler(this.lisible2_CheckedChanged);
            // 
            // newPW
            // 
            this.newPW.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.newPW.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.newPW.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.newPW.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newPW.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPW.ForeColor = System.Drawing.Color.Gray;
            this.newPW.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.newPW.HintText = "abcd...";
            this.newPW.isPassword = true;
            this.newPW.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.newPW.LineIdleColor = System.Drawing.Color.Gray;
            this.newPW.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.newPW.LineThickness = 5;
            this.newPW.Location = new System.Drawing.Point(49, 150);
            this.newPW.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.newPW.MaxLength = 32767;
            this.newPW.Name = "newPW";
            this.newPW.Size = new System.Drawing.Size(312, 38);
            this.newPW.TabIndex = 87;
            this.newPW.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // newUsername
            // 
            this.newUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.newUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.newUsername.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.newUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newUsername.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUsername.ForeColor = System.Drawing.Color.Gray;
            this.newUsername.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.newUsername.HintText = "abcd...";
            this.newUsername.isPassword = false;
            this.newUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.newUsername.LineIdleColor = System.Drawing.Color.Gray;
            this.newUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.newUsername.LineThickness = 5;
            this.newUsername.Location = new System.Drawing.Point(52, 74);
            this.newUsername.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.newUsername.MaxLength = 32767;
            this.newUsername.Name = "newUsername";
            this.newUsername.Size = new System.Drawing.Size(386, 38);
            this.newUsername.TabIndex = 86;
            this.newUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AdminRadio
            // 
            this.AdminRadio.AutoSize = true;
            this.AdminRadio.CheckColor = "#27429D";
            this.AdminRadio.Location = new System.Drawing.Point(323, 207);
            this.AdminRadio.Name = "AdminRadio";
            this.AdminRadio.Size = new System.Drawing.Size(115, 19);
            this.AdminRadio.TabIndex = 48;
            this.AdminRadio.Text = "Administrateur";
            this.AdminRadio.UseVisualStyleBackColor = true;
            // 
            // SuperVRadio
            // 
            this.SuperVRadio.AutoSize = true;
            this.SuperVRadio.CheckColor = "#27429D";
            this.SuperVRadio.Checked = true;
            this.SuperVRadio.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuperVRadio.Location = new System.Drawing.Point(207, 207);
            this.SuperVRadio.Name = "SuperVRadio";
            this.SuperVRadio.Size = new System.Drawing.Size(97, 19);
            this.SuperVRadio.TabIndex = 47;
            this.SuperVRadio.TabStop = true;
            this.SuperVRadio.Text = "Superviseur";
            this.SuperVRadio.UseVisualStyleBackColor = true;
            // 
            // NewCompteBtn
            // 
            this.NewCompteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewCompteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewCompteBtn.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCompteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(114)))), ((int)(((byte)(5)))));
            this.NewCompteBtn.Image = ((System.Drawing.Image)(resources.GetObject("NewCompteBtn.Image")));
            this.NewCompteBtn.Location = new System.Drawing.Point(49, 246);
            this.NewCompteBtn.Name = "NewCompteBtn";
            this.NewCompteBtn.Size = new System.Drawing.Size(389, 41);
            this.NewCompteBtn.TabIndex = 46;
            this.NewCompteBtn.Text = "  NOUVEAU COMPTE";
            this.NewCompteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NewCompteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NewCompteBtn.UseVisualStyleBackColor = true;
            this.NewCompteBtn.Click += new System.EventHandler(this.NewCompteBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.label4.Location = new System.Drawing.Point(43, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 36);
            this.label4.TabIndex = 45;
            this.label4.Text = "Créer un compte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(102)))), ((int)(((byte)(183)))));
            this.label5.Location = new System.Drawing.Point(47, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 28);
            this.label5.TabIndex = 41;
            this.label5.Text = "Mot de passe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(102)))), ((int)(((byte)(183)))));
            this.label7.Location = new System.Drawing.Point(47, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 28);
            this.label7.TabIndex = 39;
            this.label7.Text = "Username";
            // 
            // MyInfoPanel
            // 
            this.MyInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MyInfoPanel.Controls.Add(this.userPW);
            this.MyInfoPanel.Controls.Add(this.userNUBox);
            this.MyInfoPanel.Controls.Add(this.Lisible1);
            this.MyInfoPanel.Controls.Add(this.SaveBtn);
            this.MyInfoPanel.Controls.Add(this.label6);
            this.MyInfoPanel.Controls.Add(this.label3);
            this.MyInfoPanel.Controls.Add(this.label2);
            this.MyInfoPanel.Location = new System.Drawing.Point(56, 56);
            this.MyInfoPanel.Name = "MyInfoPanel";
            this.MyInfoPanel.Size = new System.Drawing.Size(472, 267);
            this.MyInfoPanel.TabIndex = 49;
            // 
            // userPW
            // 
            this.userPW.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.userPW.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.userPW.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.userPW.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userPW.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPW.ForeColor = System.Drawing.Color.Gray;
            this.userPW.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.userPW.HintText = "abcd...";
            this.userPW.isPassword = true;
            this.userPW.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.userPW.LineIdleColor = System.Drawing.Color.Gray;
            this.userPW.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.userPW.LineThickness = 5;
            this.userPW.Location = new System.Drawing.Point(49, 146);
            this.userPW.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.userPW.MaxLength = 32767;
            this.userPW.Name = "userPW";
            this.userPW.Size = new System.Drawing.Size(312, 38);
            this.userPW.TabIndex = 85;
            this.userPW.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // userNUBox
            // 
            this.userNUBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.userNUBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.userNUBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.userNUBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNUBox.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNUBox.ForeColor = System.Drawing.Color.Gray;
            this.userNUBox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.userNUBox.HintText = "abcd...";
            this.userNUBox.isPassword = false;
            this.userNUBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.userNUBox.LineIdleColor = System.Drawing.Color.Gray;
            this.userNUBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.userNUBox.LineThickness = 5;
            this.userNUBox.Location = new System.Drawing.Point(49, 69);
            this.userNUBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.userNUBox.MaxLength = 32767;
            this.userNUBox.Name = "userNUBox";
            this.userNUBox.Size = new System.Drawing.Size(386, 38);
            this.userNUBox.TabIndex = 84;
            this.userNUBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Lisible1
            // 
            this.Lisible1.AutoSize = true;
            this.Lisible1.CheckColor = "#27429D";
            this.Lisible1.Location = new System.Drawing.Point(371, 164);
            this.Lisible1.Name = "Lisible1";
            this.Lisible1.Size = new System.Drawing.Size(64, 20);
            this.Lisible1.TabIndex = 50;
            this.Lisible1.Text = "Lisible";
            this.Lisible1.UseVisualStyleBackColor = true;
            this.Lisible1.CheckedChanged += new System.EventHandler(this.Lisible1_CheckedChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.SaveBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveBtn.Image")));
            this.SaveBtn.Location = new System.Drawing.Point(49, 207);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(386, 41);
            this.SaveBtn.TabIndex = 46;
            this.SaveBtn.Text = "  SAUVEGARDER";
            this.SaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.label6.Location = new System.Drawing.Point(43, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 36);
            this.label6.TabIndex = 45;
            this.label6.Text = "Informations De Compte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(102)))), ((int)(((byte)(183)))));
            this.label3.Location = new System.Drawing.Point(44, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 28);
            this.label3.TabIndex = 41;
            this.label3.Text = "Mot de passe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(102)))), ((int)(((byte)(183)))));
            this.label2.Location = new System.Drawing.Point(47, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 39;
            this.label2.Text = "Username";
            // 
            // CompanyAddressBox
            // 
            this.CompanyAddressBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CompanyAddressBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CompanyAddressBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CompanyAddressBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CompanyAddressBox.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyAddressBox.ForeColor = System.Drawing.Color.Gray;
            this.CompanyAddressBox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.CompanyAddressBox.HintText = "abcd...";
            this.CompanyAddressBox.isPassword = false;
            this.CompanyAddressBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.CompanyAddressBox.LineIdleColor = System.Drawing.Color.Gray;
            this.CompanyAddressBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.CompanyAddressBox.LineThickness = 5;
            this.CompanyAddressBox.Location = new System.Drawing.Point(16, 225);
            this.CompanyAddressBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CompanyAddressBox.MaxLength = 32767;
            this.CompanyAddressBox.Name = "CompanyAddressBox";
            this.CompanyAddressBox.Size = new System.Drawing.Size(266, 38);
            this.CompanyAddressBox.TabIndex = 95;
            this.CompanyAddressBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CompanyAddressBox.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox7_OnValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(102)))), ((int)(((byte)(183)))));
            this.label9.Location = new System.Drawing.Point(11, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 28);
            this.label9.TabIndex = 94;
            this.label9.Text = "Adresse";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // CompanyActivityBox
            // 
            this.CompanyActivityBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CompanyActivityBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CompanyActivityBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CompanyActivityBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CompanyActivityBox.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyActivityBox.ForeColor = System.Drawing.Color.Gray;
            this.CompanyActivityBox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.CompanyActivityBox.HintText = "abcd...";
            this.CompanyActivityBox.isPassword = false;
            this.CompanyActivityBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.CompanyActivityBox.LineIdleColor = System.Drawing.Color.Gray;
            this.CompanyActivityBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.CompanyActivityBox.LineThickness = 5;
            this.CompanyActivityBox.Location = new System.Drawing.Point(16, 146);
            this.CompanyActivityBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CompanyActivityBox.MaxLength = 32767;
            this.CompanyActivityBox.Name = "CompanyActivityBox";
            this.CompanyActivityBox.Size = new System.Drawing.Size(318, 38);
            this.CompanyActivityBox.TabIndex = 93;
            this.CompanyActivityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(102)))), ((int)(((byte)(183)))));
            this.label8.Location = new System.Drawing.Point(11, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 28);
            this.label8.TabIndex = 92;
            this.label8.Text = "Activité";
            // 
            // comapnyNameBox
            // 
            this.comapnyNameBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.comapnyNameBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.comapnyNameBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.comapnyNameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.comapnyNameBox.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comapnyNameBox.ForeColor = System.Drawing.Color.Gray;
            this.comapnyNameBox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.comapnyNameBox.HintText = "abcd...";
            this.comapnyNameBox.isPassword = false;
            this.comapnyNameBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.comapnyNameBox.LineIdleColor = System.Drawing.Color.Gray;
            this.comapnyNameBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.comapnyNameBox.LineThickness = 5;
            this.comapnyNameBox.Location = new System.Drawing.Point(16, 72);
            this.comapnyNameBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.comapnyNameBox.MaxLength = 32767;
            this.comapnyNameBox.Name = "comapnyNameBox";
            this.comapnyNameBox.Size = new System.Drawing.Size(470, 38);
            this.comapnyNameBox.TabIndex = 91;
            this.comapnyNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(102)))), ((int)(((byte)(183)))));
            this.label1.Location = new System.Drawing.Point(11, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 28);
            this.label1.TabIndex = 90;
            this.label1.Text = "Nom D\'entreprise";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.articleNumber);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.nisNumber);
            this.panel1.Controls.Add(this.companyBankInfo);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.companyFiscalId);
            this.panel1.Controls.Add(this.companyNRC);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.companyEmailBox);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.CompanyPhoneBox);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.companyWilayaBox);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.saveCompanyInfo);
            this.panel1.Controls.Add(this.CompanyAddressBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.comapnyNameBox);
            this.panel1.Controls.Add(this.CompanyActivityBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(545, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 585);
            this.panel1.TabIndex = 96;
            // 
            // companyBankInfo
            // 
            this.companyBankInfo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.companyBankInfo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.companyBankInfo.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.companyBankInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.companyBankInfo.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyBankInfo.ForeColor = System.Drawing.Color.Gray;
            this.companyBankInfo.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.companyBankInfo.HintText = "abcd...";
            this.companyBankInfo.isPassword = false;
            this.companyBankInfo.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.companyBankInfo.LineIdleColor = System.Drawing.Color.Gray;
            this.companyBankInfo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.companyBankInfo.LineThickness = 5;
            this.companyBankInfo.Location = new System.Drawing.Point(16, 375);
            this.companyBankInfo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.companyBankInfo.MaxLength = 32767;
            this.companyBankInfo.Name = "companyBankInfo";
            this.companyBankInfo.Size = new System.Drawing.Size(266, 38);
            this.companyBankInfo.TabIndex = 107;
            this.companyBankInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(102)))), ((int)(((byte)(183)))));
            this.label16.Location = new System.Drawing.Point(11, 354);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(195, 28);
            this.label16.TabIndex = 106;
            this.label16.Text = "Informations Bancaire";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(102)))), ((int)(((byte)(183)))));
            this.label15.Location = new System.Drawing.Point(289, 279);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 28);
            this.label15.TabIndex = 105;
            this.label15.Text = "ID Fiscal";
            // 
            // companyFiscalId
            // 
            this.companyFiscalId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.companyFiscalId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.companyFiscalId.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.companyFiscalId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.companyFiscalId.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyFiscalId.ForeColor = System.Drawing.Color.Gray;
            this.companyFiscalId.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.companyFiscalId.HintText = "abcd...";
            this.companyFiscalId.isPassword = false;
            this.companyFiscalId.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.companyFiscalId.LineIdleColor = System.Drawing.Color.Gray;
            this.companyFiscalId.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.companyFiscalId.LineThickness = 5;
            this.companyFiscalId.Location = new System.Drawing.Point(294, 300);
            this.companyFiscalId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.companyFiscalId.MaxLength = 32767;
            this.companyFiscalId.Name = "companyFiscalId";
            this.companyFiscalId.Size = new System.Drawing.Size(192, 38);
            this.companyFiscalId.TabIndex = 104;
            this.companyFiscalId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // companyNRC
            // 
            this.companyNRC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.companyNRC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.companyNRC.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.companyNRC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.companyNRC.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNRC.ForeColor = System.Drawing.Color.Gray;
            this.companyNRC.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.companyNRC.HintText = "abcd...";
            this.companyNRC.isPassword = false;
            this.companyNRC.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.companyNRC.LineIdleColor = System.Drawing.Color.Gray;
            this.companyNRC.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.companyNRC.LineThickness = 5;
            this.companyNRC.Location = new System.Drawing.Point(16, 300);
            this.companyNRC.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.companyNRC.MaxLength = 32767;
            this.companyNRC.Name = "companyNRC";
            this.companyNRC.Size = new System.Drawing.Size(266, 38);
            this.companyNRC.TabIndex = 103;
            this.companyNRC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(102)))), ((int)(((byte)(183)))));
            this.label14.Location = new System.Drawing.Point(289, 204);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(168, 28);
            this.label14.TabIndex = 102;
            this.label14.Text = "Wilaya / Commune";
            // 
            // companyEmailBox
            // 
            this.companyEmailBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.companyEmailBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.companyEmailBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.companyEmailBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.companyEmailBox.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyEmailBox.ForeColor = System.Drawing.Color.Gray;
            this.companyEmailBox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.companyEmailBox.HintText = "fact@gm....";
            this.companyEmailBox.isPassword = false;
            this.companyEmailBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.companyEmailBox.LineIdleColor = System.Drawing.Color.Gray;
            this.companyEmailBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.companyEmailBox.LineThickness = 5;
            this.companyEmailBox.Location = new System.Drawing.Point(16, 452);
            this.companyEmailBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.companyEmailBox.MaxLength = 32767;
            this.companyEmailBox.Name = "companyEmailBox";
            this.companyEmailBox.Size = new System.Drawing.Size(266, 38);
            this.companyEmailBox.TabIndex = 101;
            this.companyEmailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(102)))), ((int)(((byte)(183)))));
            this.label13.Location = new System.Drawing.Point(11, 431);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 28);
            this.label13.TabIndex = 100;
            this.label13.Text = "Email";
            // 
            // CompanyPhoneBox
            // 
            this.CompanyPhoneBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CompanyPhoneBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CompanyPhoneBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CompanyPhoneBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CompanyPhoneBox.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyPhoneBox.ForeColor = System.Drawing.Color.Gray;
            this.CompanyPhoneBox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.CompanyPhoneBox.HintText = "055033...";
            this.CompanyPhoneBox.isPassword = false;
            this.CompanyPhoneBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.CompanyPhoneBox.LineIdleColor = System.Drawing.Color.Gray;
            this.CompanyPhoneBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.CompanyPhoneBox.LineThickness = 5;
            this.CompanyPhoneBox.Location = new System.Drawing.Point(290, 452);
            this.CompanyPhoneBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CompanyPhoneBox.MaxLength = 32767;
            this.CompanyPhoneBox.Name = "CompanyPhoneBox";
            this.CompanyPhoneBox.Size = new System.Drawing.Size(196, 38);
            this.CompanyPhoneBox.TabIndex = 99;
            this.CompanyPhoneBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(102)))), ((int)(((byte)(183)))));
            this.label12.Location = new System.Drawing.Point(285, 431);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 28);
            this.label12.TabIndex = 98;
            this.label12.Text = "N° téléphone";
            // 
            // companyWilayaBox
            // 
            this.companyWilayaBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.companyWilayaBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.companyWilayaBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.companyWilayaBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.companyWilayaBox.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyWilayaBox.ForeColor = System.Drawing.Color.Gray;
            this.companyWilayaBox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.companyWilayaBox.HintText = "abcd...";
            this.companyWilayaBox.isPassword = false;
            this.companyWilayaBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.companyWilayaBox.LineIdleColor = System.Drawing.Color.Gray;
            this.companyWilayaBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.companyWilayaBox.LineThickness = 5;
            this.companyWilayaBox.Location = new System.Drawing.Point(290, 225);
            this.companyWilayaBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.companyWilayaBox.MaxLength = 32767;
            this.companyWilayaBox.Name = "companyWilayaBox";
            this.companyWilayaBox.Size = new System.Drawing.Size(196, 38);
            this.companyWilayaBox.TabIndex = 97;
            this.companyWilayaBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(102)))), ((int)(((byte)(183)))));
            this.label11.Location = new System.Drawing.Point(11, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 28);
            this.label11.TabIndex = 96;
            this.label11.Text = "N° RC";
            // 
            // saveCompanyInfo
            // 
            this.saveCompanyInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveCompanyInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveCompanyInfo.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveCompanyInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(168)))));
            this.saveCompanyInfo.Image = ((System.Drawing.Image)(resources.GetObject("saveCompanyInfo.Image")));
            this.saveCompanyInfo.Location = new System.Drawing.Point(16, 527);
            this.saveCompanyInfo.Name = "saveCompanyInfo";
            this.saveCompanyInfo.Size = new System.Drawing.Size(470, 41);
            this.saveCompanyInfo.TabIndex = 46;
            this.saveCompanyInfo.Text = "  SAUVEGARDER";
            this.saveCompanyInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveCompanyInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveCompanyInfo.UseVisualStyleBackColor = true;
            this.saveCompanyInfo.Click += new System.EventHandler(this.saveCompanyInfo_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.label10.Location = new System.Drawing.Point(10, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(272, 36);
            this.label10.TabIndex = 45;
            this.label10.Text = "Informations D\'entreprise";
            // 
            // generalReportBtn
            // 
            this.generalReportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generalReportBtn.Image = ((System.Drawing.Image)(resources.GetObject("generalReportBtn.Image")));
            this.generalReportBtn.ImageActive = null;
            this.generalReportBtn.Location = new System.Drawing.Point(1015, 18);
            this.generalReportBtn.Name = "generalReportBtn";
            this.generalReportBtn.Size = new System.Drawing.Size(35, 35);
            this.generalReportBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.generalReportBtn.TabIndex = 134;
            this.generalReportBtn.TabStop = false;
            this.generalReportBtn.Zoom = 10;
            this.generalReportBtn.Click += new System.EventHandler(this.generalReportBtn_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(102)))), ((int)(((byte)(183)))));
            this.label17.Location = new System.Drawing.Point(289, 354);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 28);
            this.label17.TabIndex = 109;
            this.label17.Text = "NIS";
            // 
            // nisNumber
            // 
            this.nisNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.nisNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.nisNumber.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nisNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nisNumber.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nisNumber.ForeColor = System.Drawing.Color.Gray;
            this.nisNumber.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.nisNumber.HintText = "abcd...";
            this.nisNumber.isPassword = false;
            this.nisNumber.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.nisNumber.LineIdleColor = System.Drawing.Color.Gray;
            this.nisNumber.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.nisNumber.LineThickness = 5;
            this.nisNumber.Location = new System.Drawing.Point(294, 375);
            this.nisNumber.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.nisNumber.MaxLength = 32767;
            this.nisNumber.Name = "nisNumber";
            this.nisNumber.Size = new System.Drawing.Size(192, 38);
            this.nisNumber.TabIndex = 108;
            this.nisNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(102)))), ((int)(((byte)(183)))));
            this.label18.Location = new System.Drawing.Point(337, 127);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 28);
            this.label18.TabIndex = 111;
            this.label18.Text = "N° Article";
            // 
            // articleNumber
            // 
            this.articleNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.articleNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.articleNumber.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.articleNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.articleNumber.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articleNumber.ForeColor = System.Drawing.Color.Gray;
            this.articleNumber.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.articleNumber.HintText = "abcd...";
            this.articleNumber.isPassword = false;
            this.articleNumber.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.articleNumber.LineIdleColor = System.Drawing.Color.Gray;
            this.articleNumber.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.articleNumber.LineThickness = 5;
            this.articleNumber.Location = new System.Drawing.Point(342, 146);
            this.articleNumber.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.articleNumber.MaxLength = 32767;
            this.articleNumber.Name = "articleNumber";
            this.articleNumber.Size = new System.Drawing.Size(144, 38);
            this.articleNumber.TabIndex = 110;
            this.articleNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AppUesrSettings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.generalReportBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PageTitle);
            this.Controls.Add(this.CreationPanel);
            this.Controls.Add(this.MyInfoPanel);
            this.Name = "AppUesrSettings";
            this.Size = new System.Drawing.Size(1111, 679);
            this.Load += new System.EventHandler(this.AppSettings_Load);
            this.CreationPanel.ResumeLayout(false);
            this.CreationPanel.PerformLayout();
            this.MyInfoPanel.ResumeLayout(false);
            this.MyInfoPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalReportBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PageTitle;
        private System.Windows.Forms.Panel CreationPanel;
        private LollipopRadioButton AdminRadio;
        private LollipopRadioButton SuperVRadio;
        private System.Windows.Forms.Button NewCompteBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel MyInfoPanel;
        private LollipopCheckBox Lisible1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private LollipopCheckBox lisible2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox newPW;
        private Bunifu.Framework.UI.BunifuMaterialTextbox newUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox userPW;
        private Bunifu.Framework.UI.BunifuMaterialTextbox userNUBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CompanyAddressBox;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CompanyActivityBox;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox comapnyNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button saveCompanyInfo;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox companyEmailBox;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CompanyPhoneBox;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuMaterialTextbox companyWilayaBox;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuMaterialTextbox companyBankInfo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuMaterialTextbox companyFiscalId;
        private Bunifu.Framework.UI.BunifuMaterialTextbox companyNRC;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuImageButton generalReportBtn;
        private System.Windows.Forms.Label label18;
        private Bunifu.Framework.UI.BunifuMaterialTextbox articleNumber;
        private System.Windows.Forms.Label label17;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nisNumber;
    }
}
