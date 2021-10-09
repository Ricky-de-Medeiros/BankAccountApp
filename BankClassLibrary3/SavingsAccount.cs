using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClassLibrary3
{
    // Checking Account : Account
    // Savings Account : Account
    public sealed class SavingsAccount : Account
    {
        public SavingsAccount() : base()
        {
            // Additional initializations
            Commission = 0.005f;

        }

        public SavingsAccount(int aAccountId, string aCustomerName, DateTime aDateOfBirth,
            string aPhone = null, string aAddress = null) : base(aAccountId, aCustomerName, aDateOfBirth, aPhone, aAddress)
        {
            Commission = 0.005f;

        }

        public override bool DepositMoney(double aAmount)
        {

            return base.DepositMoney(aAmount); // returns the base method result
        }

        public override bool WithdrawMoney(double aAmount)
        {

            double newAmountAfterCommission = aAmount + aAmount * Commission;
            //this is reduced from account, customer gets wanted amount
            return base.WithdrawMoney(newAmountAfterCommission);
        }
    }
}
