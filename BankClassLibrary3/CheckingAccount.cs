using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClassLibrary3
{
    public sealed class CheckingAccount : Account
    {
        public CheckingAccount() : base()
        {
            // Additional initializations   
        }
        
        public CheckingAccount(int aAccountId, string aCustomerName, DateTime aDateOfBirth, 
            string aPhone = null, string aAddress = null) : base(aAccountId, aCustomerName, aDateOfBirth, aPhone, aAddress)
        {

        }

        public override bool DepositMoney(double aAmount)
        {
            return base.DepositMoney(aAmount); // returns the base method result
        }

        public override bool WithdrawMoney(double aAmount)
        {
            return base.WithdrawMoney(aAmount);
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine("Cheking Account Balance: {0}, Commission: {1}", CurrentBalance, Commission);
        }
    }

}
