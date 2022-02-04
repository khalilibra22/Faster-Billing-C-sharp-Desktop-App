namespace Facturation.Controls.Auth
{
    partial class Signin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nomUtilisateurBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.passwordBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lollipopToggle1 = new LollipopToggle();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.label1.Location = new System.Drawing.Point(125, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Se connecter d\'abord";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.label2.Location = new System.Drawing.Point(21, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom d\'utilisteur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.label3.Location = new System.Drawing.Point(20, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mot de passe";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(25, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(462, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "  Connexion";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(198, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // nomUtilisateurBox
            // 
            this.nomUtilisateurBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.nomUtilisateurBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.nomUtilisateurBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nomUtilisateurBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nomUtilisateurBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nomUtilisateurBox.ForeColor = System.Drawing.Color.DimGray;
            this.nomUtilisateurBox.HintForeColor = System.Drawing.Color.Gray;
            this.nomUtilisateurBox.HintText = "Votre nom d\'utilisateur";
            this.nomUtilisateurBox.isPassword = false;
            this.nomUtilisateurBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(131)))), ((int)(((byte)(196)))));
            this.nomUtilisateurBox.LineIdleColor = System.Drawing.Color.Gray;
            this.nomUtilisateurBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(131)))), ((int)(((byte)(196)))));
            this.nomUtilisateurBox.LineThickness = 5;
            this.nomUtilisateurBox.Location = new System.Drawing.Point(25, 186);
            this.nomUtilisateurBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomUtilisateurBox.MaxLength = 32767;
            this.nomUtilisateurBox.Name = "nomUtilisateurBox";
            this.nomUtilisateurBox.Size = new System.Drawing.Size(462, 33);
            this.nomUtilisateurBox.TabIndex = 7;
            this.nomUtilisateurBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // passwordBox
            // 
            this.passwordBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.passwordBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.passwordBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passwordBox.ForeColor = System.Drawing.Color.DimGray;
            this.passwordBox.HintForeColor = System.Drawing.Color.Gray;
            this.passwordBox.HintText = "Votre mot de passe";
            this.passwordBox.isPassword = true;
            this.passwordBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(131)))), ((int)(((byte)(196)))));
            this.passwordBox.LineIdleColor = System.Drawing.Color.Gray;
            this.passwordBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(131)))), ((int)(((byte)(196)))));
            this.passwordBox.LineThickness = 5;
            this.passwordBox.Location = new System.Drawing.Point(26, 255);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordBox.MaxLength = 32767;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(462, 33);
            this.passwordBox.TabIndex = 8;
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(308, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 22);
            this.label4.TabIndex = 82;
            this.label4.Text = "Mot de passe lisible";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(22, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 22);
            this.label5.TabIndex = 81;
            this.label5.Text = "Informations oubliées";
            // 
            // lollipopToggle1
            // 
            this.lollipopToggle1.AutoSize = true;
            this.lollipopToggle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lollipopToggle1.EllipseBorderColor = "#0046A7";
            this.lollipopToggle1.EllipseColor = "#A4A4A1";
            this.lollipopToggle1.ForeColor = System.Drawing.Color.Red;
            this.lollipopToggle1.Location = new System.Drawing.Point(440, 299);
            this.lollipopToggle1.Name = "lollipopToggle1";
            this.lollipopToggle1.Size = new System.Drawing.Size(47, 19);
            this.lollipopToggle1.TabIndex = 80;
            this.lollipopToggle1.Text = "lollipopToggle1";
            this.lollipopToggle1.UseVisualStyleBackColor = false;
            this.lollipopToggle1.CheckedChanged += new System.EventHandler(this.lollipopToggle1_CheckedChanged);
            // 
            // Signin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lollipopToggle1);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.nomUtilisateurBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Signin";
            this.Size = new System.Drawing.Size(518, 409);
            this.Load += new System.EventHandler(this.Signin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nomUtilisateurBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passwordBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private LollipopToggle lollipopToggle1;
    }
}
