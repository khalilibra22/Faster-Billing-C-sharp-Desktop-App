namespace Facturation
{
    partial class MsBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsBox));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Fermer = new System.Windows.Forms.PictureBox();
            this.MsgTxt = new System.Windows.Forms.Label();
            this.Titre = new System.Windows.Forms.Label();
            this.AlertImage = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Fermer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlertImage)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Fermer
            // 
            this.Fermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Fermer.BackColor = System.Drawing.Color.Transparent;
            this.Fermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fermer.Image = ((System.Drawing.Image)(resources.GetObject("Fermer.Image")));
            this.Fermer.Location = new System.Drawing.Point(457, 31);
            this.Fermer.Name = "Fermer";
            this.Fermer.Size = new System.Drawing.Size(32, 32);
            this.Fermer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Fermer.TabIndex = 86;
            this.Fermer.TabStop = false;
            this.Fermer.Click += new System.EventHandler(this.Fermer_Click);
            // 
            // MsgTxt
            // 
            this.MsgTxt.AutoSize = true;
            this.MsgTxt.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.MsgTxt.Location = new System.Drawing.Point(94, 54);
            this.MsgTxt.Name = "MsgTxt";
            this.MsgTxt.Size = new System.Drawing.Size(183, 26);
            this.MsgTxt.TabIndex = 85;
            this.MsgTxt.Text = "Contenue du message";
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.Font = new System.Drawing.Font("Poppins SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.Titre.Location = new System.Drawing.Point(93, 18);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(98, 36);
            this.Titre.TabIndex = 84;
            this.Titre.Text = "Success";
            // 
            // AlertImage
            // 
            this.AlertImage.Image = ((System.Drawing.Image)(resources.GetObject("AlertImage.Image")));
            this.AlertImage.Location = new System.Drawing.Point(12, 13);
            this.AlertImage.Name = "AlertImage";
            this.AlertImage.Size = new System.Drawing.Size(60, 60);
            this.AlertImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AlertImage.TabIndex = 83;
            this.AlertImage.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // MsBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(501, 93);
            this.Controls.Add(this.Fermer);
            this.Controls.Add(this.MsgTxt);
            this.Controls.Add(this.Titre);
            this.Controls.Add(this.AlertImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MsBox";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            this.Load += new System.EventHandler(this.MsBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Fermer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlertImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Fermer;
        private System.Windows.Forms.Label MsgTxt;
        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.PictureBox AlertImage;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}