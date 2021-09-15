using BankClassLibrary3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankForm1
{
    public class AccountController
    {
        private Account model;

        public AccountController(Account aAccount)
        {
            model = aAccount;
        }

        public void DisplayBalance()
        {
            Console.WriteLine("Current Balance is : " + model.CurrentBalance);
        }

    }
}
