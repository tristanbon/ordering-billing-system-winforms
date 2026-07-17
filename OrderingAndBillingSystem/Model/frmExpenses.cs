using OrderingAndBillingSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingAndBillingSystem.Model
{
    public partial class frmExpenses : Form
    {
        ExpenseManager expmgr = new ExpenseManager();
        Expenses expense = new Expenses();
        List<Expenses> lstexp = new List<Expenses>();


        public frmExpenses()
        {
            InitializeComponent();
        }

        private void ClearFields()
        {
            txtExpense.Clear();
            txtAmount.Clear();
            txtReceive.Clear();
        }
        private void AddExpense()
        {
            try
            {
                expense.Date = DateTime.Now;
                expense.Expense = txtExpense.Text;
                expense.ReceivedBy = txtReceive.Text;
                expense.Amount = Convert.ToDouble(txtAmount.Text);
                expmgr.AddExpense(expense);
                MessageBox.Show("Expense successfully added", "Expense", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Unable to save. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbRemove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddExpense();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
