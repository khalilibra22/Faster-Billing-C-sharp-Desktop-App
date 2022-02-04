namespace Facturation
{
    partial class PrintGeneralReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintGeneralReport));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ownerInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OwnerInfoDataSet = new Facturation.OwnerInfoDataSet();
            this.DetteDtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DetteDataSet = new Facturation.DetteDataSet();
            this.CaisseDtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CaisseDataSet = new Facturation.CaisseDataSet();
            this.ClientDtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AllBuyingDataSet = new Facturation.AllBuyingDataSet();
            this.minimazeWindowBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closePrintFrom = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ownerInfoTableAdapter = new Facturation.OwnerInfoDataSetTableAdapters.ownerInfoTableAdapter();
            this.DetteDtTableAdapter = new Facturation.DetteDataSetTableAdapters.DetteDtTableAdapter();
            this.CaisseDtTableAdapter = new Facturation.CaisseDataSetTableAdapters.CaisseDtTableAdapter();
            this.ClientDtTableAdapter = new Facturation.AllBuyingDataSetTableAdapters.ClientDtTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ownerInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OwnerInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetteDtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaisseDtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaisseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllBuyingDataSet)).BeginInit();
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
            // DetteDtBindingSource
            // 
            this.DetteDtBindingSource.DataMember = "DetteDt";
            this.DetteDtBindingSource.DataSource = this.DetteDataSet;
            // 
            // DetteDataSet
            // 
            this.DetteDataSet.DataSetName = "DetteDataSet";
            this.DetteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CaisseDtBindingSource
            // 
            this.CaisseDtBindingSource.DataMember = "CaisseDt";
            this.CaisseDtBindingSource.DataSource = this.CaisseDataSet;
            // 
            // CaisseDataSet
            // 
            this.CaisseDataSet.DataSetName = "CaisseDataSet";
            this.CaisseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ClientDtBindingSource
            // 
            this.ClientDtBindingSource.DataMember = "ClientDt";
            this.ClientDtBindingSource.DataSource = this.AllBuyingDataSet;
            // 
            // AllBuyingDataSet
            // 
            this.AllBuyingDataSet.DataSetName = "AllBuyingDataSet";
            this.AllBuyingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.minimazeWindowBtn.TabIndex = 102;
            this.minimazeWindowBtn.TabStop = false;
            this.minimazeWindowBtn.Click += new System.EventHandler(this.minimazeWindowBtn_Click);
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
            this.pictureBox1.TabIndex = 100;
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
            this.closePrintFrom.TabIndex = 99;
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
            this.label6.TabIndex = 98;
            this.label6.Text = "IMPRISSION";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ownerInfoBindingSource;
            reportDataSource2.Name = "DetteDataSet";
            reportDataSource2.Value = this.DetteDtBindingSource;
            reportDataSource3.Name = "DataDette";
            reportDataSource3.Value = this.CaisseDtBindingSource;
            reportDataSource4.Name = "clientDataSet";
            reportDataSource4.Value = this.ClientDtBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Facturation.GeneralReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(25, 59);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1320, 650);
            this.reportViewer1.TabIndex = 103;
            // 
            // ownerInfoTableAdapter
            // 
            this.ownerInfoTableAdapter.ClearBeforeFill = true;
            // 
            // DetteDtTableAdapter
            // 
            this.DetteDtTableAdapter.ClearBeforeFill = true;
            // 
            // CaisseDtTableAdapter
            // 
            this.CaisseDtTableAdapter.ClearBeforeFill = true;
            // 
            // ClientDtTableAdapter
            // 
            this.ClientDtTableAdapter.ClearBeforeFill = true;
            // 
            // PrintGeneralReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1370, 730);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.minimazeWindowBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.closePrintFrom);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrintGeneralReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintGeneralReport";
            this.Load += new System.EventHandler(this.PrintGeneralReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ownerInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OwnerInfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetteDtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaisseDtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaisseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllBuyingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimazeWindowBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePrintFrom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox minimazeWindowBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox closePrintFrom;
        private System.Windows.Forms.Label label6;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public System.Windows.Forms.BindingSource ownerInfoBindingSource;
        public OwnerInfoDataSet OwnerInfoDataSet;
        public System.Windows.Forms.BindingSource DetteDtBindingSource;
        public DetteDataSet DetteDataSet;
        public System.Windows.Forms.BindingSource CaisseDtBindingSource;
        public CaisseDataSet CaisseDataSet;
        public OwnerInfoDataSetTableAdapters.ownerInfoTableAdapter ownerInfoTableAdapter;
        public DetteDataSetTableAdapters.DetteDtTableAdapter DetteDtTableAdapter;
        public CaisseDataSetTableAdapters.CaisseDtTableAdapter CaisseDtTableAdapter;
        public System.Windows.Forms.BindingSource ClientDtBindingSource;
        public AllBuyingDataSet AllBuyingDataSet;
        public AllBuyingDataSetTableAdapters.ClientDtTableAdapter ClientDtTableAdapter;
    }
}