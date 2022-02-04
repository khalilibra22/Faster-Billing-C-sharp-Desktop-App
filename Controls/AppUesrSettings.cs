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
using Facturation.Properties;
using Facturation.Config;
using System.Configuration;
using Microsoft.Reporting.WinForms;

namespace Facturation.Controls

{
    public partial class AppUesrSettings : UserControl
    {
        int isNewPassChecked;
        
        public AppUesrSettings()
        {
            InitializeComponent();
            isNewPassChecked = 0;
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox7_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Lisible1_CheckedChanged(object sender, EventArgs e)
        {
            if (Lisible1.Checked) userPW.isPassword = false;
            else userPW.isPassword = true;
        }

        private void lisible2_CheckedChanged(object sender, EventArgs e)
        {
            if (lisible2.Checked) newPW.isPassword = false;
            else newPW.isPassword = true;
        }

        private async void NewCompteBtn_Click(object sender, EventArgs e)
        {
            if(newUsername.Text=="" || newPW.Text == "")
            {
                MsBox message = new MsBox("Champs vides !!", AlertType.error);
                message.ShowDialog();
                return;
            }


            if (SuperVRadio.Checked) isNewPassChecked = 1;
            else isNewPassChecked = 0;

            UserService service  = new UserService();
            bool result = await service.createNewUser(newUsername.Text.Replace("'", "`"), newPW.Text.Replace("'", "`"), isNewPassChecked,DateTime.Now);
            if (result) {
                MsBox message = new MsBox("Compte créé avec succés", AlertType.success);
                message.ShowDialog();
                newUsername.Text = "";
                newPW.Text = "";
            }
            else
            {
                MsBox message = new MsBox("Changer le nom d'utilisateur svp", AlertType.error);
                message.ShowDialog();
            }
        }

        private async void SaveBtn_Click(object sender, EventArgs e)
        {
            UserService service = new UserService();
            bool result = await service.updatePassword(userPW.Text.Replace("'", "`"), userNUBox.Text.Replace("'", "`"));
            if (result)
            {
                MsBox message = new MsBox("Changements éffetuées", AlertType.success);
                message.ShowDialog();
            }
            

        }

        private async void saveCompanyInfo_Click(object sender, EventArgs e)
        {
            CompanyInfo service = new CompanyInfo();
            bool result = await service.updateInfo(comapnyNameBox.Text.Replace("'", "`"), CompanyActivityBox.Text.Replace("'", "`")
                , CompanyAddressBox.Text.Replace("'", "`"), companyWilayaBox.Text.Replace("'", "`"), CompanyPhoneBox.Text.Replace("'", "`")
                , companyEmailBox.Text.Replace("'", "`"), companyNRC.Text.Replace("'", "`"), companyFiscalId.Text.Replace("'", "`"), companyBankInfo.Text.Replace("'", "`"),nisNumber.Text.Replace("'", "`"), articleNumber.Text.Replace("'", "`"));
            if (result)
            {
                MsBox message = new MsBox("Changements éffetuées", AlertType.success);
                message.ShowDialog();
            }

        }

        private void AppSettings_Load(object sender, EventArgs e)
        {
            //loadCompanyInfo();
            //getUserInfo();
        }

        public async void loadCompanyInfo()
        {
            CompanyInfo service = new CompanyInfo();
            DataTable result = await service.getOwnerInformation();

            if (result == null) return;
            comapnyNameBox.Text = result.Rows[0][1].ToString();
            CompanyActivityBox.Text = result.Rows[0][2].ToString(); 
            CompanyAddressBox.Text = result.Rows[0][3].ToString();
            companyWilayaBox.Text = result.Rows[0][4].ToString();
            CompanyPhoneBox.Text = result.Rows[0][5].ToString();
            companyEmailBox.Text = result.Rows[0][6].ToString();
            companyNRC.Text = result.Rows[0][7].ToString();
            companyFiscalId.Text = result.Rows[0][8].ToString() ;
            companyBankInfo.Text = result.Rows[0][9].ToString();
            articleNumber.Text = result.Rows[0][11].ToString();
            nisNumber.Text = result.Rows[0][10].ToString();

        }

        public async void getUserInfo()
        {
            UserService service = new UserService();
            DataTable result = await service.getUserInfo(CommonInfo.currentUserID);
            if (result == null) return;
            userNUBox.Text = result.Rows[0][0].ToString();
            userPW.Text = result.Rows[0][1].ToString();

        }

        private async void generalReportBtn_Click(object sender, EventArgs e)
        {

            PrintGeneralReport print = new PrintGeneralReport();

            CompanyInfo getCompanyAllInfo = new CompanyInfo();
            print.OwnerInfoDataSet.ownerInfo.Rows.Clear();
            bool companyAllInfoResult = await getCompanyAllInfo.getOwnerInfor2Repport(print.OwnerInfoDataSet.ownerInfo);
                        
            SuppliersService getDette = new SuppliersService();
            print.DetteDataSet.DetteDt.Rows.Clear();
            bool dette = await getDette.getAllDette(print.DetteDataSet.DetteDt);

            print.CaisseDataSet.CaisseDt.Rows.Clear();
            bool allDette = await new SuppliersService().getAllDettePerSupplier(print.CaisseDataSet.CaisseDt);

            print.AllBuyingDataSet.ClientDt.Rows.Clear();
            bool allClientDette = await new ClientsService().getAllDettePerClient(print.AllBuyingDataSet.ClientDt);

            MsBox message = new MsBox("CHARGEMENT...", AlertType.success);
            message.ShowDialog();

            ReportParameter[] Prmt = new ReportParameter[] {
                            new ReportParameter("currentUser",CommonInfo.currentUserID)                           
                        };

            print.reportViewer1.LocalReport.SetParameters(Prmt);
            print.reportViewer1.RefreshReport();
            print.Show();
        }
    }
}
