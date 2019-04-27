using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicAccount
{
    public partial class NewAccountForm : Form
    {
        private BasicAccount account = null;
        public NewAccountForm()
        {
            InitializeComponent();
        }
        private void NewAccountForm_Load(object sender, EventArgs e)
        {
            // default settings
            checkBox_checkingAcc.Checked = true; 
        }

        public BasicAccount GetNewAccount()
        {
            this.ShowDialog();
            return account;
        }

        private void checkBox_checkingAcc_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_checkingAcc.Checked)
            { // toggle 
                checkBox_Saving.Checked = false;
                label_minBalance_ODL.Text = "Overdraft Limit: ";
                label_minBalance_ODL.Tag = "OverdraftLimit";
            }
            textBox_accountNo.Focus(); // change focus
        }

        private void checkBox_Saving_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Saving.Checked)
            {
                checkBox_checkingAcc.Checked = false;
                label_minBalance_ODL.Text = "Minimum Balance: ";
                label_minBalance_ODL.Tag = "Minimum Balance";
            }
            textBox_accountNo.Focus();
        }
        // check if the text fields are validated
        private bool IsValidData()
        {
            return Validator.IsPresent(textBox_accountNo) &&
                Validator.IsPresent(textBox_owner) &&
                Validator.IsPresent(textBox_balance) &&
                Validator.IsPresent(textBox_interest) &&
                Validator.IsPresent(textBox_overdraft_minBalance) &&
                Validator.IsInt32(textBox_accountNo) &&
                Validator.IsGreaterThanEq(textBox_accountNo, 100) &&
                Validator.IsDecimal(textBox_balance) &&
                Validator.IsGreaterThanEq(textBox_balance, 0) &&
                Validator.IsWithinRange(textBox_interest, 0.0F, 1.0F) && // Interest rate should be greater than zero and less than one
                Validator.IsDecimal(textBox_overdraft_minBalance) &&
                Validator.IsPositive(textBox_overdraft_minBalance);
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (checkBox_checkingAcc.Checked)
                    account = new CheckingAccount(Convert.ToInt32(textBox_accountNo.Text), textBox_owner.Text,
                        Convert.ToDecimal(textBox_balance.Text), (float) Convert.ToDouble(textBox_interest.Text), Convert.ToDecimal(textBox_overdraft_minBalance.Text));
                else
                    account = new SavingsAccount(Convert.ToInt32(textBox_accountNo.Text), textBox_owner.Text,
                        Convert.ToDecimal(textBox_balance.Text), (float)Convert.ToDouble(textBox_interest.Text), Convert.ToDecimal(textBox_overdraft_minBalance.Text));
                this.Close();
            }
        }
    }
}
