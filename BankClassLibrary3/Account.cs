using System;
using System.Collections.Generic;

namespace BankClassLibrary3
{
    public class Account
    {

        #region FIELDS AND PROPERTIES

        public static double ExchangeRate = 1.1d;
        public const string EMPTY_ADDRESS = "UNKNOWN";
        public const string EMPTY_PHONE = "####";

        Customer AccountCustomer;
        public string CustomerName
        {
            get
            {
                return AccountCustomer.CustomerName;
            }

        }

        public string CustomerPhone
        {
            get
            {
                return AccountCustomer.PhoneNumber;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    AccountCustomer.PhoneNumber = EMPTY_PHONE;
                }
                else
                {
                    AccountCustomer.PhoneNumber = value;
                }
                
            }
        }

        public string CustomerAddress
        {
            get
            {
                return AccountCustomer.Address;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    AccountCustomer.Address = EMPTY_ADDRESS;
                }
                else
                {
                    AccountCustomer.Address = value;
                }
                
            }
        }

        int AccountNumber;
        double CurrentBalance;
        public double Balance
        {
            get
            {
                return CurrentBalance;
            }
        }

        public double BalanceInForeignCurrency
        {
            get
            {
                return CurrentBalance * ExchangeRate;
            }
        }

        List<Transaction> ListOfTransactions;

        public List<Transaction> TransactionList
        {
            get
            {
                return ListOfTransactions;
            }
        }

        public Transaction LastTransaction
        {
            get
            {
                if (ListOfTransactions.Count > 0)
                {
                    return ListOfTransactions[ListOfTransactions.Count - 1];
                }
                else
                {
                    return null;
                }
                
            }
        }

        #endregion FIELDS AND PROPERTIES

        #region CONSTRUCTORS
        
        
        // Default Constructor
        public Account()
        {
            AccountCustomer = new Customer("ADMIN", new DateTime(2000,1,1), null, null);
            AccountNumber = Guid.NewGuid().GetHashCode();

            CurrentBalance = 0;
            ListOfTransactions = new List<Transaction>();
        }

        // Copy Constructor
        public Account(Account aAccountToCopy)
        {
            AccountNumber = aAccountToCopy.AccountNumber;
            CurrentBalance = aAccountToCopy.CurrentBalance;

            ListOfTransactions = new List<Transaction>();

            for (int i = 0; i < aAccountToCopy.ListOfTransactions.Count; i++) 
            {
                ListOfTransactions.Add(aAccountToCopy.ListOfTransactions[i]);
            }

            // shortcut
            // ListOfTransactions = new List<Transaction>(aAccountToCopy.ListOfTransactions);

            // copy customer
            AccountCustomer = new Customer(aAccountToCopy.AccountCustomer);
        }

        // Initialization
        public Account(string aCustomerName, DateTime aDateOfBirth, string aPhone = null, string aAddress = null) 
        {

            AccountCustomer = new Customer(aCustomerName, aDateOfBirth, aPhone, aAddress);
            //Generate random Globally Unique Identifiers Guid
            AccountNumber = Guid.NewGuid().GetHashCode();

            CurrentBalance = 0;
            ListOfTransactions = new List<Transaction>();

        }

        #endregion CONSTRUCTORS

        #region METHODS
        public void DisplayBalance()
        {
            Console.WriteLine("Current Balance is : " + CurrentBalance);
        }

        //Deposit Money Method
        public bool DepositMoney(double aAmount)
        {

            bool isSuccess = false;
            CurrentBalance += aAmount;

            // 5. Create a transaction object and add it to the list
            Transaction myTransaction = new Transaction(aAmount, TransactionType.DEPOSIT);
            ListOfTransactions.Add(myTransaction);

            return isSuccess;
        }

        // Withdraw Money Method
        public bool WithdrawMoney(double aAmount)
        {
            bool isSuccess = false;
            CurrentBalance -= aAmount;

            // 6. Create a transaction object and add it to the list
            Transaction myTransaction = new Transaction(aAmount, TransactionType.WITHDRAWL);
            ListOfTransactions.Add(myTransaction);

            return isSuccess;
        }

        //Update Phone

        #endregion METHODS


        #region NESTED TYPES
        //Nested Class
        public class Transaction
        {

            #region FIELDS AND PROPERTIES

            double AmountOfTransaction;
            DateTime TransactionDate;
            string Location;

            TransactionType TypeOfTransaction;

            public double MoneyAmount
            {
                get
                {
                    return AmountOfTransaction;
                }
                set
                {
                    AmountOfTransaction = value;
                }
            }

            public string Summary
            {
                get
                {
                    return TransactionTypeString +
                        " " + MoneyAmount + " " +
                        DateString;
                }
            }

            public string TransactionTypeString
            {
                get
                {
                    return (TypeOfTransaction == TransactionType.DEPOSIT ? "Deposit" : "Withdraw");
                }
            }

            public string LocationString
            {
                get
                {
                    return Location;
                }
            }

            public string DateString
            {
                get
                {
                    return TransactionDate.ToString("yyyy/MM/dd hh:mm:dd");
                }
            }

            #endregion FIELDS AND PROPERTIES

            #region METHODS

            public void DisplayTransaction()
            {
                Console.WriteLine((TypeOfTransaction == TransactionType.DEPOSIT ? "Deposit" : "Withdraw") + "is done.");
                Console.WriteLine("Total amount: " + AmountOfTransaction + " Date: " + TransactionDate.ToString("yyyy/MM/dd"));
            }

            #endregion METHODS

            #region CONSTRUCTORS

            // We do not want to allow default transactions
            private Transaction()
            {
                // Cannot Be called
            }

            // Regular Constructor
            public Transaction(double aAmountOfTransaction, TransactionType atransactionType)
            {
                AmountOfTransaction = aAmountOfTransaction;
                TypeOfTransaction = atransactionType;

                TransactionDate = DateTime.Now;
                Location = "EARTH";
            }

            // Copy Constructor
            public Transaction(Transaction aTransaction)
            {
                AmountOfTransaction = aTransaction.AmountOfTransaction;
                TypeOfTransaction = aTransaction.TypeOfTransaction;
                TransactionDate = aTransaction.TransactionDate;
                Location = aTransaction.Location;
            }


            #endregion CONSTRUCTORS

        }

        public enum TransactionType
        {
            DEPOSIT,
            WITHDRAWL
        }
    }
    #endregion NESTED TYPES
}
