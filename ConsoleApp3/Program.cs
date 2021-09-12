using System;
using BankClassLibrary3;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loopCondition = true;

            //Create Account
            Account myAccount = CreateAccount();
            Account copyAccount = new Account();
            copyAccount = new Account(myAccount);

            while (loopCondition)
            {
                // Deposit
                DepositMoney(myAccount, 1000);

                // Display Transaction
                myAccount.LastTransaction.DisplayTransaction();

                // Withdraw
                WithdrawMoney(myAccount, 500);

                // Display Transaction
                myAccount.LastTransaction.DisplayTransaction();

                // Balance
                DisplayBalance(myAccount);

                UtilityMethods.PressAnyKeyToContinue();
            }
            
        
        }

        private static void DepositMoney(Account aAccount, double aMoney)
        {
            aAccount.DepositMoney(aMoney);
        }

        private static void WithdrawMoney(Account aAccount, double aMoney)
        {
            aAccount.WithdrawMoney(aMoney);
        }

        private static void DisplayBalance(Account aAccount)
        {
            aAccount.DisplayBalance();
        }




        private static Account CreateAccount()
        {

            string CustomerName = UtilityMethods.ReadTextInput("Please enter your name: ");

            int day = UtilityMethods.ReadNumericInput("Enter your day of birth: ");
            int month = UtilityMethods.ReadNumericInput("Enter your month of birth: ");
            int year = UtilityMethods.ReadNumericInput("Enter your year of birth: ");


            string phone = UtilityMethods.ReadTextInput("Phone number: ");
      
            string address = "";
            UtilityMethods.ReadTextInput("Address: ", ref address);

            string customerName = null;

            Account newAccount = new Account(customerName, new DateTime(year, month, day), phone, address);

            return newAccount;
        }
    }
}
