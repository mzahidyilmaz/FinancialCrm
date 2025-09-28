using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmBanks_Load(object sender, EventArgs e)
        {

            // Banka Bakiyeleri
            var ziraatBankBalance=db.Banks.Where(x=>x.BankTİtle=="Ziraat Bankası").Select(y=>y.BankBalance).FirstOrDefault();
            var isBankasiBalance=db.Banks.Where(x=>x.BankTİtle=="İş Bankası").Select(y=>y.BankBalance).FirstOrDefault();
            var halkBankBalance=db.Banks.Where(x=>x.BankTİtle=="HalkBank").Select(y=>y.BankBalance).FirstOrDefault();

            lblZiraatBalance.Text = ziraatBankBalance.ToString() +" ₺";
            lblIsBankBalance.Text = isBankasiBalance.ToString() + " ₺";
            lblHalkBankBalance.Text = halkBankBalance.ToString() + " ₺";

            // Banka Hareketleri
            var bankProcess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text = bankProcess1.Description + " " + bankProcess1.Amount + " " + bankProcess1.ProcessDate;

            var bankProcess2 =db.BankProcesses.OrderByDescending(x=>x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text=bankProcess2.Description+" "+bankProcess2.Amount + " " + bankProcess2.ProcessDate;

            var bankProcess3=db.BankProcesses.OrderByDescending(x=>x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text=bankProcess3.Description+" "+bankProcess3.Amount + " " + bankProcess3.ProcessDate; 
        }

        private void btnFrmBilling_Click(object sender, EventArgs e)
        {
            FrmBilling bills = new FrmBilling();
            bills.Show();
            this.Hide();
        }
    }
}
