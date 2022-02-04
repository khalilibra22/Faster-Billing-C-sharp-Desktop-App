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

namespace Facturation.Controls
{
    public partial class produits : UserControl
    {

        bool isNotification;
        DataTable notifiedProducts;
        String selectedId;
//        int page;
        public produits()
        {
            InitializeComponent();
            isNotification = false;
            notifiedProducts = new DataTable();
            notifiedProducts.Columns.Add("prodRef");
            notifiedProducts.Columns.Add("prodName");
            notifiedProducts.Columns.Add("prodPrice");
            notifiedProducts.Columns.Add("prodQnt");
            notifiedProducts.Columns.Add("prodLimit");
  //          page = 0;
            selectedId = "";
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void produits_Load(object sender, EventArgs e)
        {
            Annule.Hide();
            AppliquerModifs.Hide();
            prodQntMang.Hide();
            backPanel.Hide();
            QntInStock.Enabled = false;
            
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (productsGridView.Rows.Count == 0)
            {
                MsBox message = new MsBox("Aucun élement selectioné", AlertType.info);
                message.ShowDialog();
                return;
            }
            Annule.Show();
            AppliquerModifs.Show();
            prodQntMang.Show();
            generateRef.Enabled = false;
            referenceTxtBox.Enabled = false;
            int selectedRow = productsGridView.CurrentCell.RowIndex;
            selectedId = productsGridView.Rows[selectedRow].Cells[0].Value.ToString();
            prodName.Text = productsGridView.Rows[selectedRow].Cells[1].Value.ToString();
            referenceTxtBox.Text = selectedId;
            priceTxtBox.Text = productsGridView.Rows[selectedRow].Cells[2].Value.ToString();
            QntInStock.Text = productsGridView.Rows[selectedRow].Cells[3].Value.ToString() ;
            notifLimitQnt.Text = productsGridView.Rows[selectedRow].Cells[4].Value.ToString(); ;
        }

        private void Annule_Click(object sender, EventArgs e)
        {
            Annule.Hide();
            AppliquerModifs.Hide();
            prodQntMang.Hide();
            referenceTxtBox.Enabled = true;
            generateRef.Enabled = true;
            clearFields();
        }

        private void Annule_MouseHover(object sender, EventArgs e)
        {
            Annule.ForeColor = Color.FromArgb(244, 67, 54);
        }

        private void Annule_MouseLeave(object sender, EventArgs e)
        {
            Annule.ForeColor = Color.FromArgb(128, 128, 128);
        }

        private void searchTxtBox_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void searchTxtBox_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void searchTxtBox_Enter(object sender, EventArgs e)
        {
            if (searchTxtBox.Text == "abcd....") searchTxtBox.Text = "";
        }

        private void searchTxtBox_Leave(object sender, EventArgs e)
        {
            if (searchTxtBox.Text == "") searchTxtBox.Text = "abcd....";
        }

        private async void ADDBtn_Click(object sender, EventArgs e)
        {
            double price = 0;
            double buyPrice = 0;
            int stockQuant = 0;
            int notifLimitQuantity = 0;
            try
            {
                price = Convert.ToDouble(priceTxtBox.Text.Replace('.',','));
                //buyPrice= Convert.ToDouble(buyPriceTxtBox.Text.Replace('.', ','));
                stockQuant = Convert.ToInt32(StockQnt.Text);
                notifLimitQuantity = Convert.ToInt32(notifLimitQnt.Text);
                
            }
            catch
            {
                MsBox message = new MsBox("Vérifier les données entrées", AlertType.error);
                message.ShowDialog();
                return;
            }
            ProductsService service = new ProductsService();
            bool result = await service.createNewProduct(referenceTxtBox.Text,prodName.Text.Replace("'","`"),price, stockQuant, notifLimitQuantity,buyPrice,CommonInfo.currentUserID);
            if (result)
            {
                MsBox message = new MsBox("Produit ajouté avec succés", AlertType.success);
                message.ShowDialog();
                clearFields();
                backBtn_Click(sender, e);
            }
            else
            {
                MsBox message = new MsBox("Réference existe déjà", AlertType.error);
                message.ShowDialog();
            }
            

        }

        private String generateProductRefrence()
        {
            String cid = "P" + DateTime.Now.Year + "/" + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour +
                DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond;
            return cid;
        }

        private void generateRef_Click(object sender, EventArgs e)
        {
            referenceTxtBox.Text = generateProductRefrence();
        }

        private void AddQnt_Click(object sender, EventArgs e)
        {
            try
            {
                int stockedQuantity = Convert.ToInt32(QntInStock.Text);
                int mangedQuantity = Convert.ToInt32(addMinQnt.Text);
                int newQuantity = stockedQuantity + mangedQuantity; 
                QntInStock.Text = newQuantity.ToString();
                addMinQnt.Text = "0";
            }
            catch
            {
                MsBox message = new MsBox("Vérifier les données entrées", AlertType.error);
                message.ShowDialog();
            }
        }

        private void removeQnt_Click(object sender, EventArgs e)
        {
            try
            {
                int stockedQuantity = Convert.ToInt32(QntInStock.Text);
                int mangedQuantity = Convert.ToInt32(addMinQnt.Text);
                int newQuantity = stockedQuantity - mangedQuantity;
                if (newQuantity < 0)
                {
                    MsBox message = new MsBox(String.Format("{0} est invalide", newQuantity), AlertType.error);
                    message.ShowDialog();
                    return;
                }
                QntInStock.Text = newQuantity.ToString();
                addMinQnt.Text = "0";
            }
            catch
            {
                MsBox message = new MsBox("Vérifier les données entrées", AlertType.error);
                message.ShowDialog();
            }
        }

        private void prodQntMang_Paint(object sender, PaintEventArgs e)
        {

        }

        public async void getAllProducts()
        {
            ProductsService service = new ProductsService();
            DataTable result = await service.getAllProducts();
            showDataInGridView(result);            
        }

        private void getDecreasedProducts()
        {
            productsGridView.Rows.Clear();
            for (int i = 0; i < notifiedProducts.Rows.Count; i++)
            {
                int newRow = productsGridView.Rows.Add();
                productsGridView.Rows[newRow].Cells[0].Value = notifiedProducts.Rows[i][0];
                productsGridView.Rows[newRow].Cells[1].Value = notifiedProducts.Rows[i][1];
                productsGridView.Rows[newRow].Cells[2].Value = notifiedProducts.Rows[i][2];
                productsGridView.Rows[newRow].Cells[3].Value = notifiedProducts.Rows[i][3];
                productsGridView.Rows[newRow].Cells[4].Value = notifiedProducts.Rows[i][4];
            }
            }

        private void notificationBtn_Click(object sender, EventArgs e)
        {
            if (isNotification)
            {
                getDecreasedProducts();
                backPanel.Show();
                //page = 1;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            backPanel.Hide();
            getAllProducts();
            //page = 0;
        }

        private async void SuppBtn_Click(object sender, EventArgs e)
        {
            if (productsGridView.Rows.Count == 0)
            {
                MsBox message = new MsBox("Aucun élement selectioné", AlertType.info);
                message.ShowDialog();
                return;
            }
            int selectedRow = productsGridView.CurrentCell.RowIndex;
            selectedId = productsGridView.Rows[selectedRow].Cells[0].Value.ToString();
            ProductsService service = new ProductsService();
            bool result = await service.deleteCProduct(selectedId, CommonInfo.currentUserID);
            if (result)
            {
                MsBox message = new MsBox("Produit supprimé", AlertType.success);
                message.ShowDialog();
                backBtn_Click(sender,e);
                
            }
        }

        private void clearFields()
        {
            prodName.Text = "";
            referenceTxtBox.Text = "";
            priceTxtBox.Text = "";
            StockQnt.Text = "";
            notifLimitQnt.Text = "";

        }

        private async void AppliquerModifs_Click(object sender, EventArgs e)
        {
            double price = 0;
            double buyPrice = 0;
            int stockQuant = 0;
            int notifLimitQuantity = 0;
            try
            {
                price = Convert.ToDouble(priceTxtBox.Text.Replace('.', ','));
                //buyPrice = Convert.ToDouble(buyPriceTxtBox.Text.Replace('.', ','));
                stockQuant = Convert.ToInt32(QntInStock.Text);
                notifLimitQuantity = Convert.ToInt32(notifLimitQnt.Text);

            }
            catch
            {
                MsBox message = new MsBox("Vérifier les données entrées", AlertType.error);
                message.ShowDialog();
                return;
            }

            ProductsService service = new ProductsService();
            bool result = await service.updateProduct(referenceTxtBox.Text, prodName.Text.Replace("'", "`"),
                          price, stockQuant, notifLimitQuantity, buyPrice, CommonInfo.currentUserID);            
            if (result)
            {
                MsBox message = new MsBox("Produit modifié", AlertType.success);
                message.ShowDialog();
                backBtn_Click(sender, e);
                Annule_Click(sender, e);
            }
        }

        private void searchTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            if (searchTxtBox.Text == "abcd....") return;
            backBtn_Click(sender, e);
            searchedProducts(searchTxtBox.Text.Replace("'", "`"));
        }

        async void searchedProducts(String searchedItem)
        {
            ProductsService service = new ProductsService();
            DataTable result = await service.getSearchedProducts(searchedItem);
            showDataInGridView(result); 
        }

        private void showDataInGridView(DataTable result)
        {
            isNotification = false;
            notifiedProducts.Rows.Clear();
            if (result == null) return;
            productsGridView.Rows.Clear();
            for (int i = 0; i < result.Rows.Count; i++)
            {
                int newRow = productsGridView.Rows.Add();
                productsGridView.Rows[newRow].Cells[0].Value = result.Rows[i][0];
                productsGridView.Rows[newRow].Cells[1].Value = result.Rows[i][1];
                productsGridView.Rows[newRow].Cells[2].Value = result.Rows[i][2];
                productsGridView.Rows[newRow].Cells[3].Value = result.Rows[i][3];
                productsGridView.Rows[newRow].Cells[4].Value = result.Rows[i][4];
                int qnt = Convert.ToInt32(productsGridView.Rows[newRow].Cells[3].Value);
                int limit = Convert.ToInt32(productsGridView.Rows[newRow].Cells[4].Value);
                if (qnt <= limit)
                {
                    isNotification = true;
                    DataRow item = notifiedProducts.NewRow();
                    item["prodRef"] = result.Rows[i][0];
                    item["prodName"] = result.Rows[i][1];
                    item["prodPrice"] = result.Rows[i][2];
                    item["prodQnt"] = result.Rows[i][3];
                    item["prodLimit"] = result.Rows[i][4];

                    notifiedProducts.Rows.Add(item);

                    double taux = (qnt * 100) / limit;
                    if (taux <= 100 && taux >= 65)
                        productsGridView.Rows[newRow].DefaultCellStyle.BackColor = Color.FromArgb(234, 171, 6);
                    else if (taux < 65 && taux > 25)
                        productsGridView.Rows[newRow].DefaultCellStyle.BackColor = Color.FromArgb(225, 118, 33);
                    else productsGridView.Rows[newRow].DefaultCellStyle.BackColor = Color.FromArgb(216, 68, 60);
                }
            }
            if (isNotification) notificationBtn.Image = Image.FromFile(@"Images\statusDown.png");
            else notificationBtn.Image = Image.FromFile(@"Images\statusNeutral.png");
        }
    } 
}
