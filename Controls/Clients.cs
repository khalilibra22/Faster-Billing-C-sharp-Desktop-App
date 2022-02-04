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

namespace Facturation.Controls
{
    public partial class Clients : UserControl
    {
        String selectedId;
        public Clients()
        {
            InitializeComponent();
            selectedId = "";
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            Annule.Hide();
            AppliquerModifs.Hide();
            panelOfPayement.Hide();
            
        }

        private void Annule_MouseHover(object sender, EventArgs e)
        {
            Annule.ForeColor = Color.FromArgb(244, 67, 54);
        }

        private void Annule_MouseLeave(object sender, EventArgs e)
        {
            Annule.ForeColor = Color.FromArgb(128, 128, 128);
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (clientsGridView.Rows.Count == 0)
            {
                MsBox message = new MsBox("Aucun élement selectioné", AlertType.info);
                message.ShowDialog();
                return;
            }
            Annule.Show();
            AppliquerModifs.Show();
            int selectedRow = clientsGridView.CurrentCell.RowIndex;
            selectedId = clientsGridView.Rows[selectedRow].Cells[0].Value.ToString();
            NameBox.Text = clientsGridView.Rows[selectedRow].Cells[1].Value.ToString();
            string[] fullAddress = clientsGridView.Rows[selectedRow].Cells[2].Value.ToString().Split(';');
            addressBox.Text = fullAddress[0];
            wilayaBox.Text = fullAddress[1];
            phoneBox.Text = clientsGridView.Rows[selectedRow].Cells[3].Value.ToString();
            emailBox.Text = clientsGridView.Rows[selectedRow].Cells[4].Value.ToString();
        }

        private void Annule_Click(object sender, EventArgs e)
        {
            Annule.Hide();
            AppliquerModifs.Hide();
            clearFields();
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
            if (!inputsValidation()) return;
            ClientsService service = new ClientsService();
            bool result = await service.createNewClient(generateClientId(),NameBox.Text.Replace("'", "`"),
                                 addressBox.Text.Replace("'", "`"), wilayaBox.Text.Replace("'", "`"), phoneBox.Text.Replace("'", "`"), emailBox.Text.Replace("'", "`"), CommonInfo.currentUserID);
            if (result)
            {
                clearFields();
                MsBox message = new MsBox("Client ajouté avec succés", AlertType.success);
                message.ShowDialog();
                getAllClients();
            }

        }

        public async void getAllClients()
        {
            ClientsService service = new ClientsService();
            DataTable result = await service.getAllClients();
            if (result == null) return;
            clientsGridView.Rows.Clear();
            for(int i = 0; i < result.Rows.Count; i++)
            {
                int newRow = clientsGridView.Rows.Add();
                clientsGridView.Rows[newRow].Cells[0].Value = result.Rows[i][0];
                clientsGridView.Rows[newRow].Cells[1].Value = result.Rows[i][1];
                clientsGridView.Rows[newRow].Cells[2].Value = result.Rows[i][2] + ";" + result.Rows[i][3];
                clientsGridView.Rows[newRow].Cells[3].Value = result.Rows[i][4];
                clientsGridView.Rows[newRow].Cells[4].Value = result.Rows[i][5];
                clientsGridView.Rows[newRow].Cells[5].Value = result.Rows[i][6];

            }
        }

        public async void searchedClients(String searchedItem)
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
                clientsGridView.Rows[newRow].Cells[2].Value = result.Rows[i][2] + ";" + result.Rows[i][3];
                clientsGridView.Rows[newRow].Cells[3].Value = result.Rows[i][4];
                clientsGridView.Rows[newRow].Cells[4].Value = result.Rows[i][5];
                clientsGridView.Rows[newRow].Cells[5].Value = result.Rows[i][6];

            }
        }
        


        private String generateClientId()
        {
            String cid = "C" + DateTime.Now.Year + "/"+ DateTime.Now.Month+ DateTime.Now.Day+ DateTime.Now.Hour+
                DateTime.Now.Minute+ DateTime.Now.Second+ DateTime.Now.Millisecond;
            return cid;
        }

        private async void  SuppBtn_Click(object sender, EventArgs e)
        {
            if(clientsGridView.Rows.Count == 0)
            {
                MsBox message = new MsBox("Aucun élement selectioné", AlertType.info);
                message.ShowDialog();
                return;
            }
            int selectedRow = clientsGridView.CurrentCell.RowIndex;
            selectedId = clientsGridView.Rows[selectedRow].Cells[0].Value.ToString();
            ClientsService service = new ClientsService();
            bool result = await service.deleteClient(selectedId, CommonInfo.currentUserID);
            if (result)
            {
                MsBox message = new MsBox("Client supprimé", AlertType.success);
                message.ShowDialog();
                getAllClients();
            }
        }
        private void clearFields()
        {
            NameBox.Text = "";
            addressBox.Text = "";
            wilayaBox.Text = "";
            phoneBox.Text = "";
            emailBox.Text = "";
        }

        private async void AppliquerModifs_Click(object sender, EventArgs e)
        {
            if (!inputsValidation()) return;
            ClientsService service = new ClientsService();
            bool result = await service.updateClient
                 (selectedId, NameBox.Text.Replace("'", "`"), addressBox.Text.Replace("'", "`"), wilayaBox.Text.Replace("'", "`"), phoneBox.Text.Replace("'", "`"), emailBox.Text.Replace("'", "`"), CommonInfo.currentUserID);
            if (result)
            {
                Annule_Click(sender, e);
                MsBox message = new MsBox("Client modifié", AlertType.success);
                message.ShowDialog();
                getAllClients();
            }
        }

        private void searchTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            if (searchTxtBox.Text == "abcd....") return;
            searchedClients(searchTxtBox.Text.Replace("'", "`"));
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.AddDays(-30).ToShortDateString());
        }
        
        private bool inputsValidation()
        {
            if(NameBox.Text == "")
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

        private void makePaymentBtn_Click(object sender, EventArgs e)
        {
            if (clientsGridView.Rows.Count == 0)
            {
                MsBox message = new MsBox("Aucun élement selectioné", AlertType.info);
                message.ShowDialog();
                return;
            }
            panelOfPayement.Show();
            int selectedRow = clientsGridView.CurrentCell.RowIndex;
            pyClientId.Text = clientsGridView.Rows[selectedRow].Cells[0].Value.ToString();
            pyClientName.Text = clientsGridView.Rows[selectedRow].Cells[1].Value.ToString();
            pyAmountBox.Text = clientsGridView.Rows[selectedRow].Cells[5].Value.ToString();
        }

        private void closeAll_Click(object sender, EventArgs e)
        {
            panelOfPayement.Hide();
            clearPaymentInfo();
        }

        private void clearPaymentInfo()
        {
            pyClientId.Text = "";
            pyClientName.Text = "";
            pyAmountBox.Text = "";
        }

        private async void doPaymentBtn_Click(object sender, EventArgs e)
        {
            double amount = 0;
            try
            {
                amount = Convert.ToDouble(pyAmountBox.Text.Replace('.',','));
            }
            catch
            {
                MsBox message = new MsBox("vérifier les données entrées", AlertType.error);
                message.ShowDialog();
            }
            double ancienAmount = await new ClientsService().getClientDette(pyClientId.Text);
            double newAmount = ancienAmount - amount;
            if (newAmount < 0)
            {
                MsBox message = new MsBox("La valeur est négatif !!", AlertType.error);
                message.ShowDialog();
                return;
            }
            bool result = await new ClientsService().makePayment(pyClientId.Text, amount);
            if (result)
            {
                bool setDette = await new ClientsService().updateClientDette(pyClientId.Text, newAmount);
                if (setDette)
                {
                    RecuPrint print = new RecuPrint();
                    CompanyInfo getCompanyAllInfo = new CompanyInfo();
                    print.OwnerInfoDataSet.ownerInfo.Rows.Clear();
                    bool companyAllInfoResult = await getCompanyAllInfo.getOwnerInfor2Repport(print.OwnerInfoDataSet.ownerInfo);

                    MsBox message = new MsBox("CHARGEMENT...", AlertType.success);
                    message.ShowDialog();
                    ReportParameter[] Prmt = new ReportParameter[] {
                new ReportParameter("currentUser",CommonInfo.currentUserID),
                new ReportParameter("clientName",pyClientName.Text),
                new ReportParameter("ancienAmount",ancienAmount.ToString()),
                new ReportParameter("amount",amount.ToString()),
                new ReportParameter("newAmount",newAmount.ToString()),
                new ReportParameter("clientId",pyClientId.Text)
            };
                    print.reportViewer1.LocalReport.SetParameters(Prmt);
                    print.reportViewer1.RefreshReport();
                    //print.reportViewer1.LocalReport.EnableExternalImages = true;
                    print.Show();
                }
            }
            clearPaymentInfo();
            panelOfPayement.Hide();
            getAllClients();
        }
    }
}
