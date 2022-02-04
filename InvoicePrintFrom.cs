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
    public partial class InvoicePrintFrom : Form
    {
        public InvoicePrintFrom()
        {
            InitializeComponent();
        }

        private void InvoicePrintFrom_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'OwnerInfoDataSet.ownerInfo'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.ownerInfoTableAdapter.Fill(this.OwnerInfoDataSet.ownerInfo);
            // TODO: cette ligne de code charge les données dans la table 'InvioceProductsDataSet.invoiceProdsDt'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.invoiceProdsDtTableAdapter.Fill(this.InvioceProductsDataSet.invoiceProdsDt);
            // TODO: cette ligne de code charge les données dans la table 'invoiceDataSet.invoiceDt'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.invoiceDtTableAdapter.Fill(this.invoiceDataSet.invoiceDt);
            // TODO: cette ligne de code charge les données dans la table 'OwnerInfoDataSet.ownerInfo'. Vous pouvez la déplacer ou la supprimer selon les besoins.




            //this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void closePrintFrom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimazeWindowBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
