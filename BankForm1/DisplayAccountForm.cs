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
using static BankClassLibrary3.Account;

namespace BankForm1
{
    public partial class DisplayAccountForm : Form
    {
        private Account myAccount;
        
        private DisplayAccountForm() { }

        public DisplayAccountForm(Account aAccount)
        {
            InitializeComponent();
            myAccount = aAccount;
            TransactionListBox.DataSource = myAccount.TransactionList;
            TransactionListBox.DisplayMember = "Summary";
        }

        private void DisplayAccountForm_Load(object sender, EventArgs e)
        {

        }

        private void TransactionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int newIndex = TransactionListBox.SelectedIndex;

            Transaction selectedTransaction = myAccount.TransactionList[newIndex];

            CustomerNamePanel.TextInput = myAccount.CustomerName;
            TransactionTypePanel.TextInput = selectedTransaction.TransactionTypeString;
            TransactionDatePanel.TextInput = selectedTransaction.DateString;
            TransactionAmountPanel.TextInput = selectedTransaction.MoneyAmount.ToString();
            TransactionLocationPanel.TextInput = selectedTransaction.LocationString;

        }
    }
}
