
namespace BankForm1
{
    partial class DisplayAccountForm
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
            this.TransactionListBox = new System.Windows.Forms.ListBox();
            this.customTextBoxUserControl1 = new BankForm1.CustomTextBoxUserControl();
            this.SuspendLayout();
            // 
            // TransactionListBox
            // 
            this.TransactionListBox.FormattingEnabled = true;
            this.TransactionListBox.ItemHeight = 16;
            this.TransactionListBox.Items.AddRange(new object[] {
            "Transaction 1",
            "Transaction 2"});
            this.TransactionListBox.Location = new System.Drawing.Point(43, 28);
            this.TransactionListBox.Name = "TransactionListBox";
            this.TransactionListBox.Size = new System.Drawing.Size(338, 404);
            this.TransactionListBox.TabIndex = 0;
            // 
            // customTextBoxUserControl1
            // 
            this.customTextBoxUserControl1.Location = new System.Drawing.Point(464, 28);
            this.customTextBoxUserControl1.Name = "customTextBoxUserControl1";
            this.customTextBoxUserControl1.Size = new System.Drawing.Size(321, 55);
            this.customTextBoxUserControl1.TabIndex = 1;
            // 
            // DisplayAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customTextBoxUserControl1);
            this.Controls.Add(this.TransactionListBox);
            this.Name = "DisplayAccountForm";
            this.Text = "Account Information";
            this.Load += new System.EventHandler(this.DisplayAccountForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox TransactionListBox;
        private CustomTextBoxUserControl customTextBoxUserControl1;
    }
}