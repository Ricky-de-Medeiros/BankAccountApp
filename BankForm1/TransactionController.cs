using BankClassLibrary3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankForm1
{
    public class TransactionController
    {
        private Transaction model;

// Constructor
        public TransactionController(Transaction aModel)
        {
            model = aModel;
        }

        public void DisplayTransaction()
        {
            Console.WriteLine(model.TransactionTypeString + "is done.");
            Console.WriteLine("Total amount: " + model.MoneyAmount +
                " Date: " + model.DateString);
        }


    }
    
}
