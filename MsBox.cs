using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturation
{
    public partial class MsBox : Form
    {
        public MsBox(String Msg, AlertType Type)
        {
            InitializeComponent();
            switch (Type)
            {
                case AlertType.success:
                    Titre.Text = "Succès";
                    AlertImage.Image = Image.FromFile(@"Images\Success.png");
                    Fermer.Image = Image.FromFile(@"Images\CloseSuccess.png");
                    Titre.ForeColor = Color.FromArgb(26, 161, 95);
                    MsgTxt.ForeColor = Color.FromArgb(26, 161, 95);

                    // ChangeColor(Color.FromArgb(50, 116, 53));
                    break;
                case AlertType.error:
                    Titre.Text = "Erreur";
                    AlertImage.Image = Image.FromFile(@"Images\Error.png");
                    Fermer.Image = Image.FromFile(@"Images\CloseError.png");
                    Titre.ForeColor = Color.FromArgb(220, 77, 65);
                    MsgTxt.ForeColor = Color.FromArgb(220, 77, 65);
                    //ChangeColor(Color.FromArgb(134, 6, 0));
                    break;
                case AlertType.info:
                    Titre.Text = "Information";
                    AlertImage.Image = Image.FromFile(@"Images\Info.png");
                    Fermer.Image = Image.FromFile(@"Images\CloseInfo.png");
                    Titre.ForeColor = Color.FromArgb(39, 99, 180);
                    MsgTxt.ForeColor = Color.FromArgb(39, 99, 180);
                    //ChangeColor(Color.FromArgb(1, 76, 131));
                    break;
            }
            MsgTxt.Text = Msg;
        }

        private void MsBox_Load(object sender, EventArgs e)
        {

            timer1.Start();
            int screenHeight=  Screen.PrimaryScreen.Bounds.Height;
            this.Top = screenHeight - 150;
            this.Left = 50;

        }

        private void Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

public enum AlertType
{
    success, error, info
}
