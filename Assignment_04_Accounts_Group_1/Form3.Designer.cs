namespace Assignment_04_Accounts_Group_1
{
    partial class Form3
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
            this.transactionEventslbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // transactionEventslbl
            // 
            this.transactionEventslbl.AutoSize = true;
            this.transactionEventslbl.Location = new System.Drawing.Point(0, 0);
            this.transactionEventslbl.Name = "transactionEventslbl";
            this.transactionEventslbl.Size = new System.Drawing.Size(35, 13);
            this.transactionEventslbl.TabIndex = 0;
            this.transactionEventslbl.Text = "label1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 768);
            this.Controls.Add(this.transactionEventslbl);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label transactionEventslbl;
    }
}