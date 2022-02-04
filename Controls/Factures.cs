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
using Facturation.Config;
using Microsoft.Reporting.WinForms;
using System.IO;
using System.Drawing.Imaging;

namespace Facturation.Controls
{
    public partial class Factures : UserControl
    {
        String clientId;
        String invoiceId;
        String buyedProdRefrence ;
        String buyedProdPrice;
        int selectedProsPosition;
        double amountsTotal;
        int colisTotal;
        Dictionary<string, int> storedQuantity;
        DataTable seachedProducts;
        DataTable allProducts;
        private DataTable invoiceProducts;


        public Factures()
        {
            InitializeComponent();
            invoiceId = "";
            clientId =  "";
            clientName.Text = "";
            clientAddress.Text = "";
            buyedProdRefrence = "";
            buyedProdPrice = "";
            storedQuantity = new Dictionary<string, int>();
            selectedProsPosition = -1;
            amountsTotal = 0.0;
            colisTotal = 0;
            seachedProducts = new DataTable();
            seachedProducts.Columns.Add("prodRef");
            seachedProducts.Columns.Add("prodName");
            seachedProducts.Columns.Add("prodPrice");
            seachedProducts.Columns.Add("prodQnt");
            invoiceProducts = new DataTable();
            invoiceProducts.Columns.Add("prodRef");
            invoiceProducts.Columns.Add("selledQnt");
            invoiceProducts.Columns.Add("sellPrice");
            invoiceProducts.Columns.Add("colis");

        }

        private void Factures_Load(object sender, EventArgs e)
        {
            updatePanel.Hide();
            back2Invoice.Hide();
            deliveryDocument1.Hide();
            finalInvoice1.Hide();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ADDBtn_Click(object sender, EventArgs e)
        {
            if(clientsGridView.Rows.Count == 0)
            {
                MsBox message = new MsBox("Aucun client selectioné", AlertType.info);
                message.ShowDialog();
                return;
            }
            errorMsgClient.Hide();
            int selectedRow = clientsGridView.CurrentCell.RowIndex;
            clientId = clientsGridView.Rows[selectedRow].Cells[0].Value.ToString();
            clientName.Text = clientsGridView.Rows[selectedRow].Cells[1].Value.ToString().ToUpper();
            clientAddress.Text = clientsGridView.Rows[selectedRow].Cells[2].Value.ToString().ToUpper();


        }

        private void removeClient_Click(object sender, EventArgs e)
        {
            clientId = "";
            clientName.Text = "";
            clientAddress.Text = "";
            errorMsgClient.Show();
        }

        private void searchProd_Enter(object sender, EventArgs e)
        {
            if (searchProductsBox.Text == "abcd....") searchProductsBox.Text = "";           
        }

        private void searchProd_Leave(object sender, EventArgs e)
        {
            if (searchProductsBox.Text == "") searchProductsBox.Text = "abcd....";
        }

        private void searchClient_Enter(object sender, EventArgs e)
        {
            if (searchClientBox.Text == "abcd....") searchClientBox.Text = "";
        }

        private void searchClient_Leave(object sender, EventArgs e)
        {
            if (searchClientBox.Text == "") searchClientBox.Text = "abcd....";
        }

        private async void getAllClients()
        {
            ClientsService service = new ClientsService();
            DataTable result = await service.getAllClients();
            if (result == null) return;
            clientsGridView.Rows.Clear();
            for (int i = 0; i < result.Rows.Count; i++)
            {
                int newRow = clientsGridView.Rows.Add();
                clientsGridView.Rows[newRow].Cells[0].Value = result.Rows[i][0];
                clientsGridView.Rows[newRow].Cells[1].Value = result.Rows[i][1];
                clientsGridView.Rows[newRow].Cells[2].Value = result.Rows[i][2] + " " + result.Rows[i][3];
                
            }
        }
        public void loadInvoice()
        {
            
            getAllClients();
            getAllProducts();
        }

        private async void searchedClients(String searchedItem)
        {
            ClientsService service = new ClientsService();
            DataTable result = await service.getSearchedClients(searchedItem);
            if (result == null) return;
            clientsGridView.Rows.Clear();
            for (int i = 0; i < result.Rows.Count; i++)
            {
                int newRow = clientsGridView.Rows.Add();
                clientsGridView.Rows[newRow].Cells[0].Value = result.Rows[i][0];
                clientsGridView.Rows[newRow].Cells[1].Value = result.Rows[i][1];
                clientsGridView.Rows[newRow].Cells[2].Value = result.Rows[i][2] + " " + result.Rows[i][3];

            }
        }

        private void searchClientBox_OnValueChanged(object sender, EventArgs e)
        {
            if (searchClientBox.Text == "abcd....") return;
            searchedClients(searchClientBox.Text.Replace("'", "`"));
        }

        public async void getAllProducts()
        {
            ProductsService service = new ProductsService();
            allProducts = await service.getAllProducts();
            showDataInGridView(allProducts);
        }
        private void showDataInGridView(DataTable result)
        {
            
            if (result == null) return;
            productsGridView.Rows.Clear();
            for (int i = 0; i < result.Rows.Count; i++)
            {
                int newRow = productsGridView.Rows.Add();
                productsGridView.Rows[newRow].Cells[0].Value = result.Rows[i][0];
                productsGridView.Rows[newRow].Cells[1].Value = result.Rows[i][1];
                productsGridView.Rows[newRow].Cells[2].Value = result.Rows[i][2];
                
            }
            
        }

        private void productsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            buyedProdQnt.Text = "";
            buyedProdColis.Text = "";
            int selectedRow = productsGridView.CurrentCell.RowIndex;
            selectedProsPosition = selectedRow;
            buyedProdRefrence = productsGridView.Rows[selectedRow].Cells[0].Value.ToString();
            buyedProdName.Text = productsGridView.Rows[selectedRow].Cells[1].Value.ToString();
            buyedProdPrice = productsGridView.Rows[selectedRow].Cells[2].Value.ToString();
            
        }

         void searchedProducts(String searchedItem)
        {
            seachedProducts.Rows.Clear();
            for (int i = 0; i < allProducts.Rows.Count; i++)
            {
                String prodName = allProducts.Rows[i][1].ToString();
                if (prodName.ToLower().Contains(searchedItem.ToLower()))
                {
                    DataRow item = seachedProducts.NewRow();
                    item["prodRef"] = allProducts.Rows[i][0];
                    item["prodName"] = prodName;
                    item["prodPrice"] = allProducts.Rows[i][2];
                    
                    seachedProducts.Rows.Add(item);
                }
            }

            
            showDataInGridView(seachedProducts);
        }

        private void searchProductsBox_OnValueChanged(object sender, EventArgs e)
        {
            if (searchProductsBox.Text == "abcd....") return;

            searchedProducts(searchProductsBox.Text.Replace("'", "`"));
        }

        private  void addBuyedProdToInvoice_Click(object sender, EventArgs e)
        {
            if (buyedProdName.Text == "") return;
            int buyedQuantity = 0;
            int buyedProductColis = 0;
            int sotockedQuantity = 0;
            double PU = 0.0;
            
            try
            {
                buyedQuantity = Convert.ToInt32(buyedProdQnt.Text);
                buyedProductColis = Convert.ToInt32(buyedProdColis.Text);
                PU = Convert.ToDouble(buyedProdPrice);
            }
            catch
            {
                MsBox message = new MsBox("Vérifier les données entrées", AlertType.error);
                message.ShowDialog();
                return;
            }

            try
            {
                double Tva = Convert.ToDouble(tvaValueBox.Text);
            }
            catch
            {
                MsBox message = new MsBox("Vérifier la valeur : TVA", AlertType.error);
                message.ShowDialog();
                return;
            }

            if (storedQuantity.Count != 0)
            {
                if (storedQuantity.ContainsKey(buyedProdRefrence))
                {
                    for(int i = 0; i < invoiceGridView.Rows.Count; i++)
                    {
                        if(invoiceGridView.Rows[i].Cells[0].Value.ToString() == buyedProdRefrence)
                        {
                            int qnt = Convert.ToInt32(invoiceGridView.Rows[i].Cells[3].Value);
                            int colis = Convert.ToInt32(invoiceGridView.Rows[i].Cells[5].Value);
                            int nwQnt = qnt + buyedQuantity;
                            int nwColis = colis + buyedProductColis;
                            double nwPT = PU * nwQnt;
                            invoiceGridView.Rows[i].Cells[3].Value = nwQnt;
                            invoiceGridView.Rows[i].Cells[5].Value = nwColis;
                            invoiceGridView.Rows[i].Cells[4].Value = nwPT;
                            countTotaldel(PU*qnt , colis);
                            countTotal(nwPT, nwColis);
                            break;
                        }
                    }
                    buyedProdName.Text = "";
                    buyedProdQnt.Text = "";
                    buyedProdColis.Text = "";
                    buyedProdRefrence = "";
                    buyedProdPrice = "";
                    return;
                }

            }

            //add in gridview
            double PT = PU * buyedQuantity;
            storedQuantity.Add(buyedProdRefrence, sotockedQuantity - buyedQuantity);
            int newRow = invoiceGridView.Rows.Add();
            invoiceGridView.Rows[newRow].Cells[0].Value = buyedProdRefrence;
            invoiceGridView.Rows[newRow].Cells[1].Value = buyedProdName.Text;
            invoiceGridView.Rows[newRow].Cells[2].Value = buyedProdPrice;
            invoiceGridView.Rows[newRow].Cells[3].Value = buyedQuantity;
            invoiceGridView.Rows[newRow].Cells[4].Value = PT;
            invoiceGridView.Rows[newRow].Cells[5].Value = buyedProductColis;
           
            countTotal(PT, buyedProductColis);
            
            // clear feilds
            buyedProdName.Text = "";
            buyedProdQnt.Text = "";
            buyedProdColis.Text = "";
            buyedProdRefrence = "";
            buyedProdPrice = "";
            tvaValueBox.Enabled = false;
        }

        private void deleteBuyedProdBtn_Click(object sender, EventArgs e)
        {
            if (invoiceGridView.Rows.Count == 0)
            {
                MsBox message = new MsBox("Aucun élement selectioné", AlertType.info);
                message.ShowDialog();
                return;
            }
            int selectedRow = invoiceGridView.CurrentCell.RowIndex;
           
            double PT = Convert.ToDouble(invoiceGridView.Rows[selectedRow].Cells[4].Value);
            int nbColis = Convert.ToInt32(invoiceGridView.Rows[selectedRow].Cells[5].Value);
            storedQuantity.Remove(invoiceGridView.Rows[selectedRow].Cells[0].Value.ToString());
            invoiceGridView.Rows.RemoveAt(selectedRow);
       

            countTotaldel(PT, nbColis);
            if(invoiceGridView.Rows.Count == 0) tvaValueBox.Enabled = true;

        }

        private void countTotal(double newAmouont,int newColisNbr)
        {
            double tva = Convert.ToDouble(tvaValueBox.Text);
            double TVAamount = (Math.Round(newAmouont, 2) * tva) / 100;
            double newTTCAmount = newAmouont + TVAamount;
            amountsTotal += Math.Round(newTTCAmount, 2);
            colisTotal += newColisNbr;
            amountsTotLabel.Text = Math.Round(amountsTotal, 2).ToString();
            colisTotLabel.Text = colisTotal.ToString();
        }

        private void countTotaldel(double newAmouont, int newColisNbr)
        {
            double tva = Convert.ToDouble(tvaValueBox.Text);
            double TVAamount = (Math.Round(newAmouont, 2) * tva) / 100;
            double newTTCAmount = newAmouont + TVAamount;
            amountsTotal -= Math.Round(newTTCAmount, 2);
            colisTotal -= newColisNbr;
            amountsTotLabel.Text = Math.Round(amountsTotal, 2).ToString();
            colisTotLabel.Text = colisTotal.ToString();
        }

        private async void saveAndPrintInvoiceBtn_Click(object sender, EventArgs e)
        {
            if(clientId == "")
            {
                MsBox message = new MsBox("Selectionné un client svp", AlertType.info);
                message.ShowDialog();
                return;
            }
            if (invoiceGridView.Rows.Count == 0)
            {
                MsBox message = new MsBox("Ajouter des produits svp", AlertType.info);
                message.ShowDialog();
                return;
            }
            invoiceProducts.Rows.Clear();
            for(int i = 0; i < invoiceGridView.Rows.Count; i++)
            {
                DataRow item = invoiceProducts.NewRow();
                item["prodRef"] = invoiceGridView.Rows[i].Cells[0].Value;
                item["selledQnt"] = invoiceGridView.Rows[i].Cells[3].Value;
                item["sellPrice"] = invoiceGridView.Rows[i].Cells[2].Value;
                item["colis"] = invoiceGridView.Rows[i].Cells[5].Value;
                invoiceProducts.Rows.Add(item);
            }
            invoiceId = generateInvoiceId();
            InvoicesService service = new InvoicesService();
            bool result = await service.createNewInvoice(invoiceId, DateTime.Now.ToString(), DateTime.Now.AddDays(7).ToString(),
                clientId, invoiceProducts,tvaValueBox.Text, CommonInfo.currentUserID);
            //P//roductsService prodService = new ProductsService();
            //prodService.updateProductsQuantities(storedQuantity);

            if (result)
            {
                //ProductsService prodService = new ProductsService();
                //bool updateResult = await prodService.updateProductsQuantities(storedQuantity);
                //if (updateResult)
                //{
                
                    MsBox message = new MsBox("Chargement...", AlertType.success);
                    message.ShowDialog();

                    loadInvoiceData2DataSets();

                    removeClient_Click(sender, e);
                    invoiceGridView.Rows.Clear();
                    invoiceProducts.Rows.Clear();
                    storedQuantity.Clear();
                    amountsTotLabel.Text = "0";
                    colisTotLabel.Text = "0";
                    amountsTotal = 0.0;
                    colisTotal = 0;
                    tvaValueBox.Enabled = true;
                //}
                
            }


        }

        private async void loadInvoiceData2DataSets()
        {
            InvoicePrintFrom print = new InvoicePrintFrom();
            //print.Show();
            InvoicesService getInvoiceInformation = new InvoicesService();
            print.invoiceDataSet.invoiceDt.Rows.Clear();
            bool invoiceInformationResult = await getInvoiceInformation.getInvoiceInfo(invoiceId,print.invoiceDataSet.invoiceDt);

            InvoicesService getAllInvoiceProducts = new InvoicesService();
            print.InvioceProductsDataSet.invoiceProdsDt.Rows.Clear();
            bool invoiceProductsResult = await getAllInvoiceProducts.getInvoiceProducts(invoiceId, print.InvioceProductsDataSet.invoiceProdsDt);
            CompanyInfo getCompanyAllInfo = new CompanyInfo();
            print.OwnerInfoDataSet.ownerInfo.Rows.Clear();
            bool companyAllInfoResult = await getCompanyAllInfo.getOwnerInfor2Repport(print.OwnerInfoDataSet.ownerInfo);

            //generate QR code for invoice Number
            //begin
            print.QRcodeDataSet.invoiceQRcode.Rows.Clear();
            QRCoder.QRCodeGenerator qrCoderGernerator = new QRCoder.QRCodeGenerator();
            QRCoder.QRCodeData qrCoderData = qrCoderGernerator.CreateQrCode(invoiceId, QRCoder.QRCodeGenerator.ECCLevel.Q);
            QRCoder.QRCode qrCode = new QRCoder.QRCode(qrCoderData);
            Bitmap bmp = qrCode.GetGraphic(7);
            using (MemoryStream ms = new MemoryStream())
            {
                bmp.Save(ms, ImageFormat.Bmp);
                DataRow item = print.QRcodeDataSet.invoiceQRcode.NewRow();
                item["image"] = ms.ToArray();
                print.QRcodeDataSet.invoiceQRcode.Rows.Add(item);

            }
            double tva = Convert.ToDouble(tvaValueBox.Text);
            double theHTamount = (amountsTotal * 100) / (100 + tva);
            
            ReportParameter[] Prmt = new ReportParameter[] {
                new ReportParameter("currentUser",CommonInfo.currentUserID),
                new ReportParameter("total",theHTamount.ToString()),
            new ReportParameter("colis", colisTotLabel.Text),
            new ReportParameter("amountLetter", amountToLetter(amountsTotal))
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

        private String generateInvoiceId()
        {
            String cid = "PI" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour +
                DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond;
            return cid;
        }

        private void allInvoicesBtn_MouseHover(object sender, EventArgs e)
        {
            allInvoicesBtn.Image = Image.FromFile(@"Images\billHover.png");
        }

        private void allInvoicesBtn_MouseLeave(object sender, EventArgs e)
        {
            allInvoicesBtn.Image = Image.FromFile(@"Images\bill.png");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void fillAllInvoicesGridView(DataTable result)
        {
            allInvoicesGridView.Rows.Clear();
            for (int i = 0; i < result.Rows.Count; i++)
            {
                int newRow = allInvoicesGridView.Rows.Add();
                allInvoicesGridView.Rows[newRow].Cells[0].Value = result.Rows[i][0];
                allInvoicesGridView.Rows[newRow].Cells[1].Value = result.Rows[i][2];
                allInvoicesGridView.Rows[newRow].Cells[2].Value = result.Rows[i][3];
                allInvoicesGridView.Rows[newRow].Cells[3].Value = result.Rows[i][1];
                bool isConfirmed = Convert.ToBoolean(result.Rows[i][4]);
                if (isConfirmed)
                {
                    allInvoicesGridView.Rows[newRow].Cells[4].Value = "OUI";
                    allInvoicesGridView.Rows[newRow].DefaultCellStyle.BackColor = Color.FromArgb(107, 171, 119);
                }
                else allInvoicesGridView.Rows[newRow].Cells[4].Value = "NON";

            }
        }

        private async void allInvoicesBtn_Click(object sender, EventArgs e)
        {
            updatePanel.Show();
            back2Invoice.Show();
            InvoicesService service = new InvoicesService();
            DataTable result = await service.getAllInvoices();

            if (result == null) return;
            fillAllInvoicesGridView(result);
        }

        private void back2Invoice_Click(object sender, EventArgs e)
        {
            updatePanel.Hide();
            back2Invoice.Hide();
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
            DataTable result = await service.getSearchedInvoicesByClientName(invoiceSearchTxtBox.Text.Replace("'", "`"));
            if (result == null) return;
            fillAllInvoicesGridView(result);
        }

        private async void searchInvoiceBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(invoiceDate.Value.ToString());
            InvoicesService service = new InvoicesService();
            DataTable result = await service.getSearchedInvoicesByInvoiceNumOrDate(invoiceNumBox.Text, invoiceDate.Value.ToString("MM/dd/yyyy"));
            if (result == null) return;
            fillAllInvoicesGridView(result);
        }

        private async void deleteInvoice_Click(object sender, EventArgs e)
        {
            if (allInvoicesGridView.Rows.Count == 0) return;
            int selectedRow = allInvoicesGridView.CurrentCell.RowIndex;
            String selectedInvoiceNum = allInvoicesGridView.Rows[selectedRow].Cells[0].Value.ToString();
            Dictionary<string, int> updateQnt = new Dictionary<string, int>();
            ProductsService prodsService = new ProductsService();
            DataTable deletedInvoiceProdQnt = await prodsService.getInvoiceProductsQuantities(selectedInvoiceNum);
            for(int i = 0; i < deletedInvoiceProdQnt.Rows.Count; i++)
            {
                int stockQnt = Convert.ToInt32(deletedInvoiceProdQnt.Rows[i][1]);
                int deletedQnt = Convert.ToInt32(deletedInvoiceProdQnt.Rows[i][2]);
                int newQnt = stockQnt + deletedQnt;
                updateQnt.Add(deletedInvoiceProdQnt.Rows[i][0].ToString(), newQnt);
            }

            InvoicesService service = new InvoicesService();
            bool result = await service.deleteInvoice(selectedInvoiceNum, CommonInfo.currentUserID);
            if (result)
            {
                ProductsService updateProdsQntservice = new ProductsService();
                bool updateResult = await updateProdsQntservice.updateProductsQuantities(updateQnt);
                if (updateResult)
                {
                    MsBox message = new MsBox("Facture supprimé", AlertType.success);
                    message.ShowDialog();
                    allInvoicesBtn_Click(sender, e);
                }
                
            }
        }

        private async void editInvoiceBtn_Click(object sender, EventArgs e)
        {
            int totColis = 0;
            double localTva = 0.0;
            double totOfAllSelledPrice = 0.0;
            if (allInvoicesGridView.Rows.Count == 0) return;
            int selectedRow = allInvoicesGridView.CurrentCell.RowIndex;
            String selectedInvoiceNum = allInvoicesGridView.Rows[selectedRow].Cells[0].Value.ToString();
            InvoicePrintFrom print = new InvoicePrintFrom();

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
            bool invoiceInformationResult = await getInvoiceInformation.getInvoiceInfo(selectedInvoiceNum, print.invoiceDataSet.invoiceDt);
            localTva = Convert.ToDouble(print.invoiceDataSet.invoiceDt.Rows[0]["tva"]);
            InvoicesService getAllInvoiceProducts = new InvoicesService();
            print.InvioceProductsDataSet.invoiceProdsDt.Rows.Clear();
            bool invoiceProductsResult = await getAllInvoiceProducts.getInvoiceProducts(selectedInvoiceNum, print.InvioceProductsDataSet.invoiceProdsDt);
            

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
                new ReportParameter("amountLetter", amountToLetter(((totOfAllSelledPrice*localTva)/100)+totOfAllSelledPrice))
            };
            print.reportViewer1.LocalReport.SetParameters(Prmt);
            print.reportViewer1.RefreshReport();
            print.reportViewer1.LocalReport.EnableExternalImages = true ;
            print.Show();
        }

        private void productsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(productsGridView.Columns[e.ColumnIndex].Name == "addItem")
            {
                productsGridView_CellDoubleClick(sender, e);
            }
        }

        private void tvaValueBox_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void invoiceDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private async void transfromToDelivery_Click(object sender, EventArgs e)
        {
            if (allInvoicesGridView.Rows.Count == 0) return;
            int selectedRow = allInvoicesGridView.CurrentCell.RowIndex;
            if(allInvoicesGridView.Rows[selectedRow].Cells[4].Value.ToString() == "OUI")
            {
                new MsBox("Documents déjà créés",AlertType.info).ShowDialog();
                return;
            }
            String selectedInvoiceNum = allInvoicesGridView.Rows[selectedRow].Cells[0].Value.ToString();
            String deliveryNewId = generateDeliveryId();
            String finalInvoiceNewId = generateFinalInvoiceId();

            if (!await updateProductsQuantities(selectedInvoiceNum)) return;
            InvoicesService service = new InvoicesService();
            bool result = await service.createFinalDocuments(selectedInvoiceNum, DateTime.Now.ToString(), deliveryNewId, finalInvoiceNewId);
            if (result)
            {
                
                double addedAmount =  await new InvoicesService().getInvoicesTotal(selectedInvoiceNum);
                double ancienAmount = await new ClientsService().getClientDette(allInvoicesGridView.Rows[selectedRow].Cells[1].Value.ToString());
                double tot = addedAmount + ancienAmount;
                bool addVerssement = await new ClientsService().updateClientDette(allInvoicesGridView.Rows[selectedRow].Cells[1].Value.ToString(), tot);
                bool updateInvoiceStatus = await new InvoicesService().updateInvoiceStatus(selectedInvoiceNum);
                new MsBox("Documents crées", AlertType.success).ShowDialog();
                allInvoicesBtn_Click(sender, e);
            }

            

        }

        private async Task<bool> updateProductsQuantities(String proformaNum)
        {
            Dictionary<string, int> newQuantities = new Dictionary<string, int>();
            ProductsService prodService = new ProductsService();
            DataTable Quantities = await prodService.getInvoiceProductsQuantities(proformaNum);
            for(int i = 0; i < Quantities.Rows.Count; i++)
            {
                int qntInStock = Convert.ToInt32(Quantities.Rows[i][1]);
                int qntInInvoice = Convert.ToInt32(Quantities.Rows[i][2]);
                int newQnt = qntInStock - qntInInvoice;
                newQuantities.Add(Quantities.Rows[i][0].ToString(), newQnt);
            }
            foreach (KeyValuePair<string, int> item in newQuantities)
            {
                if(item.Value <= 0)
                {
                    new MsBox("Manque de quantité", AlertType.error).ShowDialog();
                    return false;
                }
            }
            ProductsService service = new ProductsService();
            bool result = await service.updateProductsQuantities(newQuantities);
            return true;
            
        }

        private String generateDeliveryId()
        {
            String cid = "Bl" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour +
                DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond;
            return cid;
        }
        private String generateFinalInvoiceId()
        {
            String cid = "F" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour +
                DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond;
            return cid;
        }

        private void deliveryDocuments_Click(object sender, EventArgs e)
        {
            
            deliveryDocument1.Show();
            deliveryDocument1.loadAlldileveryDocuments();
        }

        private void closeAll_Click(object sender, EventArgs e)
        {
            //deliveryDocument1.Hide();
        }

        private void finalInvoices_Click(object sender, EventArgs e)
        {
            finalInvoice1.Show();
            finalInvoice1.loadAllInvoicesDocuments();
        }
    }
}