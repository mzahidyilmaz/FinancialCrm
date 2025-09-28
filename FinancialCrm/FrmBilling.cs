using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db =new FinancialCrmDbEntities();
        private void FrmBilling_Load(object sender, EventArgs e)
        {
            var values=db.Bills.ToList();
            dataGridView1.DataSource=values;
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            string title=txtBillTitle.Text;
            decimal amount=decimal.Parse(txtBillAmount.Text);
            string period=txtBillPeriod.Text;

            Bills bills=new Bills();
            bills.BillTitle=title;
            bills.BillAmount=amount;
            bills.BillPeriod=period;
            db.Bills.Add(bills);
            db.SaveChanges();
            MessageBox.Show("Ödeme sisteme eklendi.","Ödeme Faturalar",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtBillId.Text);
            var removeValue = db.Bills.Find(id);
            db.Bills.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Ödeme sistemden silindi.", "Ödeme Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriod.Text;
            int id = int.Parse(txtBillId.Text);
            var values=db.Bills.Find(id);
            
            values.BillTitle = title;
            values.BillAmount = amount;
            values.BillPeriod = period;
            db.SaveChanges();
            MessageBox.Show("Ödeme sistemde güncellendi.", "Ödeme Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values2 = db.Bills.ToList();
            dataGridView1.DataSource = values2;
        }

        private void btnFrmBanks_Click(object sender, EventArgs e)
        {
            FrmBanks banks = new FrmBanks();
            banks.Show();
            this.Hide();
        }
    }
}
