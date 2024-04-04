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
            this.dataGridViewAccounts = new System.Windows.Forms.DataGridView();
            this.dataGridViewPersons = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAccounts
            // 
            this.dataGridViewAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccounts.Location = new System.Drawing.Point(1134, 496);
            this.dataGridViewAccounts.Name = "dataGridViewAccounts";
            this.dataGridViewAccounts.Size = new System.Drawing.Size(611, 438);
            this.dataGridViewAccounts.TabIndex = 1;
            // 
            // dataGridViewPersons
            // 
            this.dataGridViewPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersons.Location = new System.Drawing.Point(1134, 12);
            this.dataGridViewPersons.Name = "dataGridViewPersons";
            this.dataGridViewPersons.Size = new System.Drawing.Size(611, 435);
            this.dataGridViewPersons.TabIndex = 2;
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
            this.dataGridAllTransactions.Size = new System.Drawing.Size(569, 362);
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
            this.label1.Location = new System.Drawing.Point(277, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mayy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "122";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1906, 1016);
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
            this.Controls.Add(this.dataGridViewPersons);
            this.Controls.Add(this.dataGridViewAccounts);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewAccounts;
        private System.Windows.Forms.DataGridView dataGridViewPersons;
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
    }
}

