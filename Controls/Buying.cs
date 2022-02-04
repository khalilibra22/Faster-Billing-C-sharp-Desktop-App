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

namespace Facturation.Controls
{
    public partial class Buying : UserControl
    {
        String clientId;
        String buyedProdRefrence;
        int selectedProsPosition;
        double amountsTotal;
        int stockQnt;
        Dictionary<string, int> quantities ;
        private DataTable invoiceProducts;

        public Buying()
        {
            InitializeComponent();
            clientId = "";
            buyedProdRefrence = "";
            selectedProsPosition = -1;
            amountsTotal = 0.0;
            stockQnt = -1;
            quantities = new Dictionary<string, int>();
            invoiceProducts = new DataTable();
            invoiceProducts.Columns.Add("prodRef");
            invoiceProducts.Columns.Add("sellPrice");
            invoiceProducts.Columns.Add("selledQnt");
            

        }

        private void addClientBtn_Click(object sender, EventArgs e)
        {
            if (clientsGridView.Rows.Count == 0)
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

        private async void getAllSupplier()
        {
            SuppliersService service = new SuppliersService();
            DataTable result = await service.getAllSuppliers();
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

        public async void getAllProducts()
        {
            ProductsService service = new ProductsService();
            DataTable allProducts = await service.getAllProducts();
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
                productsGridView.Rows[newRow].Cells[2].Value = result.Rows[i][3];

            }

        }

        public void loadInvoice()
        {

            getAllSupplier();
            getAllProducts();
        }

        private void productsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            buyedProdQnt.Text = "";
            buyedProdColis.Text = "";
            int selectedRow = productsGridView.CurrentCell.RowIndex;
            selectedProsPosition = selectedRow;
            buyedProdRefrence = productsGridView.Rows[selectedRow].Cells[0].Value.ToString();
            buyedProdName.Text = productsGridView.Rows[selectedRow].Cells[1].Value.ToString();
            stockQnt = Convert.ToInt32(productsGridView.Rows[selectedRow].Cells[2].Value);
            //buyedProdPrice = productsGridView.Rows[selectedRow].Cells[2].Value.ToString();
        }

        private void addBuyedProdToInvoice_Click(object sender, EventArgs e)
        {
            if (buyedProdName.Text == "") return;
            int buyedQuantity = 0;
            double buyedProductColis = 0.0;
            double PT = 0.0;
            

            try
            {
                buyedQuantity = Convert.ToInt32(buyedProdQnt.Text);
                buyedProductColis = Convert.ToDouble(buyedProdColis.Text.Replace('.',','));
                
            }
            catch
            {
                MsBox message = new MsBox("Vérifier les données entrées", AlertType.error);
                message.ShowDialog();
                return;
            }
            if(quantities.ContainsKey(buyedProdRefrence))
            {
                MsBox message = new MsBox("Ce produit est ajouté déjà !!", AlertType.error);
                message.ShowDialog();
                return;
                //quantities[buyedProdRefrence] += buyedQuantity;
                //for(int i=0;i< invoiceGridView.Rows.Count; i++)
                //{
                //    if (invoiceGridView.Rows[i].Cells[0].Value.ToString() == buyedProdRefrence)
                //    {
                //        countTotaldel(buyedQuantity * buyedProductColis);
                //        invoiceGridView.Rows[i].Cells[3].Value = quantities[buyedProdRefrence];
                //        countTotal(quantities[buyedProdRefrence] * buyedProductColis);
                //        break;
                //    }

                //}
               

            }
            quantities.Add(buyedProdRefrence, stockQnt);
            PT = buyedQuantity * buyedProductColis;
            int newRow = invoiceGridView.Rows.Add();
            invoiceGridView.Rows[newRow].Cells[0].Value = buyedProdRefrence;
            invoiceGridView.Rows[newRow].Cells[1].Value = buyedProdName.Text;
            invoiceGridView.Rows[newRow].Cells[2].Value = buyedProductColis.ToString();
            invoiceGridView.Rows[newRow].Cells[3].Value = buyedQuantity;
            invoiceGridView.Rows[newRow].Cells[4].Value = PT;
            countTotal(PT);
            buyedProdName.Text = "";
            buyedProdQnt.Text = "";
            buyedProdColis.Text = "";
            buyedProdRefrence = "";
            stockQnt = -1;
            

        }

        private void countTotal(double newAmouont)
        {
            amountsTotal += Math.Round(newAmouont, 2);
            amountsTotLabel.Text = Math.Round(amountsTotal, 2).ToString();
        }

        private void countTotaldel(double newAmouont)
        {
            
            amountsTotal -= Math.Round(newAmouont, 2);           
            amountsTotLabel.Text = Math.Round(amountsTotal, 2).ToString();
           
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
            quantities.Remove(invoiceGridView.Rows[selectedRow].Cells[0].Value.ToString());           
            invoiceGridView.Rows.RemoveAt(selectedRow);


            countTotaldel(PT);
            
        }

        private async void saveAndPrintInvoiceBtn_Click(object sender, EventArgs e)
        {
            if (clientId == "")
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
            bool updateProdQuantities = await new ProductsService().updateProductsQuantities(newQuantitiesProducts());
            if (updateProdQuantities)
            {
                double supplierDette = await new SuppliersService().getSupplierDette(clientId) + amountsTotal;
                if (supplierDette == -1) return;
                bool updateDette = await new SuppliersService().updateSuppliertDette(clientId, supplierDette);
                if (updateDette)
                {
                    invoiceProducts.Rows.Clear();
                    for (int i = 0; i < invoiceGridView.Rows.Count; i++)
                    {
                        DataRow item = invoiceProducts.NewRow();
                        item["prodRef"] = invoiceGridView.Rows[i].Cells[0].Value;
                        item["selledQnt"] = invoiceGridView.Rows[i].Cells[3].Value;
                        item["sellPrice"] = invoiceGridView.Rows[i].Cells[2].Value;
                        invoiceProducts.Rows.Add(item);
                    }
                    String invoiceId = generateInvoiceId();
                    bool result = await new SuppliersService().createNewInvoice(invoiceId, DateTime.Now.ToString(), clientId, invoiceProducts);
                    if(result) new MsBox("Chargement...", AlertType.success).ShowDialog();
                    loadTOPrint(invoiceId);

                    removeClient_Click(sender, e);
                    invoiceGridView.Rows.Clear();
                    invoiceProducts.Rows.Clear();                    
                    amountsTotLabel.Text = "0";
                    quantities.Clear();
                    amountsTotal = 0.0;
                    getAllProducts();                    
                    
                }

            }
        }

        private async void loadTOPrint( String invoiceID)
        {
            
           
            PintBonAchat print = new PintBonAchat();

            //generate QR code for invoice Number
            //begin


            print.QRcodeDataSet.invoiceQRcode.Rows.Clear();
            QRCoder.QRCodeGenerator qrCoderGernerator = new QRCoder.QRCodeGenerator();
            QRCoder.QRCodeData qrCoderData = qrCoderGernerator.CreateQrCode(invoiceID, QRCoder.QRCodeGenerator.ECCLevel.Q);
            QRCoder.QRCode qrCode = new QRCoder.QRCode(qrCoderData);
            Bitmap bmp = qrCode.GetGraphic(7);
            using (MemoryStream ms = new MemoryStream())
            {
                bmp.Save(ms, ImageFormat.Bmp);
                DataRow item = print.QRcodeDataSet.invoiceQRcode.NewRow();
                item["image"] = ms.ToArray();
                print.QRcodeDataSet.invoiceQRcode.Rows.Add(item);

            }


            SuppliersService getInvoiceInformation = new SuppliersService();
            print.AchatDataSet.DataTable1.Rows.Clear();
            bool invoiceInformationResult = await getInvoiceInformation.getBuyingInfo(invoiceID, print.AchatDataSet.DataTable1);

            SuppliersService getAllInvoiceProducts = new SuppliersService();
            print.BonAchatProds.achatProdsDt.Rows.Clear();

            bool invoiceProductsResult = await getAllInvoiceProducts.getBuyingProducts(invoiceID, print.BonAchatProds.achatProdsDt);


            CompanyInfo getCompanyAllInfo = new CompanyInfo();
            print.OwnerInfoDataSet.ownerInfo.Rows.Clear();
            bool companyAllInfoResult = await getCompanyAllInfo.getOwnerInfor2Repport(print.OwnerInfoDataSet.ownerInfo);


            ReportParameter[] Prmt = new ReportParameter[] {
          
                            new ReportParameter("total",amountsTotal.ToString()),
                            new ReportParameter("currentUser",CommonInfo.currentUserID)

                        };
            print.reportViewer1.LocalReport.SetParameters(Prmt);
            print.reportViewer1.RefreshReport();
            print.reportViewer1.LocalReport.EnableExternalImages = true;
            print.Show();
        }

        private Dictionary<string, int> newQuantitiesProducts()
        {
            for(int i = 0; i < invoiceGridView.Rows.Count; i++)
            {
                int buyedQnt = Convert.ToInt32(invoiceGridView.Rows[i].Cells[3].Value);
                quantities[invoiceGridView.Rows[i].Cells[0].Value.ToString()] += buyedQnt;
            }

            return quantities;

        }

        private String generateInvoiceId()
        {
            String cid = "A" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour +
                DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond;
            return cid;
        }

        private void searchClientBox_Enter(object sender, EventArgs e)
        {
            if (searchClientBox.Text == "abcd....") searchClientBox.Text = "";
        }

        private void searchClientBox_Leave(object sender, EventArgs e)
        {
            if (searchClientBox.Text == "") searchClientBox.Text = "abcd....";
        }

        private async void searchedClients(String searchedItem)
        {
            SuppliersService service = new SuppliersService();
            DataTable result = await service.getSearchedSuppliers(searchedItem);
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

        private void searchProductsBox_Enter(object sender, EventArgs e)
        {
            if (searchProductsBox.Text == "abcd....") searchProductsBox.Text = "";
        }

        private void searchProductsBox_Leave(object sender, EventArgs e)
        {
            if (searchProductsBox.Text == "") searchProductsBox.Text = "abcd....";
        }

        private void searchProductsBox_OnValueChanged(object sender, EventArgs e)
        {
            if (searchProductsBox.Text == "abcd....") return;
            searchedProducts(searchProductsBox.Text.Replace("'", "`"));
        }

        async void searchedProducts(String searchedItem)
        {
            ProductsService service = new ProductsService();
            DataTable result = await service.getSearchedProducts(searchedItem);
            showDataInGridView(result);
        }
    }

    
}
