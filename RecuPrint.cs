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
    public partial class RecuPrint : Form
    {
        public RecuPrint()
        {
            InitializeComponent();
        }

        private void closePrintFrom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimazeWindowBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void RecuPrint_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'OwnerInfoDataSet.ownerInfo'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.ownerInfoTableAdapter.Fill(this.OwnerInfoDataSet.ownerInfo);

        }
    }
}
