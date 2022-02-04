namespace Facturation.Controls.InvoicesControl
{
    partial class DeliveryDocument
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryDocument));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.printDeliveryBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.PictureBox();
            this.invoiceSearchTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.invoiceDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.invoiceNumBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label12 = new System.Windows.Forms.Label();
            this.searchInvoiceBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.alldeleveriesGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeAll = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alldeleveriesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeAll)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-22, 14);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(510, 225);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 132;
            this.pictureBox4.TabStop = false;
            // 
            // printDeliveryBtn
            // 
            this.printDeliveryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printDeliveryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printDeliveryBtn.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printDeliveryBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(114)))), ((int)(((byte)(5)))));
            this.printDeliveryBtn.Image = ((System.Drawing.Image)(resources.GetObject("printDeliveryBtn.Image")));
            this.printDeliveryBtn.Location = new System.Drawing.Point(404, 533);
            this.printDeliveryBtn.Name = "printDeliveryBtn";
            this.printDeliveryBtn.Size = new System.Drawing.Size(224, 41);
            this.printDeliveryBtn.TabIndex = 130;
            this.printDeliveryBtn.Text = "  APERÇU";
            this.printDeliveryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.printDeliveryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.printDeliveryBtn.UseVisualStyleBackColor = true;
            this.printDeliveryBtn.Click += new System.EventHandler(this.printDeliveryBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.label3.Location = new System.Drawing.Point(9, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 36);
            this.label3.TabIndex = 129;
            this.label3.Text = "Bons De Livraison";
            // 
            // searchBtn
            // 
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.Location = new System.Drawing.Point(990, 47);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(25, 25);
            this.searchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchBtn.TabIndex = 128;
            this.searchBtn.TabStop = false;
            // 
            // invoiceSearchTxtBox
            // 
            this.invoiceSearchTxtBox.BorderColorFocused = System.Drawing.Color.Blue;
            this.invoiceSearchTxtBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(102)))), ((int)(((byte)(183)))));
            this.invoiceSearchTxtBox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.invoiceSearchTxtBox.BorderThickness = 2;
            this.invoiceSearchTxtBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.invoiceSearchTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.invoiceSearchTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.invoiceSearchTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.invoiceSearchTxtBox.isPassword = false;
            this.invoiceSearchTxtBox.Location = new System.Drawing.Point(746, 40);
            this.invoiceSearchTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.invoiceSearchTxtBox.MaxLength = 32767;
            this.invoiceSearchTxtBox.Name = "invoiceSearchTxtBox";
            this.invoiceSearchTxtBox.Size = new System.Drawing.Size(276, 38);
            this.invoiceSearchTxtBox.TabIndex = 127;
            this.invoiceSearchTxtBox.Text = "abcd....";
            this.invoiceSearchTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.invoiceSearchTxtBox.OnValueChanged += new System.EventHandler(this.invoiceSearchTxtBox_OnValueChanged);
            this.invoiceSearchTxtBox.Enter += new System.EventHandler(this.invoiceSearchTxtBox_Enter);
            this.invoiceSearchTxtBox.Leave += new System.EventHandler(this.invoiceSearchTxtBox_Leave);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.invoiceDate);
            this.panel3.Controls.Add(this.invoiceNumBox);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.searchInvoiceBtn);
            this.panel3.Controls.Add(this.label14);
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.panel3.Location = new System.Drawing.Point(15, 255);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 272);
            this.panel3.TabIndex = 126;
            // 
            // invoiceDate
            // 
            this.invoiceDate.BorderRadius = 1;
            this.invoiceDate.CalendarFont = new System.Drawing.Font("Poppins Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceDate.Color = System.Drawing.Color.Gray;
            this.invoiceDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.invoiceDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.invoiceDate.DisabledColor = System.Drawing.Color.Gray;
            this.invoiceDate.DisplayWeekNumbers = false;
            this.invoiceDate.DPHeight = 0;
            this.invoiceDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.invoiceDate.FillDatePicker = false;
            this.invoiceDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceDate.ForeColor = System.Drawing.Color.DimGray;
            this.invoiceDate.Icon = ((System.Drawing.Image)(resources.GetObject("invoiceDate.Icon")));
            this.invoiceDate.IconColor = System.Drawing.Color.DimGray;
            this.invoiceDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.invoiceDate.Location = new System.Drawing.Point(35, 127);
            this.invoiceDate.MinimumSize = new System.Drawing.Size(290, 32);
            this.invoiceDate.Name = "invoiceDate";
            this.invoiceDate.Size = new System.Drawing.Size(290, 32);
            this.invoiceDate.TabIndex = 84;
            // 
            // invoiceNumBox
            // 
            this.invoiceNumBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.invoiceNumBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.invoiceNumBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.invoiceNumBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.invoiceNumBox.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceNumBox.ForeColor = System.Drawing.Color.Gray;
            this.invoiceNumBox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.invoiceNumBox.HintText = "abcd...";
            this.invoiceNumBox.isPassword = false;
            this.invoiceNumBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.invoiceNumBox.LineIdleColor = System.Drawing.Color.Gray;
            this.invoiceNumBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.invoiceNumBox.LineThickness = 5;
            this.invoiceNumBox.Location = new System.Drawing.Point(33, 44);
            this.invoiceNumBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.invoiceNumBox.MaxLength = 32767;
            this.invoiceNumBox.Name = "invoiceNumBox";
            this.invoiceNumBox.Size = new System.Drawing.Size(292, 38);
            this.invoiceNumBox.TabIndex = 82;
            this.invoiceNumBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.label12.Location = new System.Drawing.Point(29, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 28);
            this.label12.TabIndex = 80;
            this.label12.Text = "Date de création";
            // 
            // searchInvoiceBtn
            // 
            this.searchInvoiceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchInvoiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchInvoiceBtn.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInvoiceBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.searchInvoiceBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchInvoiceBtn.Image")));
            this.searchInvoiceBtn.Location = new System.Drawing.Point(35, 195);
            this.searchInvoiceBtn.Name = "searchInvoiceBtn";
            this.searchInvoiceBtn.Size = new System.Drawing.Size(292, 41);
            this.searchInvoiceBtn.TabIndex = 30;
            this.searchInvoiceBtn.Text = "  RECHERCHER";
            this.searchInvoiceBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchInvoiceBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchInvoiceBtn.UseVisualStyleBackColor = true;
            this.searchInvoiceBtn.Click += new System.EventHandler(this.searchInvoiceBtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.label14.Location = new System.Drawing.Point(30, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(200, 28);
            this.label14.TabIndex = 24;
            this.label14.Text = "N° de facture Proforma";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(102)))), ((int)(((byte)(183)))));
            this.label18.Location = new System.Drawing.Point(517, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(233, 26);
            this.label18.TabIndex = 125;
            this.label18.Text = "Rechercher par nom de client";
            // 
            // alldeleveriesGridView
            // 
            this.alldeleveriesGridView.AllowUserToAddRows = false;
            this.alldeleveriesGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alldeleveriesGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.alldeleveriesGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.alldeleveriesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alldeleveriesGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(102)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.alldeleveriesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.alldeleveriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alldeleveriesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.Column1,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.alldeleveriesGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alldeleveriesGridView.DoubleBuffered = true;
            this.alldeleveriesGridView.EnableHeadersVisualStyles = false;
            this.alldeleveriesGridView.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(102)))), ((int)(((byte)(183)))));
            this.alldeleveriesGridView.HeaderForeColor = System.Drawing.Color.White;
            this.alldeleveriesGridView.Location = new System.Drawing.Point(404, 86);
            this.alldeleveriesGridView.Name = "alldeleveriesGridView";
            this.alldeleveriesGridView.ReadOnly = true;
            this.alldeleveriesGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.alldeleveriesGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alldeleveriesGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.alldeleveriesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.alldeleveriesGridView.Size = new System.Drawing.Size(618, 441);
            this.alldeleveriesGridView.TabIndex = 124;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "N°Proforma";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "N° Bon Livr";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.HeaderText = "Nom De Client";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.HeaderText = "Date De Création";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // closeAll
            // 
            this.closeAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeAll.Image = ((System.Drawing.Image)(resources.GetObject("closeAll.Image")));
            this.closeAll.ImageActive = null;
            this.closeAll.Location = new System.Drawing.Point(334, 217);
            this.closeAll.Name = "closeAll";
            this.closeAll.Size = new System.Drawing.Size(35, 35);
            this.closeAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeAll.TabIndex = 133;
            this.closeAll.TabStop = false;
            this.closeAll.Zoom = 10;
            this.closeAll.Click += new System.EventHandler(this.closeAll_Click);
            // 
            // DeliveryDocument
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.closeAll);
            this.Controls.Add(this.printDeliveryBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.invoiceSearchTxtBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.alldeleveriesGridView);
            this.Controls.Add(this.pictureBox4);
            this.Name = "DeliveryDocument";
            this.Size = new System.Drawing.Size(1037, 604);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alldeleveriesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button printDeliveryBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox searchBtn;
        private Bunifu.Framework.UI.BunifuMetroTextbox invoiceSearchTxtBox;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuDatePicker invoiceDate;
        private Bunifu.Framework.UI.BunifuMaterialTextbox invoiceNumBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button searchInvoiceBtn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private Bunifu.Framework.UI.BunifuCustomDataGrid alldeleveriesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private Bunifu.Framework.UI.BunifuImageButton closeAll;
    }
}
