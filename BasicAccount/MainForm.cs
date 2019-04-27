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
    public partial class MainForm : Form
    {
        private AccountList accounts = new AccountList();
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            accounts.Fill();
            UpdateList();
        }

        // update list when data changes
        private void UpdateList()
        {
            accounts.Save(); // update db
            FillAccountListBox(); // update listbox
            FillAccountComboBox(); // update combo-dropdown
        }

        private void FillAccountListBox()
        {
            listBox_accounts.Items.Clear();
            // render columns
            String alignment = "{0, -20} {1, -20} {2, -20} {3, -20} {4, 20}";
            listBox_accounts.Items.Add(String.Format(alignment, "Account#", "Owner", "Balance($)", "Rate(%)", "Account Type"));
            // list of current accounts
            foreach (BasicAccount a in accounts)
                listBox_accounts.Items.Add(a.GetDisplayText(alignment));
        }

        private void FillAccountComboBox()
        {
            comboBox_accounts.Items.Clear();
            // list of current account #
            foreach (BasicAccount a in accounts)
                comboBox_accounts.Items.Add(a.AccountNumber);
        }

        private void addAccount_button_Click(object sender, EventArgs e)
        {
            NewAccountForm accountForm = new NewAccountForm();
            BasicAccount newAccount = accountForm.GetNewAccount();

            if (newAccount != null)
            {
                accounts.Add(newAccount);
                UpdateList();
            }
        }

        private void button_addMonthlyInterest_Click(object sender, EventArgs e)
        {
            
            // add monthly interest in all accounts
            foreach (BasicAccount account in accounts)
            {
                if (account.GetType().Name == "SavingsAccount")
                {
                    SavingsAccount s = (SavingsAccount)account;
                    s.AddMonthlyInterest();
                    account.Balance = s.Balance; // update balance
                }
                else
                {
                    CheckingAccount c = (CheckingAccount)account;
                    c.AddMonthlyInterest();
                    account.Balance = c.Balance;
                }
            }
            UpdateList(); // udpate list
            comboBox_accounts.Text = "Account#";
            label_odl_minB.Text = "";
            label_balance.Text = ""; // clear current balance
            textBox_amount.Text = ""; // clear the amount
            
        }

        // on selecting item from combo-dropdown
        private void comboBox_accounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox_accounts.SelectedIndex; // selected account
            label_balance.Text = accounts[index].Balance.ToString("c"); // update current balance
            textBox_amount.Text = ""; // clear the amount
            // update relevant info
            if (accounts[index].GetType().Name == "SavingsAccount")
            {
                label_overdraft_minBalance.Text = "Min Balance: ";
                label_overdraft_minBalance.Tag = "Min Balance";
                SavingsAccount s = (SavingsAccount)accounts[index];
                label_odl_minB.Text = s.MinimumBalance.ToString("c");
            }
            else
            {
                label_overdraft_minBalance.Text = "Overdraft Limit: ";
                label_overdraft_minBalance.Tag = "OverdraftLimit";
                CheckingAccount c = (CheckingAccount)accounts[index];
                label_odl_minB.Text = c.OverdraftLimit.ToString("c");
            }

        }

        // check if the text field are validated
        private bool IsValidData()
        {
            return Validator.IsPresent(textBox_amount) &&
                   Validator.IsDecimal(textBox_amount) &&
                   Validator.IsPositive(textBox_amount);
        }

        private void button_deposit_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                int index = comboBox_accounts.SelectedIndex; // selected account
                accounts[index].Deposit(Convert.ToDecimal(textBox_amount.Text)); // just deposit
                UpdateList(); // udpate list
                label_balance.Text = accounts[index].Balance.ToString("c"); // update current balance
                textBox_amount.Text = ""; // clear the amount
            }

        }

        private void button_withdraw_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                int index = comboBox_accounts.SelectedIndex; // selected account
                bool success; // to check if the change is successful or not
                decimal balance; // current balance
                if (accounts[index].GetType().Name == "SavingsAccount")
                {
                    SavingsAccount s = (SavingsAccount)accounts[index];
                    success = s.Withdraw(Convert.ToDecimal(textBox_amount.Text)); // withdraw from Saving Account
                    balance = s.Balance; // current balance
                }
                else {
                    CheckingAccount c = (CheckingAccount)accounts[index];
                    success = c.Withdraw(Convert.ToDecimal(textBox_amount.Text)); // withdraw from Checking Account
                    balance = c.Balance; // current balance
                }

                if (success) {
                    accounts[index].Balance = balance;
                    UpdateList(); // udpate list
                    label_balance.Text = accounts[index].Balance.ToString("c"); // update current balance
                    textBox_amount.Text = ""; // clear the amount

                }

                
            }
        }
    }
}
