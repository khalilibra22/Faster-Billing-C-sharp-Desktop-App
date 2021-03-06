namespace Facturation
{
    partial class RecuPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuPrint));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ownerInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OwnerInfoDataSet = new Facturation.OwnerInfoDataSet();
            this.minimazeWindowBtn = new System.Windows.Forms.PictureBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closePrintFrom = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ownerInfoTableAdapter = new Facturation.OwnerInfoDataSetTableAdapters.ownerInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ownerInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OwnerInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimazeWindowBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePrintFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // ownerInfoBindingSource
            // 
            this.ownerInfoBindingSource.DataMember = "ownerInfo";
            this.ownerInfoBindingSource.DataSource = this.OwnerInfoDataSet;
            // 
            // OwnerInfoDataSet
            // 
            this.OwnerInfoDataSet.DataSetName = "OwnerInfoDataSet";
            this.OwnerInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // minimazeWindowBtn
            // 
            this.minimazeWindowBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimazeWindowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.minimazeWindowBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimazeWindowBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimazeWindowBtn.Image")));
            this.minimazeWindowBtn.Location = new System.Drawing.Point(1275, 21);
            this.minimazeWindowBtn.Name = "minimazeWindowBtn";
            this.minimazeWindowBtn.Size = new System.Drawing.Size(32, 32);
            this.minimazeWindowBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimazeWindowBtn.TabIndex = 92;
            this.minimazeWindowBtn.TabStop = false;
            this.minimazeWindowBtn.Click += new System.EventHandler(this.minimazeWindowBtn_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ownerInfoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Facturation.Recu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(25, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1320, 650);
            this.reportViewer1.TabIndex = 91;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // closePrintFrom
            // 
            this.closePrintFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closePrintFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.closePrintFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePrintFrom.Image = ((System.Drawing.Image)(resources.GetObject("closePrintFrom.Image")));
            this.closePrintFrom.Location = new System.Drawing.Point(1313, 21);
            this.closePrintFrom.Name = "closePrintFrom";
            this.closePrintFrom.Size = new System.Drawing.Size(32, 32);
            this.closePrintFrom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closePrintFrom.TabIndex = 89;
            this.closePrintFrom.TabStop = false;
            this.closePrintFrom.Click += new System.EventHandler(this.closePrintFrom_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.label6.Location = new System.Drawing.Point(62, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 36);
            this.label6.TabIndex = 88;
            this.label6.Text = "IMPRISSION";
            // 
            // ownerInfoTableAdapter
            // 
            this.ownerInfoTableAdapter.ClearBeforeFill = true;
            // 
            // RecuPrint
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1370, 730);
            this.Controls.Add(this.minimazeWindowBtn);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.closePrintFrom);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecuPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reçu";
            this.Load += new System.EventHandler(this.RecuPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ownerInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OwnerInfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimazeWindowBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePrintFrom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox minimazeWindowBtn;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox closePrintFrom;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.BindingSource ownerInfoBindingSource;
        public OwnerInfoDataSet OwnerInfoDataSet;
        public OwnerInfoDataSetTableAdapters.ownerInfoTableAdapter ownerInfoTableAdapter;
    }
}