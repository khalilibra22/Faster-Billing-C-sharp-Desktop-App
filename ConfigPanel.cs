using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturation.Config;
using Facturation.Service;


namespace Facturation
{
    public partial class ConfigPanel : Form
    {
        public ConfigPanel()
        {
            InitializeComponent();
        }

        private void ConfigPanel_Load(object sender, EventArgs e)
        {
            loadInfo();
            statistiques1.loadStatistics();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            statistiques1.loadStatistics();
            indicatorMenuBtn.Top = Home.Top;
            statistiques1.BringToFront();
            
            
        }

        private void invoiceBtn_Click(object sender, EventArgs e)
        {
            factures1.loadInvoice();
            indicatorMenuBtn.Top = invoiceBtn.Top;
            factures1.BringToFront();
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            produits1.getAllProducts();
            indicatorMenuBtn.Top = productsBtn.Top;
            produits1.BringToFront();
            
        }

        private void clientsBtn_Click(object sender, EventArgs e)
        {
            clients1.getAllClients();
            indicatorMenuBtn.Top = clientsBtn.Top;
            clients1.BringToFront();
            
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            //appUesrSettings1.loadCompanyInfo();
            //appUesrSettings1.getUserInfo();
            //indicatorMenuBtn.Top = settingsBtn.Top;
            //appUesrSettings1.BringToFront();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Deconnexion_Click(sender, e);
        }

        private void loadInfo()
        {
            UserNameTxt.Text = CommonInfo.currentUserID.ToUpper();
            int userTxtX = (profilImg.Location.X + profilImg.Width / 2) - UserNameTxt.Width / 2;
            UserNameTxt.Location = new Point(userTxtX, UserNameTxt.Location.Y);
            if (CommonInfo.isSupervisor) RoleTxt.Text = "Superviseur";
            else
            {
                RoleTxt.Text = "Administrateur";
                settingsBtn.Hide();
                appUesrSettings1.Hide();
            }
            LastLoginTxt.Text = CommonInfo.lastLogin.ToShortDateString();
        }

        private async void Deconnexion_Click(object sender, EventArgs e)
        {
            UserService service = new UserService();
            bool result = await service.updateLastlogin(DateTime.Now, CommonInfo.currentUserID);
           if(result)
            {
                MsBox message = new MsBox("Déconnexion en cours...", AlertType.success);
                message.ShowDialog();
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.messenger.com");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com");
        }

        private void settingsBtn_Click_1(object sender, EventArgs e)
        {
            appUesrSettings1.loadCompanyInfo();
            appUesrSettings1.getUserInfo();
            //indicatorMenuBtn.Top = settingsBtn.Top;
            appUesrSettings1.BringToFront();
        }

        private void buyingBtn_Click(object sender, EventArgs e)
        {
            buying1.loadInvoice();
            indicatorMenuBtn.Top = buyingBtn.Top;
            buying1.BringToFront();
        }

        private void supplierBtn_Click(object sender, EventArgs e)
        {
            suppliers1.getAllSuppliers();
            indicatorMenuBtn.Top = supplierBtn.Top;
            suppliers1.BringToFront();

        }

        private void sellPointBtn_Click(object sender, EventArgs e)
        {
            deplacements1.getAllDeplacements();
            deplacements1.getAllProducts();
            indicatorMenuBtn.Top = sellPointBtn.Top;
            deplacements1.BringToFront();
        }
    }
}
