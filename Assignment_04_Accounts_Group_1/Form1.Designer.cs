namespace Assignment_04_Accounts_Group_1
{
    partial class Form1
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
            this.loginEventsbtn = new System.Windows.Forms.Button();
            this.transactionEventslbl = new System.Windows.Forms.Button();
            this.dataGridAllTransactions = new System.Windows.Forms.DataGridView();
            this.getPersonlb = new System.Windows.Forms.Label();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.loginbtn = new System.Windows.Forms.Button();
            this.userlbl = new System.Windows.Forms.Label();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.passwordtxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxAccounts = new System.Windows.Forms.ListBox();
            this.viewAccountsltb = new System.Windows.Forms.ListBox();
            this.viewPersonsltb = new System.Windows.Forms.ListBox();
            this.accountsgrpb = new System.Windows.Forms.GroupBox();
            this.displayAccountlbl = new System.Windows.Forms.Label();
            this.minusTxtb = new System.Windows.Forms.TextBox();
            this.addTxtb = new System.Windows.Forms.TextBox();
            this.minusBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.getAccountbtn = new System.Windows.Forms.Button();
            this.accountTypetxtb = new System.Windows.Forms.TextBox();
            this.accountNamelbl = new System.Windows.Forms.Label();
            this.savingsrbt = new System.Windows.Forms.RadioButton();
            this.checkingrbt = new System.Windows.Forms.RadioButton();
            this.visarbt = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllTransactions)).BeginInit();
            this.accountsgrpb.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginEventsbtn
            // 
            this.loginEventsbtn.Location = new System.Drawing.Point(969, 911);
            this.loginEventsbtn.Name = "loginEventsbtn";
            this.loginEventsbtn.Size = new System.Drawing.Size(125, 23);
            this.loginEventsbtn.TabIndex = 3;
            this.loginEventsbtn.Text = "Show Login Events";
            this.loginEventsbtn.UseVisualStyleBackColor = true;
            this.loginEventsbtn.Click += new System.EventHandler(this.loginEventsbtn_Click);
            // 
            // transactionEventslbl
            // 
            this.transactionEventslbl.Location = new System.Drawing.Point(969, 852);
            this.transactionEventslbl.Name = "transactionEventslbl";
            this.transactionEventslbl.Size = new System.Drawing.Size(125, 23);
            this.transactionEventslbl.TabIndex = 4;
            this.transactionEventslbl.Text = "Show Transanction Events";
            this.transactionEventslbl.UseVisualStyleBackColor = true;
            this.transactionEventslbl.Click += new System.EventHandler(this.transactionEventslbl_Click);
            // 
            // dataGridAllTransactions
            // 
            this.dataGridAllTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAllTransactions.Location = new System.Drawing.Point(-4, 0);
            this.dataGridAllTransactions.Name = "dataGridAllTransactions";
            this.dataGridAllTransactions.Size = new System.Drawing.Size(400, 362);
            this.dataGridAllTransactions.TabIndex = 5;
            // 
            // getPersonlb
            // 
            this.getPersonlb.AutoSize = true;
            this.getPersonlb.Location = new System.Drawing.Point(90, 541);
            this.getPersonlb.Name = "getPersonlb";
            this.getPersonlb.Size = new System.Drawing.Size(91, 13);
            this.getPersonlb.TabIndex = 6;
            this.getPersonlb.Text = "Person get Result";
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(93, 394);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(158, 20);
            this.userNameTxt.TabIndex = 8;
            // 
            // loginbtn
            // 
            this.loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Location = new System.Drawing.Point(93, 464);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(158, 55);
            this.loginbtn.TabIndex = 9;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.Location = new System.Drawing.Point(58, 401);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(29, 13);
            this.userlbl.TabIndex = 10;
            this.userlbl.Text = "User";
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Location = new System.Drawing.Point(38, 434);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(53, 13);
            this.passwordlbl.TabIndex = 11;
            this.passwordlbl.Text = "Password";
            // 
            // passwordtxb
            // 
            this.passwordtxb.Location = new System.Drawing.Point(93, 427);
            this.passwordtxb.Name = "passwordtxb";
            this.passwordtxb.Size = new System.Drawing.Size(158, 20);
            this.passwordtxb.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mayy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "122";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Test Account";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Test Password";
            // 
            // listBoxAccounts
            // 
            this.listBoxAccounts.FormattingEnabled = true;
            this.listBoxAccounts.Location = new System.Drawing.Point(-4, 571);
            this.listBoxAccounts.Name = "listBoxAccounts";
            this.listBoxAccounts.Size = new System.Drawing.Size(158, 225);
            this.listBoxAccounts.TabIndex = 18;
            // 
            // viewAccountsltb
            // 
            this.viewAccountsltb.FormattingEnabled = true;
            this.viewAccountsltb.Location = new System.Drawing.Point(402, 0);
            this.viewAccountsltb.Name = "viewAccountsltb";
            this.viewAccountsltb.Size = new System.Drawing.Size(1506, 160);
            this.viewAccountsltb.TabIndex = 19;
            // 
            // viewPersonsltb
            // 
            this.viewPersonsltb.FormattingEnabled = true;
            this.viewPersonsltb.Location = new System.Drawing.Point(160, 571);
            this.viewPersonsltb.Name = "viewPersonsltb";
            this.viewPersonsltb.Size = new System.Drawing.Size(229, 225);
            this.viewPersonsltb.TabIndex = 20;
            // 
            // accountsgrpb
            // 
            this.accountsgrpb.Controls.Add(this.displayAccountlbl);
            this.accountsgrpb.Controls.Add(this.minusTxtb);
            this.accountsgrpb.Controls.Add(this.addTxtb);
            this.accountsgrpb.Controls.Add(this.minusBtn);
            this.accountsgrpb.Controls.Add(this.addBtn);
            this.accountsgrpb.Controls.Add(this.getAccountbtn);
            this.accountsgrpb.Controls.Add(this.accountTypetxtb);
            this.accountsgrpb.Controls.Add(this.accountNamelbl);
            this.accountsgrpb.Controls.Add(this.savingsrbt);
            this.accountsgrpb.Controls.Add(this.checkingrbt);
            this.accountsgrpb.Controls.Add(this.visarbt);
            this.accountsgrpb.Location = new System.Drawing.Point(402, 166);
            this.accountsgrpb.Name = "accountsgrpb";
            this.accountsgrpb.Size = new System.Drawing.Size(1492, 196);
            this.accountsgrpb.TabIndex = 21;
            this.accountsgrpb.TabStop = false;
            this.accountsgrpb.Text = "Account Type";
            // 
            // displayAccountlbl
            // 
            this.displayAccountlbl.AutoSize = true;
            this.displayAccountlbl.Location = new System.Drawing.Point(430, 44);
            this.displayAccountlbl.Name = "displayAccountlbl";
            this.displayAccountlbl.Size = new System.Drawing.Size(35, 13);
            this.displayAccountlbl.TabIndex = 22;
            this.displayAccountlbl.Text = "label5";
            // 
            // minusTxtb
            // 
            this.minusTxtb.Location = new System.Drawing.Point(517, 117);
            this.minusTxtb.Name = "minusTxtb";
            this.minusTxtb.Size = new System.Drawing.Size(100, 20);
            this.minusTxtb.TabIndex = 23;
            // 
            // addTxtb
            // 
            this.addTxtb.Location = new System.Drawing.Point(517, 79);
            this.addTxtb.Name = "addTxtb";
            this.addTxtb.Size = new System.Drawing.Size(100, 20);
            this.addTxtb.TabIndex = 8;
            // 
            // minusBtn
            // 
            this.minusBtn.Location = new System.Drawing.Point(423, 115);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(88, 23);
            this.minusBtn.TabIndex = 7;
            this.minusBtn.Text = "Minus";
            this.minusBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(423, 76);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 24;
            this.addBtn.Text = "Add";
            // 
            // getAccountbtn
            // 
            this.getAccountbtn.Location = new System.Drawing.Point(146, 77);
            this.getAccountbtn.Name = "getAccountbtn";
            this.getAccountbtn.Size = new System.Drawing.Size(183, 61);
            this.getAccountbtn.TabIndex = 5;
            this.getAccountbtn.Text = "Get Account";
            this.getAccountbtn.UseVisualStyleBackColor = true;
            this.getAccountbtn.Click += new System.EventHandler(this.getAccountbtn_Click);
            // 
            // accountTypetxtb
            // 
            this.accountTypetxtb.Location = new System.Drawing.Point(146, 44);
            this.accountTypetxtb.Name = "accountTypetxtb";
            this.accountTypetxtb.Size = new System.Drawing.Size(183, 20);
            this.accountTypetxtb.TabIndex = 4;
            // 
            // accountNamelbl
            // 
            this.accountNamelbl.AutoSize = true;
            this.accountNamelbl.Location = new System.Drawing.Point(198, 16);
            this.accountNamelbl.Name = "accountNamelbl";
            this.accountNamelbl.Size = new System.Drawing.Size(78, 13);
            this.accountNamelbl.TabIndex = 3;
            this.accountNamelbl.Text = "Account Name";
            // 
            // savingsrbt
            // 
            this.savingsrbt.AutoSize = true;
            this.savingsrbt.Location = new System.Drawing.Point(16, 121);
            this.savingsrbt.Name = "savingsrbt";
            this.savingsrbt.Size = new System.Drawing.Size(63, 17);
            this.savingsrbt.TabIndex = 2;
            this.savingsrbt.TabStop = true;
            this.savingsrbt.Text = "Savings";
            this.savingsrbt.UseVisualStyleBackColor = true;
            // 
            // checkingrbt
            // 
            this.checkingrbt.AutoSize = true;
            this.checkingrbt.Location = new System.Drawing.Point(16, 77);
            this.checkingrbt.Name = "checkingrbt";
            this.checkingrbt.Size = new System.Drawing.Size(70, 17);
            this.checkingrbt.TabIndex = 1;
            this.checkingrbt.TabStop = true;
            this.checkingrbt.Text = "Checking";
            this.checkingrbt.UseVisualStyleBackColor = true;
            // 
            // visarbt
            // 
            this.visarbt.AutoSize = true;
            this.visarbt.Location = new System.Drawing.Point(16, 35);
            this.visarbt.Name = "visarbt";
            this.visarbt.Size = new System.Drawing.Size(45, 17);
            this.visarbt.TabIndex = 0;
            this.visarbt.TabStop = true;
            this.visarbt.Text = "Visa";
            this.visarbt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1906, 1016);
            this.Controls.Add(this.accountsgrpb);
            this.Controls.Add(this.viewPersonsltb);
            this.Controls.Add(this.viewAccountsltb);
            this.Controls.Add(this.listBoxAccounts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordtxb);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.userlbl);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.getPersonlb);
            this.Controls.Add(this.dataGridAllTransactions);
            this.Controls.Add(this.transactionEventslbl);
            this.Controls.Add(this.loginEventsbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllTransactions)).EndInit();
            this.accountsgrpb.ResumeLayout(false);
            this.accountsgrpb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button loginEventsbtn;
        private System.Windows.Forms.Button transactionEventslbl;
        private System.Windows.Forms.DataGridView dataGridAllTransactions;
        private System.Windows.Forms.Label getPersonlb;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label userlbl;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.TextBox passwordtxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxAccounts;
        private System.Windows.Forms.ListBox viewAccountsltb;
        private System.Windows.Forms.ListBox viewPersonsltb;
        private System.Windows.Forms.GroupBox accountsgrpb;
        private System.Windows.Forms.RadioButton savingsrbt;
        private System.Windows.Forms.RadioButton checkingrbt;
        private System.Windows.Forms.RadioButton visarbt;
        private System.Windows.Forms.Label accountNamelbl;
        private System.Windows.Forms.TextBox accountTypetxtb;
        private System.Windows.Forms.Button getAccountbtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox addTxtb;
        private System.Windows.Forms.TextBox minusTxtb;
        private System.Windows.Forms.Label displayAccountlbl;
    }
}

