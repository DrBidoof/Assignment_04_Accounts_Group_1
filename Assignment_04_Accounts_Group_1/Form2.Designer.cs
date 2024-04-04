namespace Assignment_04_Accounts_Group_1
{
    partial class Form2
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
            this.logingEventslbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logingEventslbl
            // 
            this.logingEventslbl.AutoSize = true;
            this.logingEventslbl.Location = new System.Drawing.Point(37, 18);
            this.logingEventslbl.Name = "logingEventslbl";
            this.logingEventslbl.Size = new System.Drawing.Size(0, 13);
            this.logingEventslbl.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 366);
            this.Controls.Add(this.logingEventslbl);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logingEventslbl;
    }
}