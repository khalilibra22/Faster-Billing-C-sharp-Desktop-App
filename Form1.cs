using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturation.Service;
using Facturation.Config;

namespace Facturation
{
    public partial class Form1 : Form
    {
        UserService service;

        public Form1()
        {
            InitializeComponent();
            service = new UserService();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signin1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lollipopToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (lollipopToggle1.Checked == true) passwordBox.isPassword = false;
            else passwordBox.isPassword = true;
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            if (!inputsValidation()) return; ;
            bool result = await service.login(nomUtilisateurBox.Text.Replace("'", "`"), passwordBox.Text.Replace("'", "`"));
            if (result)
            {
                CommonInfo.currentUserID = nomUtilisateurBox.Text;
                getUserinfo();
                ConfigPanel home = new ConfigPanel();
                home.Show();
                this.Hide();
            }

            else
            {
                MsBox message = new MsBox("username ou mot de passe érronés !!", AlertType.error);
                message.ShowDialog();
            }
        }

        private async void getUserinfo()
        {
            UserService service = new UserService();
            DataTable result = await service.getUserInfo(CommonInfo.currentUserID);
            if (result == null) return;
            CommonInfo.isSupervisor = Convert.ToBoolean( result.Rows[0][2]);
            CommonInfo.lastLogin = Convert.ToDateTime( result.Rows[0][3]);
        }
        
        private bool inputsValidation()
        {
            if (nomUtilisateurBox.Text == "" || passwordBox.Text == "" )
            {
                MsBox message = new MsBox("Il y a des informations manquantes", AlertType.error);
                message.ShowDialog();

                return false;
            }
            return true;
        } 

        
    }
}
