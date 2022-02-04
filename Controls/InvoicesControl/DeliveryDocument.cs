using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturation.Service;
using Microsoft.Reporting.WinForms;
using System.IO;
using System.Drawing.Imaging;
using Facturation.Config;

namespace Facturation.Controls.InvoicesControl
{
    public partial class DeliveryDocument : UserControl
    {
        public DeliveryDocument()
        {
            InitializeComponent();
        }


        public async void loadAlldileveryDocuments()
        {
            InvoicesService service = new InvoicesService();
            DataTable result = await service.getAllDeliveryDocuments();
            if (result == null) return;
            alldeleveriesGridView.Rows.Clear();
            for (int i = 0; i < result.Rows.Count; i++)
            {
                int newRow = alldeleveriesGridView.Rows.Add();
                alldeleveriesGridView.Rows[newRow].Cells[0].Value = result.Rows[i][0];
                alldeleveriesGridView.Rows[newRow].Cells[1].Value = result.Rows[i][1];
                alldeleveriesGridView.Rows[newRow].Cells[2].Value = result.Rows[i][2];
                alldeleveriesGridView.Rows[newRow].Cells[3].Value = result.Rows[i][3];

            }
        }

        private void closeAll_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private async void printDeliveryBtn_Click(object sender, EventArgs e)
        {

            int totColis = 0;
            double totOfAllSelledPrice = 0.0;
            if (alldeleveriesGridView.Rows.Count == 0) return;
            int selectedRow = alldeleveriesGridView.CurrentCell.RowIndex;
            String selectedInvoiceNum = alldeleveriesGridView.Rows[selectedRow].Cells[1].Value.ToString();
            DeliveryPrint print = new DeliveryPrint();
            
            //generate QR code for invoice Number
            //begin


            print.QRcodeDataSet.invoiceQRcode.Rows.Clear();
            QRCoder.QRCodeGenerator qrCoderGernerator = new QRCoder.QRCodeGenerator();
            QRCoder.QRCodeData qrCoderData = qrCoderGernerator.CreateQrCode(selectedInvoiceNum, QRCoder.QRCodeGenerator.ECCLevel.Q);
            QRCoder.QRCode qrCode = new QRCoder.QRCode(qrCoderData);
            Bitmap bmp = qrCode.GetGraphic(7);
            using (MemoryStream ms = new MemoryStream())
            {
                bmp.Save(ms, ImageFormat.Bmp);
                DataRow item = print.QRcodeDataSet.invoiceQRcode.NewRow();
                item["image"] = ms.ToArray();
                print.QRcodeDataSet.invoiceQRcode.Rows.Add(item);

            }



            InvoicesService getInvoiceInformation = new InvoicesService();
            print.invoiceDataSet.invoiceDt.Rows.Clear();
            bool invoiceInformationResult = await getInvoiceInformation.getDeliveryInfo(selectedInvoiceNum, print.invoiceDataSet.invoiceDt);

            InvoicesService getAllInvoiceProducts = new InvoicesService();
            print.InvioceProductsDataSet.invoiceProdsDt.Rows.Clear();
            
            bool invoiceProductsResult = await getAllInvoiceProducts.getDeliveryProducts(selectedInvoiceNum, print.InvioceProductsDataSet.invoiceProdsDt);


            CompanyInfo getCompanyAllInfo = new CompanyInfo();
            print.OwnerInfoDataSet.ownerInfo.Rows.Clear();
            bool companyAllInfoResult = await getCompanyAllInfo.getOwnerInfor2Repport(print.OwnerInfoDataSet.ownerInfo);



            for (int i = 0; i < print.InvioceProductsDataSet.invoiceProdsDt.Count; i++)
            {
                int nbColis = Convert.ToInt32(print.InvioceProductsDataSet.invoiceProdsDt[i][3]);
                int selledQnt = Convert.ToInt32(print.InvioceProductsDataSet.invoiceProdsDt[i][1]);
                double sellPrice = Convert.ToDouble(print.InvioceProductsDataSet.invoiceProdsDt[i][2]);
                double totalPrice = selledQnt * sellPrice;

                totColis += nbColis;
                totOfAllSelledPrice += totalPrice;
            }
            MsBox message = new MsBox("CHARGEMENT...", AlertType.success);
            message.ShowDialog();
            ReportParameter[] Prmt = new ReportParameter[] {
                            new ReportParameter("currentUser",CommonInfo.currentUserID),
                            new ReportParameter("total",totOfAllSelledPrice.ToString()),
                            new ReportParameter("colis",totColis.ToString()),
                            new ReportParameter("numBonLivr",selectedInvoiceNum),
                            new ReportParameter("creationDate",alldeleveriesGridView.Rows[selectedRow].Cells[3].Value.ToString().Substring(0,10))
                        };
            print.reportViewer1.LocalReport.SetParameters(Prmt);
            print.reportViewer1.RefreshReport();
            print.reportViewer1.LocalReport.EnableExternalImages = true;
            print.Show();

        }

        private void invoiceSearchTxtBox_Enter(object sender, EventArgs e)
        {
            if (invoiceSearchTxtBox.Text == "abcd....") invoiceSearchTxtBox.Text = "";
        }

        private void invoiceSearchTxtBox_Leave(object sender, EventArgs e)
        {
            if (invoiceSearchTxtBox.Text == "") invoiceSearchTxtBox.Text = "abcd....";
        }

        private async void invoiceSearchTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            if (invoiceSearchTxtBox.Text == "abcd....") return;
            InvoicesService service = new InvoicesService();
            DataTable result = await service.getSearchedDeliveryDocuments(invoiceSearchTxtBox.Text.Replace("'", "`"));
            if (result == null) return;
            alldeleveriesGridView.Rows.Clear();
            for (int i = 0; i < result.Rows.Count; i++)
            {
                int newRow = alldeleveriesGridView.Rows.Add();
                alldeleveriesGridView.Rows[newRow].Cells[0].Value = result.Rows[i][0];
                alldeleveriesGridView.Rows[newRow].Cells[1].Value = result.Rows[i][1];
                alldeleveriesGridView.Rows[newRow].Cells[2].Value = result.Rows[i][2];
                alldeleveriesGridView.Rows[newRow].Cells[3].Value = result.Rows[i][3];

            }

        }

        private async void searchInvoiceBtn_Click(object sender, EventArgs e)
        {
            InvoicesService service = new InvoicesService();
            DataTable result = await service.getSearchedDeliveryDocumentsByDate(invoiceNumBox.Text,invoiceDate.Value.ToString("MM/dd/yyyy"));
            if (result == null) return;
            alldeleveriesGridView.Rows.Clear();
            for (int i = 0; i < result.Rows.Count; i++)
            {
                int newRow = alldeleveriesGridView.Rows.Add();
                alldeleveriesGridView.Rows[newRow].Cells[0].Value = result.Rows[i][0];
                alldeleveriesGridView.Rows[newRow].Cells[1].Value = result.Rows[i][1];
                alldeleveriesGridView.Rows[newRow].Cells[2].Value = result.Rows[i][2];
                alldeleveriesGridView.Rows[newRow].Cells[3].Value = result.Rows[i][3];

            }
        }
    }
    }
