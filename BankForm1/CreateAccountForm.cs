using BankClassLibrary3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankForm1
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private string PhoneTextInput
        {
            get
            {
                if(PhoneNumberMaskedTextBox.Enabled)
                {
                    return PhoneNumberMaskedTextBox.Text;
                }
                else
                {
                    return null;
                }
            }
        }

        private string AddressTextInput
        {
            get
            {
                if (AddressRichTextBox.Enabled)
                {
                    return AddressRichTextBox.Text;
                }
                else
                {
                    return null;
                }
            }
        }

        private void PhoneCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PhoneNumberMaskedTextBox.Enabled = PhoneCheckBox.Checked;
        }

        private void AddressCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            AddressRichTextBox.Enabled = AddressCheckBox.Checked;
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            string customerName = CustomerNameTextBox.Text;
            DateTime birthDate = BirthDatePicker.Value;
            string phone = PhoneTextInput;
            string address = AddressTextInput;
            
            Account newAccount = new Account(customerName, birthDate, phone, address);

            //MessageBox.Show("Account of Customer " + customerName + " has been created.");
            DisplayAccountForm displayAccount = new DisplayAccountForm(newAccount);

            this.Hide();
            displayAccount.ShowDialog();
            this.Show();

        }
    }
}
