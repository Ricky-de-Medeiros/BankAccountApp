using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClassLibrary3
{
    public sealed class SavingsAccount : Account
    {
        public SavingsAccount() : base()
        {
            // Additional initializations   
        }

        public SavingsAccount(int aAccountId, string aCustomerName, DateTime aDateOfBirth,
            string aPhone = null, string aAddress = null) : base(aAccountId, aCustomerName, aDateOfBirth, aPhone, aAddress)
        {

        }
    }
}
