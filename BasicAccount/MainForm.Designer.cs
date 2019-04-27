namespace BasicAccount
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox_DB = new System.Windows.Forms.GroupBox();
            this.listBox_accounts = new System.Windows.Forms.ListBox();
            this.groupBox_Management = new System.Windows.Forms.GroupBox();
            this.button_addMonthlyInterest = new System.Windows.Forms.Button();
            this.button_withdraw = new System.Windows.Forms.Button();
            this.button_deposit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_accounts = new System.Windows.Forms.ComboBox();
            this.addAccount_button = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label_balance = new System.Windows.Forms.Label();
            this.label_overdraft_minBalance = new System.Windows.Forms.Label();
            this.label_odl_minB = new System.Windows.Forms.Label();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.label_amount = new System.Windows.Forms.Label();
            this.groupBox_DB.SuspendLayout();
            this.groupBox_Management.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_DB
            // 
            this.groupBox_DB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox_DB.Controls.Add(this.listBox_accounts);
            this.groupBox_DB.Location = new System.Drawing.Point(23, 38);
            this.groupBox_DB.Name = "groupBox_DB";
            this.groupBox_DB.Size = new System.Drawing.Size(647, 432);
            this.groupBox_DB.TabIndex = 0;
            this.groupBox_DB.TabStop = false;
            this.groupBox_DB.Text = "Bank database";
            // 
            // listBox_accounts
            // 
            this.listBox_accounts.FormattingEnabled = true;
            this.listBox_accounts.ItemHeight = 16;
            this.listBox_accounts.Location = new System.Drawing.Point(17, 28);
            this.listBox_accounts.Name = "listBox_accounts";
            this.listBox_accounts.Size = new System.Drawing.Size(608, 388);
            this.listBox_accounts.TabIndex = 0;
            this.toolTip.SetToolTip(this.listBox_accounts, "List of created accounts");
            // 
            // groupBox_Management
            // 
            this.groupBox_Management.Controls.Add(this.label_amount);
            this.groupBox_Management.Controls.Add(this.textBox_amount);
            this.groupBox_Management.Controls.Add(this.label_odl_minB);
            this.groupBox_Management.Controls.Add(this.label_overdraft_minBalance);
            this.groupBox_Management.Controls.Add(this.label_balance);
            this.groupBox_Management.Controls.Add(this.label2);
            this.groupBox_Management.Controls.Add(this.button_addMonthlyInterest);
            this.groupBox_Management.Controls.Add(this.button_withdraw);
            this.groupBox_Management.Controls.Add(this.button_deposit);
            this.groupBox_Management.Controls.Add(this.label1);
            this.groupBox_Management.Controls.Add(this.comboBox_accounts);
            this.groupBox_Management.Controls.Add(this.addAccount_button);
            this.groupBox_Management.Location = new System.Drawing.Point(721, 38);
            this.groupBox_Management.Name = "groupBox_Management";
            this.groupBox_Management.Size = new System.Drawing.Size(259, 432);
            this.groupBox_Management.TabIndex = 1;
            this.groupBox_Management.TabStop = false;
            this.groupBox_Management.Text = "Management";
            // 
            // button_addMonthlyInterest
            // 
            this.button_addMonthlyInterest.Location = new System.Drawing.Point(18, 289);
            this.button_addMonthlyInterest.Name = "button_addMonthlyInterest";
            this.button_addMonthlyInterest.Size = new System.Drawing.Size(220, 47);
            this.button_addMonthlyInterest.TabIndex = 5;
            this.button_addMonthlyInterest.Text = "Add Monthly Interest";
            this.toolTip.SetToolTip(this.button_addMonthlyInterest, " Add monthly interest in all accounts");
            this.button_addMonthlyInterest.UseVisualStyleBackColor = true;
            this.button_addMonthlyInterest.Click += new System.EventHandler(this.button_addMonthlyInterest_Click);
            // 
            // button_withdraw
            // 
            this.button_withdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_withdraw.Location = new System.Drawing.Point(129, 223);
            this.button_withdraw.Name = "button_withdraw";
            this.button_withdraw.Size = new System.Drawing.Size(109, 47);
            this.button_withdraw.TabIndex = 4;
            this.button_withdraw.Text = "Withdraw";
            this.toolTip.SetToolTip(this.button_withdraw, "Subtract amount from the balance (if valid)");
            this.button_withdraw.UseVisualStyleBackColor = false;
            this.button_withdraw.Click += new System.EventHandler(this.button_withdraw_Click);
            // 
            // button_deposit
            // 
            this.button_deposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_deposit.Location = new System.Drawing.Point(18, 223);
            this.button_deposit.Name = "button_deposit";
            this.button_deposit.Size = new System.Drawing.Size(105, 47);
            this.button_deposit.TabIndex = 3;
            this.button_deposit.Tag = "Amount";
            this.button_deposit.Text = "Deposit";
            this.toolTip.SetToolTip(this.button_deposit, "Add amount to the account’s balance");
            this.button_deposit.UseVisualStyleBackColor = false;
            this.button_deposit.Click += new System.EventHandler(this.button_deposit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Account(s)";
            // 
            // comboBox_accounts
            // 
            this.comboBox_accounts.FormattingEnabled = true;
            this.comboBox_accounts.Location = new System.Drawing.Point(18, 61);
            this.comboBox_accounts.Name = "comboBox_accounts";
            this.comboBox_accounts.Size = new System.Drawing.Size(220, 24);
            this.comboBox_accounts.TabIndex = 1;
            this.comboBox_accounts.Text = "Account #";
            this.toolTip.SetToolTip(this.comboBox_accounts, "Select an account from the list, and perform Deposit or Withdraw operation.");
            this.comboBox_accounts.SelectedIndexChanged += new System.EventHandler(this.comboBox_accounts_SelectedIndexChanged);
            // 
            // addAccount_button
            // 
            this.addAccount_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addAccount_button.Location = new System.Drawing.Point(18, 362);
            this.addAccount_button.Name = "addAccount_button";
            this.addAccount_button.Size = new System.Drawing.Size(220, 47);
            this.addAccount_button.TabIndex = 0;
            this.addAccount_button.Text = "Add Account";
            this.addAccount_button.UseVisualStyleBackColor = false;
            this.addAccount_button.Click += new System.EventHandler(this.addAccount_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Balance:";
            // 
            // label_balance
            // 
            this.label_balance.AutoSize = true;
            this.label_balance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_balance.Location = new System.Drawing.Point(126, 107);
            this.label_balance.Name = "label_balance";
            this.label_balance.Size = new System.Drawing.Size(16, 17);
            this.label_balance.TabIndex = 7;
            this.label_balance.Text = "0";
            this.toolTip.SetToolTip(this.label_balance, "Current balance of selected account");
            // 
            // label_overdraft_minBalance
            // 
            this.label_overdraft_minBalance.AutoSize = true;
            this.label_overdraft_minBalance.Location = new System.Drawing.Point(18, 137);
            this.label_overdraft_minBalance.Name = "label_overdraft_minBalance";
            this.label_overdraft_minBalance.Size = new System.Drawing.Size(105, 17);
            this.label_overdraft_minBalance.TabIndex = 8;
            this.label_overdraft_minBalance.Text = "Overdraft Limit:";
            // 
            // label_odl_minB
            // 
            this.label_odl_minB.AutoSize = true;
            this.label_odl_minB.Location = new System.Drawing.Point(126, 137);
            this.label_odl_minB.Name = "label_odl_minB";
            this.label_odl_minB.Size = new System.Drawing.Size(16, 17);
            this.label_odl_minB.TabIndex = 9;
            this.label_odl_minB.Text = "0";
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(129, 174);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(109, 22);
            this.textBox_amount.TabIndex = 10;
            this.textBox_amount.Tag = "Amount";
            this.toolTip.SetToolTip(this.textBox_amount, "Amount must be positive");
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Location = new System.Drawing.Point(21, 177);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(60, 17);
            this.label_amount.TabIndex = 11;
            this.label_amount.Text = "Amount:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 501);
            this.Controls.Add(this.groupBox_Management);
            this.Controls.Add(this.groupBox_DB);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "MainForm";
            this.Text = "Welcome to C# Bank!";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox_DB.ResumeLayout(false);
            this.groupBox_Management.ResumeLayout(false);
            this.groupBox_Management.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_DB;
        private System.Windows.Forms.ListBox listBox_accounts;
        private System.Windows.Forms.GroupBox groupBox_Management;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_accounts;
        private System.Windows.Forms.Button addAccount_button;
        private System.Windows.Forms.Button button_addMonthlyInterest;
        private System.Windows.Forms.Button button_withdraw;
        private System.Windows.Forms.Button button_deposit;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_balance;
        private System.Windows.Forms.Label label_odl_minB;
        private System.Windows.Forms.Label label_overdraft_minBalance;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.TextBox textBox_amount;
    }
}

