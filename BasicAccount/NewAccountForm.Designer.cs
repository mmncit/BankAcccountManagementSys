namespace BasicAccount
{
    partial class NewAccountForm
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
            this.checkBox_Saving = new System.Windows.Forms.CheckBox();
            this.checkBox_checkingAcc = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_data = new System.Windows.Forms.GroupBox();
            this.textBox_overdraft_minBalance = new System.Windows.Forms.TextBox();
            this.textBox_interest = new System.Windows.Forms.TextBox();
            this.textBox_balance = new System.Windows.Forms.TextBox();
            this.textBox_owner = new System.Windows.Forms.TextBox();
            this.label_minBalance_ODL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_accountNo = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_Saving
            // 
            this.checkBox_Saving.AutoSize = true;
            this.checkBox_Saving.Location = new System.Drawing.Point(20, 63);
            this.checkBox_Saving.Name = "checkBox_Saving";
            this.checkBox_Saving.Size = new System.Drawing.Size(127, 21);
            this.checkBox_Saving.TabIndex = 0;
            this.checkBox_Saving.Text = "Saving account";
            this.checkBox_Saving.UseVisualStyleBackColor = true;
            this.checkBox_Saving.CheckedChanged += new System.EventHandler(this.checkBox_Saving_CheckedChanged);
            // 
            // checkBox_checkingAcc
            // 
            this.checkBox_checkingAcc.AutoSize = true;
            this.checkBox_checkingAcc.Location = new System.Drawing.Point(20, 36);
            this.checkBox_checkingAcc.Name = "checkBox_checkingAcc";
            this.checkBox_checkingAcc.Size = new System.Drawing.Size(142, 21);
            this.checkBox_checkingAcc.TabIndex = 1;
            this.checkBox_checkingAcc.Text = "Checking account";
            this.checkBox_checkingAcc.UseVisualStyleBackColor = true;
            this.checkBox_checkingAcc.CheckedChanged += new System.EventHandler(this.checkBox_checkingAcc_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.checkBox_checkingAcc);
            this.groupBox1.Controls.Add(this.checkBox_Saving);
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 117);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Type";
            // 
            // groupBox_data
            // 
            this.groupBox_data.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox_data.Controls.Add(this.textBox_overdraft_minBalance);
            this.groupBox_data.Controls.Add(this.textBox_interest);
            this.groupBox_data.Controls.Add(this.textBox_balance);
            this.groupBox_data.Controls.Add(this.textBox_owner);
            this.groupBox_data.Controls.Add(this.label_minBalance_ODL);
            this.groupBox_data.Controls.Add(this.label4);
            this.groupBox_data.Controls.Add(this.label3);
            this.groupBox_data.Controls.Add(this.label2);
            this.groupBox_data.Controls.Add(this.label1);
            this.groupBox_data.Controls.Add(this.textBox_accountNo);
            this.groupBox_data.Location = new System.Drawing.Point(23, 158);
            this.groupBox_data.Name = "groupBox_data";
            this.groupBox_data.Size = new System.Drawing.Size(367, 225);
            this.groupBox_data.TabIndex = 3;
            this.groupBox_data.TabStop = false;
            this.groupBox_data.Text = "Data";
            // 
            // textBox_overdraft_minBalance
            // 
            this.textBox_overdraft_minBalance.Location = new System.Drawing.Point(154, 177);
            this.textBox_overdraft_minBalance.Name = "textBox_overdraft_minBalance";
            this.textBox_overdraft_minBalance.Size = new System.Drawing.Size(197, 22);
            this.textBox_overdraft_minBalance.TabIndex = 10;
            this.tooltip.SetToolTip(this.textBox_overdraft_minBalance, "must be a positive value");
            // 
            // textBox_interest
            // 
            this.textBox_interest.Location = new System.Drawing.Point(154, 142);
            this.textBox_interest.Name = "textBox_interest";
            this.textBox_interest.Size = new System.Drawing.Size(197, 22);
            this.textBox_interest.TabIndex = 9;
            this.textBox_interest.Tag = "Interest rate";
            this.tooltip.SetToolTip(this.textBox_interest, "Interest rate should be greater than zero and less than one");
            // 
            // textBox_balance
            // 
            this.textBox_balance.Location = new System.Drawing.Point(154, 105);
            this.textBox_balance.Name = "textBox_balance";
            this.textBox_balance.Size = new System.Drawing.Size(197, 22);
            this.textBox_balance.TabIndex = 8;
            this.textBox_balance.Tag = "Balance";
            this.tooltip.SetToolTip(this.textBox_balance, "Balance should be greater than or equal to zero");
            // 
            // textBox_owner
            // 
            this.textBox_owner.Location = new System.Drawing.Point(154, 73);
            this.textBox_owner.Name = "textBox_owner";
            this.textBox_owner.Size = new System.Drawing.Size(197, 22);
            this.textBox_owner.TabIndex = 7;
            this.textBox_owner.Tag = "Owner";
            this.tooltip.SetToolTip(this.textBox_owner, "Name of Account holder. Owner should be a non-empty string.");
            // 
            // label_minBalance_ODL
            // 
            this.label_minBalance_ODL.AutoSize = true;
            this.label_minBalance_ODL.Location = new System.Drawing.Point(17, 180);
            this.label_minBalance_ODL.Name = "label_minBalance_ODL";
            this.label_minBalance_ODL.Size = new System.Drawing.Size(100, 17);
            this.label_minBalance_ODL.TabIndex = 5;
            this.label_minBalance_ODL.Text = "Overdraft limit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Interest rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Balance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Owner:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account number:";
            // 
            // textBox_accountNo
            // 
            this.textBox_accountNo.Location = new System.Drawing.Point(154, 38);
            this.textBox_accountNo.Name = "textBox_accountNo";
            this.textBox_accountNo.Size = new System.Drawing.Size(197, 22);
            this.textBox_accountNo.TabIndex = 0;
            this.textBox_accountNo.Tag = "Account number";
            this.tooltip.SetToolTip(this.textBox_accountNo, "Account number should be greater than or equal to 100");
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_add.Location = new System.Drawing.Point(23, 408);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(194, 61);
            this.button_add.TabIndex = 4;
            this.button_add.Tag = "Add button";
            this.button_add.Text = "Add";
            this.tooltip.SetToolTip(this.button_add, "Create new account");
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_cancel.Location = new System.Drawing.Point(248, 408);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(163, 61);
            this.button_cancel.TabIndex = 5;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // NewAccountForm
            // 
            this.ClientSize = new System.Drawing.Size(435, 493);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.groupBox_data);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewAccountForm";
            this.Text = "New Account Form";
            this.Load += new System.EventHandler(this.NewAccountForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_data.ResumeLayout(false);
            this.groupBox_data.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.CheckBox checkBox_Saving;
        private System.Windows.Forms.CheckBox checkBox_checkingAcc;
        private System.Windows.Forms.GroupBox groupBox_data;
        private System.Windows.Forms.TextBox textBox_overdraft_minBalance;
        private System.Windows.Forms.TextBox textBox_interest;
        private System.Windows.Forms.TextBox textBox_balance;
        private System.Windows.Forms.TextBox textBox_owner;
        private System.Windows.Forms.Label label_minBalance_ODL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_accountNo;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip tooltip;

    }
    }
