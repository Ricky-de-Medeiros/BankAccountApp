
namespace BankForm1
{
    partial class CreateAccountForm
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
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.PhoneNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.AddressRichTextBox = new System.Windows.Forms.RichTextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.CreateAccountButton = new System.Windows.Forms.Button();
            this.PhoneCheckBox = new System.Windows.Forms.CheckBox();
            this.AddressCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(133, 74);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(237, 22);
            this.CustomerNameTextBox.TabIndex = 0;
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Location = new System.Drawing.Point(12, 79);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(109, 17);
            this.CustomerNameLabel.TabIndex = 1;
            this.CustomerNameLabel.Text = "Customer Name";
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.Location = new System.Drawing.Point(133, 121);
            this.BirthDatePicker.MaxDate = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            this.BirthDatePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(237, 22);
            this.BirthDatePicker.TabIndex = 2;
            this.BirthDatePicker.Value = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(15, 125);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(91, 17);
            this.DateOfBirthLabel.TabIndex = 3;
            this.DateOfBirthLabel.Text = "Date of Birth:";
            // 
            // PhoneNumberMaskedTextBox
            // 
            this.PhoneNumberMaskedTextBox.Location = new System.Drawing.Point(133, 173);
            this.PhoneNumberMaskedTextBox.Mask = "(020)-000-0000";
            this.PhoneNumberMaskedTextBox.Name = "PhoneNumberMaskedTextBox";
            this.PhoneNumberMaskedTextBox.Size = new System.Drawing.Size(237, 22);
            this.PhoneNumberMaskedTextBox.TabIndex = 4;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(15, 178);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(103, 17);
            this.PhoneNumberLabel.TabIndex = 5;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // AddressRichTextBox
            // 
            this.AddressRichTextBox.Location = new System.Drawing.Point(133, 230);
            this.AddressRichTextBox.Name = "AddressRichTextBox";
            this.AddressRichTextBox.Size = new System.Drawing.Size(237, 96);
            this.AddressRichTextBox.TabIndex = 6;
            this.AddressRichTextBox.Text = "";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(13, 230);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(60, 17);
            this.AddressLabel.TabIndex = 7;
            this.AddressLabel.Text = "Address";
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.Location = new System.Drawing.Point(133, 346);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(75, 23);
            this.CreateAccountButton.TabIndex = 8;
            this.CreateAccountButton.Text = "Create";
            this.CreateAccountButton.UseVisualStyleBackColor = true;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // PhoneCheckBox
            // 
            this.PhoneCheckBox.AutoSize = true;
            this.PhoneCheckBox.Checked = true;
            this.PhoneCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PhoneCheckBox.Location = new System.Drawing.Point(393, 177);
            this.PhoneCheckBox.Name = "PhoneCheckBox";
            this.PhoneCheckBox.Size = new System.Drawing.Size(18, 17);
            this.PhoneCheckBox.TabIndex = 9;
            this.PhoneCheckBox.UseVisualStyleBackColor = true;
            this.PhoneCheckBox.CheckedChanged += new System.EventHandler(this.PhoneCheckBox_CheckedChanged);
            // 
            // AddressCheckBox
            // 
            this.AddressCheckBox.AutoSize = true;
            this.AddressCheckBox.Checked = true;
            this.AddressCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AddressCheckBox.Location = new System.Drawing.Point(393, 234);
            this.AddressCheckBox.Name = "AddressCheckBox";
            this.AddressCheckBox.Size = new System.Drawing.Size(18, 17);
            this.AddressCheckBox.TabIndex = 10;
            this.AddressCheckBox.UseVisualStyleBackColor = true;
            this.AddressCheckBox.CheckedChanged += new System.EventHandler(this.AddressCheckBox_CheckedChanged);
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddressCheckBox);
            this.Controls.Add(this.PhoneCheckBox);
            this.Controls.Add(this.CreateAccountButton);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.AddressRichTextBox);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.PhoneNumberMaskedTextBox);
            this.Controls.Add(this.DateOfBirthLabel);
            this.Controls.Add(this.BirthDatePicker);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Name = "CreateAccountForm";
            this.Text = "Create Account Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.DateTimePicker BirthDatePicker;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.MaskedTextBox PhoneNumberMaskedTextBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.RichTextBox AddressRichTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Button CreateAccountButton;
        private System.Windows.Forms.CheckBox PhoneCheckBox;
        private System.Windows.Forms.CheckBox AddressCheckBox;
    }
}