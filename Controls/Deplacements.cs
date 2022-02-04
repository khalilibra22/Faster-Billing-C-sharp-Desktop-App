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

namespace Facturation.Controls
{
    public partial class Deplacements : UserControl
    {
        int stockedQnt;
        String productRef;
        String deplacementId;
        public Deplacements()
        {
            InitializeComponent();
            stockedQnt = 0;
            productRef = "";
            deplacementId = "";
        }

        private async void SaveBtn_Click(object sender, EventArgs e)
        {
            if (deplcNameBox.Text == "" || deplcAddressBox.Text == "" || dplcPhoneBox.Text == "")
            {
                new MsBox("Etrer tout les informations SVP",AlertType.error).ShowDialog();
                return;
            }
            DeplacementService service = new DeplacementService();
            bool result = await service.createNewDeplacement(generateId(), deplcNameBox.Text.Replace("'", "`"),
                                 dplcPhoneBox.Text.Replace("'", "`"), deplcAddressBox.Text.Replace("'", "`"));
            if (result)
            {
                //clearFields();
                deplcNameBox.Text = "";
                deplcAddressBox.Text = "";
                dplcPhoneBox.Text = "";

                MsBox message = new MsBox("Déplacement ajouté avec succés", AlertType.success);
                message.ShowDialog();
                getAllDeplacements();
            }
        }

        public async void getAllDeplacements()
        {
            DeplacementService service = new DeplacementService();
            DataTable result = await service.getAllDeplacements();
            if (result == null) return;
            dplcGridView.Rows.Clear();
            for (int i = 0; i < result.Rows.Count; i++)
            {
                int newRow = dplcGridView.Rows.Add();
                dplcGridView.Rows[newRow].Cells[0].Value = result.Rows[i][0];
                dplcGridView.Rows[newRow].Cells[1].Value = result.Rows[i][1];
                dplcGridView.Rows[newRow].Cells[2].Value = result.Rows[i][2];
                dplcGridView.Rows[newRow].Cells[3].Value = result.Rows[i][4];
                

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

        private String generateId()
        {
            String cid = "D" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour +
                DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond;
            return cid;
        }

        private void productsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dplcPrdRef.Text = "";
            dplcPrdQnt.Text = "";
            int selectedRow = productsGridView.CurrentCell.RowIndex;
            productRef = productsGridView.Rows[selectedRow].Cells[0].Value.ToString();
            dplcPrdRef.Text = productsGridView.Rows[selectedRow].Cells[1].Value.ToString();
            stockedQnt = Convert.ToInt32(productsGridView.Rows[selectedRow].Cells[2].Value);

        }

        private async void DeplaceProdBtn_Click(object sender, EventArgs e)
        {
            int addedQnt = 0;
            int newQnt = 0;
            if (dplcPrdRef.Text == "" || dplcPrd.Text == "")
            {
                MsBox message = new MsBox("Aucun élement selectioné", AlertType.info);
                message.ShowDialog();
                return;
            }
            try
            {
                 addedQnt = Convert.ToInt32(dplcPrdQnt.Text);
            }
            catch
            {
                MsBox message = new MsBox("Vérifier les données entrées !!", AlertType.error);
                message.ShowDialog();
                return;
            }
            newQnt = stockedQnt - addedQnt;
            if (newQnt < 0)
            {
                MsBox message = new MsBox("Quantité insuffisante !!", AlertType.error);
                message.ShowDialog();
                return;
            }

            bool result = await new DeplacementService().ProdDeplacement(deplacementId, productRef, addedQnt, DateTime.Now.ToString());
            if (result)
            {
                Dictionary<string, int> updateQuantity = new Dictionary<string, int>();
                updateQuantity.Add(dplcPrdRef.Text, newQnt);
                bool updateQnt = await new ProductsService().updateProductsQuantities(updateQuantity);
                if (updateQnt)
                {
                    MsBox message = new MsBox("Quantité déplacé", AlertType.success);
                    message.ShowDialog();
                    getAllProducts();
                    dplcPrdRef.Text = "";
                    dplcPrdQnt.Text = "";
                    dplcPrd.Text = "";

                }
               
            }

        }

        private void dplcGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int selectedRow = dplcGridView.CurrentCell.RowIndex;
            deplacementId = dplcGridView.Rows[selectedRow].Cells[0].Value.ToString();
            dplcPrd.Text = dplcGridView.Rows[selectedRow].Cells[1].Value.ToString();
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

        private void searchProductsBox_Enter(object sender, EventArgs e)
        {
            if (searchProductsBox.Text == "abcd....") searchProductsBox.Text = "";
        }

        private void searchProductsBox_Leave(object sender, EventArgs e)
        {
            if (searchProductsBox.Text == "") searchProductsBox.Text = "abcd....";
        }

        private void Deplacements_Load(object sender, EventArgs e)
        {
            allDeplacementPanel.Hide();
        }

        private void closeAll_Click(object sender, EventArgs e)
        {
            allDeplacementPanel.Hide();
        }

        private void AllDplcBtn_Click(object sender, EventArgs e)
        {
            allDeplacementPanel.Show();
            allProdDeplacement();
        }

        private async void allProdDeplacement()
        {
            DeplacementService service = new DeplacementService();
            DataTable result = await service.getAllProdDeplacements();
            if (result == null) return;
            alldplcGridView.Rows.Clear();
            for (int i = 0; i < result.Rows.Count; i++)
            {
                int newRow = alldplcGridView.Rows.Add();
                alldplcGridView.Rows[newRow].Cells[0].Value = result.Rows[i][0];
                alldplcGridView.Rows[newRow].Cells[1].Value = result.Rows[i][1];
                alldplcGridView.Rows[newRow].Cells[2].Value = result.Rows[i][2];
                alldplcGridView.Rows[newRow].Cells[3].Value = result.Rows[i][3];
                alldplcGridView.Rows[newRow].Cells[4].Value = result.Rows[i][4];
                alldplcGridView.Rows[newRow].Cells[5].Value = result.Rows[i][5];

            }
        }
    }
}
