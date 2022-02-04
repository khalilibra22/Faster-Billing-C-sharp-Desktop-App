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
    public partial class Suppliers : UserControl
    {
        String selectedId;
        public Suppliers()
        {
            InitializeComponent();
            selectedId = "";
        }

        private void Annule_Click(object sender, EventArgs e)
        {
            Annule.Hide();
            AppliquerModifs.Hide();
            clearFields();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if  (suppliersGridView.Rows.Count == 0)
            {
                MsBox message = new MsBox("Aucun élement selectioné", AlertType.info);
                message.ShowDialog();
                return;
            }
            Annule.Show();
            AppliquerModifs.Show();
            int selectedRow = suppliersGridView.CurrentCell.RowIndex;
            selectedId = suppliersGridView.Rows[selectedRow].Cells[0].Value.ToString();
            NameBox.Text = suppliersGridView.Rows[selectedRow].Cells[1].Value.ToString();
            string[] fullAddress = suppliersGridView.Rows[selectedRow].Cells[2].Value.ToString().Split(';');
            addressBox.Text = fullAddress[0];
            wilayaBox.Text = fullAddress[1];
            phoneBox.Text = suppliersGridView.Rows[selectedRow].Cells[3].Value.ToString();
            emailBox.Text = suppliersGridView.Rows[selectedRow].Cells[4].Value.ToString();
        }

        private async void ADDBtn_Click(object sender, EventArgs e)
        {
            if (!inputsValidation()) return;
            SuppliersService service = new SuppliersService();
            bool result = await service.createNewSupplier(generateSupplierId(), NameBox.Text.Replace("'", "`"),
                                 addressBox.Text.Replace("'", "`"), wilayaBox.Text.Replace("'", "`"), phoneBox.Text.Replace("'", "`"), emailBox.Text.Replace("'", "`"));
            if (result)
            {
                clearFields();
                MsBox message = new MsBox("Fournisseur ajouté avec succés", AlertType.success);
                message.ShowDialog();
                getAllSuppliers();
            }
        }

        private String generateSupplierId()
        {
            String cid = "S" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour +
                DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond;
            return cid;
        }

        private void clearFields()
        {
            NameBox.Text = "";
            addressBox.Text = "";
            wilayaBox.Text = "";
            phoneBox.Text = "";
            emailBox.Text = "";
        }

        private bool inputsValidation()
        {
            if (NameBox.Text == "")
            {
                new MsBox("Ajouter le nom de client", AlertType.error).ShowDialog();
                return false;
            }

            if (addressBox.Text == "")
            {
                new MsBox("Ajouter l'adresse de client", AlertType.error).ShowDialog();
                return false;
            }

            if (wilayaBox.Text == "")
            {
                new MsBox("Ajouter la Wilaya/Commune de client", AlertType.error).ShowDialog();
                return false;
            }
            return true;
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            Annule.Hide();
            AppliquerModifs.Hide();
            panelOfPayement.Hide();
        }

        public async void getAllSuppliers()
        {
            SuppliersService service = new SuppliersService();
            DataTable result = await service.getAllSuppliers();
            if (result == null) return;
            suppliersGridView.Rows.Clear();
            for (int i = 0; i < result.Rows.Count; i++)
            {
                int newRow = suppliersGridView.Rows.Add();
                suppliersGridView.Rows[newRow].Cells[0].Value = result.Rows[i][0];
                suppliersGridView.Rows[newRow].Cells[1].Value = result.Rows[i][1];
                suppliersGridView.Rows[newRow].Cells[2].Value = result.Rows[i][2] + ";" + result.Rows[i][3];
                suppliersGridView.Rows[newRow].Cells[3].Value = result.Rows[i][4];
                suppliersGridView.Rows[newRow].Cells[4].Value = result.Rows[i][5];
                suppliersGridView.Rows[newRow].Cells[5].Value = result.Rows[i][6];

            }
        }

        private async void SuppBtn_Click(object sender, EventArgs e)
        {
            if (suppliersGridView.Rows.Count == 0)
            {
                MsBox message = new MsBox("Aucun élement selectioné", AlertType.info);
                message.ShowDialog();
                return;
            }
            int selectedRow = suppliersGridView.CurrentCell.RowIndex;
            selectedId = suppliersGridView.Rows[selectedRow].Cells[0].Value.ToString();
            SuppliersService service = new SuppliersService();
            bool result = await service.deleteSupplier(selectedId);
            if (result)
            {
                MsBox message = new MsBox("Fournisseur supprimé", AlertType.success);
                message.ShowDialog();
                getAllSuppliers();
            }
        }

        private async void AppliquerModifs_Click(object sender, EventArgs e)
        {
            if (!inputsValidation()) return;
            SuppliersService service = new SuppliersService();
            bool result = await service.updateSupplier
                 (selectedId, NameBox.Text.Replace("'", "`"), addressBox.Text.Replace("'", "`"), wilayaBox.Text.Replace("'", "`"), phoneBox.Text.Replace("'", "`"), emailBox.Text.Replace("'", "`"));
            if (result)
            {
                Annule_Click(sender, e);
                
                MsBox message = new MsBox("Fournisseur modifié", AlertType.success);
                message.ShowDialog();
                getAllSuppliers();
            }
        }

        private void searchTxtBox_Enter(object sender, EventArgs e)
        {
            if (searchTxtBox.Text == "abcd....") searchTxtBox.Text = "";
        }

        private void searchTxtBox_Leave(object sender, EventArgs e)
        {
            if (searchTxtBox.Text == "") searchTxtBox.Text = "abcd....";

        }

        private void searchTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            if (searchTxtBox.Text == "abcd....") return;
            searchedProducts(searchTxtBox.Text);

        }

        private async void searchedProducts(String searchedItem)
        {
            SuppliersService service = new SuppliersService();
            DataTable result = await service.getSearchedSuppliers(searchedItem.Replace("'", "`"));
            suppliersGridView.Rows.Clear();
            for (int i = 0; i < result.Rows.Count; i++)
            {
                int newRow = suppliersGridView.Rows.Add();
                suppliersGridView.Rows[newRow].Cells[0].Value = result.Rows[i][0];
                suppliersGridView.Rows[newRow].Cells[1].Value = result.Rows[i][1];
                suppliersGridView.Rows[newRow].Cells[2].Value = result.Rows[i][2] + ";" + result.Rows[i][3];
                suppliersGridView.Rows[newRow].Cells[3].Value = result.Rows[i][4];
                suppliersGridView.Rows[newRow].Cells[4].Value = result.Rows[i][5];
                suppliersGridView.Rows[newRow].Cells[5].Value = result.Rows[i][6];

            }
        }

        private void closeAll_Click(object sender, EventArgs e)
        {
            panelOfPayement.Hide();
        }

        private void makePaymentBtn_Click(object sender, EventArgs e)
        {
            if (suppliersGridView.Rows.Count == 0)
            {
                MsBox message = new MsBox("Aucun élement selectioné", AlertType.info);
                message.ShowDialog();
                return;
            }
            panelOfPayement.Show();
            int selectedRow = suppliersGridView.CurrentCell.RowIndex;
            pyClientId.Text = suppliersGridView.Rows[selectedRow].Cells[0].Value.ToString();
            pyClientName.Text = suppliersGridView.Rows[selectedRow].Cells[1].Value.ToString();
            pyAmountBox.Text = suppliersGridView.Rows[selectedRow].Cells[5].Value.ToString();
        }

        private async void doPaymentBtn_Click(object sender, EventArgs e)
        {
            double amountsTotal = 0.0;
            try
            {
                amountsTotal = Convert.ToDouble(pyAmountBox.Text.Replace('.', ','));
            }
            catch
            {
                MsBox message = new MsBox("Vérifier les données entrées", AlertType.error);
                message.ShowDialog();
                return;
            }
            double supplierDette = await new SuppliersService().getSupplierDette(pyClientId.Text) ;
            if (supplierDette == -1) return;
            supplierDette -= amountsTotal;
            if (supplierDette < 0)
            {
                MsBox message = new MsBox("La valeur est négatif !!", AlertType.error);
                message.ShowDialog();
                return;
            }
            bool updateDette = await new SuppliersService().updateSuppliertDette(pyClientId.Text, supplierDette);
            if (updateDette)
            {
                bool result = await new SuppliersService().makeOutPayment(pyClientId.Text, amountsTotal);
                MsBox message = new MsBox("Vérssement éffectué", AlertType.success);
                message.ShowDialog();
                getAllSuppliers();
                pyClientId.Text = "";
                pyClientName.Text = "";
                pyAmountBox.Text = "";
                panelOfPayement.Hide();

            }
        }

    }
}
