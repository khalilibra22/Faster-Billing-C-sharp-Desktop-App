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
using LiveCharts.Defaults;
using LiveCharts;
using LiveCharts.Wpf;

namespace Facturation.Controls
{
    public partial class Statistiques : UserControl
    {
        public Statistiques()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Statistiques_Load(object sender, EventArgs e)
        {
            earningDateInit.Value = DateTime.Now.AddDays(-10);
            invoiceDateInit.Value = DateTime.Now.AddDays(-10);
            cartesianChart1.AxisX.Add(new Axis {
                Title = "Dernier Jours"
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Montant"
            });
            //cartesianChart1.LegendLocation = LegendLocation.Right;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuDatePicker1_ValueChanged(object sender, EventArgs e)
        {
            earningOfPeriod();
            spendingOfPeriod();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void loadStatistics()
        {
            earningOfLastDay();
            spendingOfLastDay();
            earningOfLastMonth();
            spendingOfLastMonth();
            earningOfPeriod();
            spendingOfPeriod();
            invoiceNumberOfLastDay();
            invoiceNumberOfPeriod();
            chartData();
        }

        private async void earningOfLastDay()
        {
            InvoicesService service = new InvoicesService();
            double last24HoursEarning = await service.getInvoicesPeriodEearning(
                DateTime.Now.ToString("MM/dd/yyyy"), DateTime.Now.ToString("MM/dd/yyyy"));
            if (last24HoursEarning == -1) return;
            earningDay.Text = last24HoursEarning.ToString() + " DZD";
        }

        private async void spendingOfLastDay()
        {
            InvoicesService service = new InvoicesService();
            double last24HoursEarning = await service.getInvoicesPeriodSpending(
                DateTime.Now.ToString("MM/dd/yyyy"), DateTime.Now.ToString("MM/dd/yyyy"));
            if (last24HoursEarning == -1) return;
            spendingDay.Text = last24HoursEarning.ToString() + " DZD";
        }

        private async void earningOfLastMonth()
        {
            InvoicesService service = new InvoicesService();
            double result = await service.getInvoicesPeriodEearning(
                DateTime.Now.AddDays(-30).ToString("MM/dd/yyyy"), DateTime.Now.ToString("MM/dd/yyyy"));
            if (result == -1) return;
            earningMonth.Text = result.ToString() + " DZD";
        }

        private async void spendingOfLastMonth()
        {
            InvoicesService service = new InvoicesService();
            double result = await service.getInvoicesPeriodSpending(
                DateTime.Now.AddDays(-30).ToString("MM/dd/yyyy"), DateTime.Now.ToString("MM/dd/yyyy"));
            if (result == -1) return;
            spendingMonth.Text = result.ToString() + " DZD";
        }

        private async void earningOfPeriod()
        {
            InvoicesService service = new InvoicesService();
            double result = await service.getInvoicesPeriodEearning(
                earningDateInit.Value.ToString("MM/dd/yyyy"), earningDateEnd.Value.ToString("MM/dd/yyyy"));
            if (result == -1) return;
            earningPeriod.Text = result.ToString() + " DZD";
        }

        private async void spendingOfPeriod()
        {
            InvoicesService service = new InvoicesService();
            double result = await service.getInvoicesPeriodSpending(
                earningDateInit.Value.ToString("MM/dd/yyyy"), earningDateEnd.Value.ToString("MM/dd/yyyy"));
            if (result == -1) return;
            spendingPeriod.Text = result.ToString() + " DZD";
        }

        private async void invoiceNumberOfLastDay()
        {
            InvoicesService service = new InvoicesService();
            int result = await service.getInvoicesPeriodNumber(
                DateTime.Now.ToString("MM/dd/yyyy"), DateTime.Now.ToString("MM/dd/yyyy"));
            if (result == -1) return;
            invoiceNbrDate.Text = result.ToString() + " Opérations";
        }

        private async void invoiceNumberOfPeriod()
        {
            InvoicesService service = new InvoicesService();
            int result = await service.getInvoicesPeriodNumber(
                invoiceDateInit.Value.ToString("MM/dd/yyyy"), invoiceDateEnd.Value.ToString("MM/dd/yyyy"));
            if (result == -1) return;
            invoiceNbrPeriod.Text = result.ToString();
        }

        private async void chartData()
        {
            InvoicesService service = new InvoicesService();
            DataTable result = await service.getInvoicesEearningPerDay(
                DateTime.Now.AddDays(1).ToString("MM/dd/yyyy"), DateTime.Now.AddDays(-30).ToString("MM/dd/yyyy"));
            InvoicesService serviceSpend = new InvoicesService();
            DataTable resultSpend = await serviceSpend.getInvoicesSpendingPerDay(
                DateTime.Now.AddDays(1).ToString("MM/dd/yyyy"), DateTime.Now.AddDays(-30).ToString("MM/dd/yyyy"));
            if (result == null || resultSpend == null) return;
            cartesianChart1.Series.Clear();
            ChartValues<ObservablePoint> Cv = new ChartValues<ObservablePoint>();
            for (int i = 0; i <result.Rows.Count; i++)
            {
                Cv.Add(new ObservablePoint(i ,Convert.ToDouble(result.Rows[i][0])));
            }
            ChartValues<ObservablePoint> Cv2 = new ChartValues<ObservablePoint>();
            for (int j = 0; j <resultSpend.Rows.Count; j++)
            {
                double nwAmount = 0.0;
                try
                {
                    nwAmount = Convert.ToDouble(resultSpend.Rows[j][0]);
                }
                catch { }
                Cv2.Add(new ObservablePoint(j, nwAmount));
            }

            cartesianChart1.Series = new SeriesCollection { new LineSeries {Title = "Revenus", Values = Cv, PointGeometrySize = 6 }, new LineSeries { Title = "Dépenses", Values = Cv2, PointGeometrySize = 6 } };
            
        }

        private void earningDateInit_ValueChanged(object sender, EventArgs e)
        {
            earningOfPeriod();
            spendingOfPeriod();
            //MessageBox.Show(earningDateInit.Value.ToShortDateString());
        }

        private void invoiceDateInit_ValueChanged(object sender, EventArgs e)
        {
            invoiceNumberOfPeriod();
        }

        private void invoiceDateEnd_ValueChanged(object sender, EventArgs e)
        {
            invoiceNumberOfPeriod();
        }
    }
}
