using System.Linq;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db=new FinancialCrmDbEntities();
        int count = 0;
        

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            count++;
            if (count % 4 == 1) 
            {
                var elektrikFaturasi = db.Bills.Where(x => x.BillTitle == "Elektrik Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Elektrik Faturası";
                lblBillAmount.Text=elektrikFaturasi.ToString()+" ₺";
            }
            if (count % 4 == 2) 
            {
                var dogalgazFaturasi = db.Bills.Where(x => x.BillTitle == "Doğalgaz Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Doğalgaz Faturası";
                lblBillAmount.Text = dogalgazFaturasi.ToString() + " ₺";
            }
            if (count % 4 == 3) 
            {
               var suFaturasi=db.Bills.Where(x=>x.BillTitle=="Su Faturası").Select(y=>y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Su Faturası";
                lblBillAmount.Text = suFaturasi.ToString() + " ₺";
            }
            if (count % 4 == 4) 
            {
               var netFaturasi=db.Bills.Where(x=>x.BillTitle=="İnternet Faturası").Select((y)=>y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "İnternet Faturası";
                lblBillAmount.Text = netFaturasi.ToString() + " ₺";
            }

        }

        private void FrmDashboard_Load(object sender, System.EventArgs e)
        {
            var totalBalance = db.Banks.Sum(x => x.BankBalance);
            lblTotalBalance.Text = totalBalance.ToString() + " ₺";

            var lastProcessAmount=db.BankProcesses.OrderByDescending(x=>x.BankProcessId).Take(1).Select(y=>y.Amount).FirstOrDefault();
            lblLastBankProcessAmount.Text = lastProcessAmount.ToString()+" ₺";

            // Chart1 Kodları
            var bankData = db.Banks.Select(x =>new
            {
                x.BankTİtle,
                x.BankBalance
            }).ToList();
            chart1.Series.Clear();
            var series = chart1.Series.Add("Bankalar");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
            foreach (var item in bankData) 
            {
                series.Points.AddXY(item.BankTİtle, item.BankBalance);
            }
            //Chart2 Kodları
            var billData = db.Bills.Select(x =>new
            {
                x.BillTitle,
                x.BillAmount,
            }).ToList();
            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Faturalar");
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            foreach(var item in billData)
            {
                series2.Points.AddXY(item.BillTitle, item.BillAmount);
            }
        }

       
    }
}
