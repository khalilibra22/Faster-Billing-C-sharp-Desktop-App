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

namespace Facturation.Controls.Auth
{
    public partial class Signin : UserControl
    {
        UserService service;

        public Signin()
        {
            InitializeComponent();
            service = new UserService();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void lollipopToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (lollipopToggle1.Checked == true) passwordBox.isPassword = false;
            else passwordBox.isPassword = true;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            bool result = await service.login(nomUtilisateurBox.Text, passwordBox.Text);
            if (result)
            {
                //dashboard home = new dashboard();
                //home.Show();
            }
                
            else MessageBox.Show("error ! ");
        }

        private void Signin_Load(object sender, EventArgs e)
        {

        }
    }
}
