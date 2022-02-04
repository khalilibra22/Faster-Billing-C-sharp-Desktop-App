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
    public partial class FinalInvoice : UserControl
    {
        public FinalInvoice()
        {
            InitializeComponent();
        }

        public async void loadAllInvoicesDocuments()
        {
            InvoicesService service = new InvoicesService();
            DataTable result = await service.getAllInvoicesDocuments();
            if (result == null) return;
            finalInvoicesGridView.Rows.Clear();
            for (int i = 0; i < result.Rows.Count; i++)
            {
                int newRow = finalInvoicesGridView.Rows.Add();
                finalInvoicesGridView.Rows[newRow].Cells[0].Value = result.Rows[i][0];
                finalInvoicesGridView.Rows[newRow].Cells[1].Value = result.Rows[i][1];
                finalInvoicesGridView.Rows[newRow].Cells[2].Value = result.Rows[i][2];
                finalInvoicesGridView.Rows[newRow].Cells[3].Value = result.Rows[i][3];

            }
        }

        private void closeAll_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private async void printFinalInvoiceBtn_Click(object sender, EventArgs e)
        {
            int totColis = 0;
            double localTva = 0.0;
            double totOfAllSelledPrice = 0.0;
            if (finalInvoicesGridView.Rows.Count == 0) return;
            int selectedRow = finalInvoicesGridView.CurrentCell.RowIndex;
            String selectedInvoiceNum = finalInvoicesGridView.Rows[selectedRow].Cells[0].Value.ToString();
            PrintFinalInvoice print = new PrintFinalInvoice();

            //generate QR code for invoice Number
            //begin


            print.QRcodeDataSet.invoiceQRcode.Rows.Clear();
            QRCoder.QRCodeGenerator qrCoderGernerator = new QRCoder.QRCodeGenerator();
            QRCoder.QRCodeData qrCoderData = qrCoderGernerator.CreateQrCode(finalInvoicesGridView.Rows[selectedRow].Cells[1].Value.ToString(), QRCoder.QRCodeGenerator.ECCLevel.Q);
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
            localTva = Convert.ToDouble(print.invoiceDataSet.invoiceDt.Rows[0]["tva"]);
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
                            new ReportParameter("creationDate",finalInvoicesGridView.Rows[selectedRow].Cells[3].Value.ToString().Substring(0,10)),
                            new ReportParameter("numFact",finalInvoicesGridView.Rows[selectedRow].Cells[1].Value.ToString()),
                            new ReportParameter("amountLetter", amountToLetter(((totOfAllSelledPrice*localTva)/100)+totOfAllSelledPrice))
                        };
            print.reportViewer1.LocalReport.SetParameters(Prmt);
            print.reportViewer1.RefreshReport();
            print.reportViewer1.LocalReport.EnableExternalImages = true;
            print.Show();
        }

        private String amountToLetter(double tot)
        {
            String amountLetter = "";
            amountLetter = tot.ToString().Replace(',', '.');
            try
            {
                String[] amounts = amountLetter.Split('.');
                long realPart = Convert.ToInt64(amounts[0]);
                long floatPart = Convert.ToInt64(amounts[1]);
                if (floatPart != 0)
                    amountLetter = new toLetter().IntToFr(realPart) + " dinar(s) et " + new toLetter().IntToFr(floatPart) + " centime(s)";
                else amountLetter = new toLetter().IntToFr(realPart) + " dinar(s)";
            }
            catch
            {
                long realPart = Convert.ToInt64(amountLetter);
                amountLetter = new toLetter().IntToFr(realPart) + " dinar(s)";
            }
            return amountLetter;
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
            DataTable result = await service.getSearchedInvoicesDocuments(invoiceSearchTxtBox.Text);
            if (result == null) return;
            finalInvoicesGridView.Rows.Clear();
            for (int i = 0; i < result.Rows.Count; i++)
            {
                int newRow = finalInvoicesGridView.Rows.Add();
                finalInvoicesGridView.Rows[newRow].Cells[0].Value = result.Rows[i][0];
                finalInvoicesGridView.Rows[newRow].Cells[1].Value = result.Rows[i][1];
                finalInvoicesGridView.Rows[newRow].Cells[2].Value = result.Rows[i][2];
                finalInvoicesGridView.Rows[newRow].Cells[3].Value = result.Rows[i][3];

            }
        }

        private async void searchInvoiceBtn_Click(object sender, EventArgs e)
        {
            InvoicesService service = new InvoicesService();
            DataTable result = await service.getSearchedInvoicesDocumentsByDate(invoiceNumBox.Text, invoiceDate.Value.ToString("MM/dd/yyyy"));
            if (result == null) return;
            finalInvoicesGridView.Rows.Clear();
            for (int i = 0; i < result.Rows.Count; i++)
            {
                int newRow = finalInvoicesGridView.Rows.Add();
                finalInvoicesGridView.Rows[newRow].Cells[0].Value = result.Rows[i][0];
                finalInvoicesGridView.Rows[newRow].Cells[1].Value = result.Rows[i][1];
                finalInvoicesGridView.Rows[newRow].Cells[2].Value = result.Rows[i][2];
                finalInvoicesGridView.Rows[newRow].Cells[3].Value = result.Rows[i][3];

            }
        }
    }
}
