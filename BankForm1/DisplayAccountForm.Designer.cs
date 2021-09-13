
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
            this.CustomerNamePanel = new BankForm1.CustomTextBoxUserControl();
            this.TransactionDatePanel = new BankForm1.CustomTextBoxUserControl();
            this.TransactionAmountPanel = new BankForm1.CustomTextBoxUserControl();
            this.TransactionTypePanel = new BankForm1.CustomTextBoxUserControl();
            this.TransactionLocationPanel = new BankForm1.CustomTextBoxUserControl();
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
            this.TransactionListBox.SelectedIndexChanged += new System.EventHandler(this.TransactionListBox_SelectedIndexChanged);
            // 
            // CustomerNamePanel
            // 
            this.CustomerNamePanel.LabelText = "Customer Name";
            this.CustomerNamePanel.Location = new System.Drawing.Point(398, 40);
            this.CustomerNamePanel.Name = "CustomerNamePanel";
            this.CustomerNamePanel.Size = new System.Drawing.Size(363, 55);
            this.CustomerNamePanel.TabIndex = 1;
            this.CustomerNamePanel.TextInput = "";
            // 
            // TransactionDatePanel
            // 
            this.TransactionDatePanel.LabelText = "Transaction Date";
            this.TransactionDatePanel.Location = new System.Drawing.Point(398, 235);
            this.TransactionDatePanel.Name = "TransactionDatePanel";
            this.TransactionDatePanel.Size = new System.Drawing.Size(387, 55);
            this.TransactionDatePanel.TabIndex = 2;
            this.TransactionDatePanel.TextInput = "";
            // 
            // TransactionAmountPanel
            // 
            this.TransactionAmountPanel.LabelText = "Transaction Amount";
            this.TransactionAmountPanel.Location = new System.Drawing.Point(398, 190);
            this.TransactionAmountPanel.Name = "TransactionAmountPanel";
            this.TransactionAmountPanel.Size = new System.Drawing.Size(387, 55);
            this.TransactionAmountPanel.TabIndex = 3;
            this.TransactionAmountPanel.TextInput = "";
            // 
            // TransactionTypePanel
            // 
            this.TransactionTypePanel.LabelText = "Transaction Type";
            this.TransactionTypePanel.Location = new System.Drawing.Point(398, 142);
            this.TransactionTypePanel.Name = "TransactionTypePanel";
            this.TransactionTypePanel.Size = new System.Drawing.Size(387, 55);
            this.TransactionTypePanel.TabIndex = 4;
            this.TransactionTypePanel.TextInput = "";
            // 
            // TransactionLocationPanel
            // 
            this.TransactionLocationPanel.LabelText = "Location";
            this.TransactionLocationPanel.Location = new System.Drawing.Point(398, 275);
            this.TransactionLocationPanel.Name = "TransactionLocationPanel";
            this.TransactionLocationPanel.Size = new System.Drawing.Size(387, 55);
            this.TransactionLocationPanel.TabIndex = 5;
            this.TransactionLocationPanel.TextInput = "";
            // 
            // DisplayAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.TransactionLocationPanel);
            this.Controls.Add(this.TransactionTypePanel);
            this.Controls.Add(this.TransactionAmountPanel);
            this.Controls.Add(this.TransactionDatePanel);
            this.Controls.Add(this.CustomerNamePanel);
            this.Controls.Add(this.TransactionListBox);
            this.Name = "DisplayAccountForm";
            this.Text = "Account Information";
            this.Load += new System.EventHandler(this.DisplayAccountForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox TransactionListBox;
        private CustomTextBoxUserControl CustomerNamePanel;
        private CustomTextBoxUserControl TransactionDatePanel;
        private CustomTextBoxUserControl TransactionAmountPanel;
        private CustomTextBoxUserControl TransactionTypePanel;
        private CustomTextBoxUserControl TransactionLocationPanel;
    }
}