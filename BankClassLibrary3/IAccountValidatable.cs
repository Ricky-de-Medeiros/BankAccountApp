using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClassLibrary3
{
    interface IAccountValidatable
    {
        bool IsCustomerNameValid(String aCustomerName);

        bool IsBirthDateValid(DateTime aBirthDate);

        bool IsDepositMoneyRequestValid(double aMoneyAmount);

        bool IsWithdrawMoneyRequestValid(double aMoneyAmount);

    }

}
