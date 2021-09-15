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
        BindingList<Transaction> data;
        
        private DisplayAccountForm() { }

        public DisplayAccountForm(Account aAccount)
        {
            InitializeComponent();
            myAccount = aAccount;
            CustomerNamePanel.TextInput = myAccount.CustomerName;
            BalanceControlPanel.TextInput = myAccount.CurrentBalance.ToString();

            data = new BindingList<Transaction>(myAccount.ListOfTransactions);

            TransactionListBox.DataSource = data; // myAccount.TransactionList;
            TransactionListBox.DisplayMember = "Summary";
        }

        private void DisplayAccountForm_Load(object sender, EventArgs e)
        {

        }

        private void TransactionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int newIndex = TransactionListBox.SelectedIndex;

            Transaction selectedTransaction = myAccount.ListOfTransactions[newIndex];

            
            TransactionTypePanel.TextInput = selectedTransaction.TransactionTypeString;
            TransactionDatePanel.TextInput = selectedTransaction.DateString;
            TransactionAmountPanel.TextInput = selectedTransaction.MoneyAmount.ToString();
            TransactionLocationPanel.TextInput = selectedTransaction.LocationString;

        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            double depositAmount = Convert.ToDouble(DepositAmountTextBox.Text.ToString());
            myAccount.DepositMoney(depositAmount);
            BalanceControlPanel.TextInput = myAccount.CurrentBalance.ToString();
            data.ResetBindings();
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            double withdrawAmount = Convert.ToDouble(WithdrawAmountTextBox.Text.ToString());
            myAccount.WithdrawMoney(withdrawAmount);
            BalanceControlPanel.TextInput = myAccount.CurrentBalance.ToString();
            data.ResetBindings();

        }
    }
}
