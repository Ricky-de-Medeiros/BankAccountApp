using System;
using System.Collections.Generic;

namespace BankClassLibrary3
{
    public class Account
    {

        #region FIELDS AND PROPERTIES
        // static fields
        public static double ExchangeRate = 1.1d;
        public const string EMPTY_ADDRESS = "UNKNOWN";
        public const string EMPTY_PHONE = "####";

        Customer _AccountCustomer;
        public string CustomerName
        {
            get
            {
                return _AccountCustomer.CustomerName;
            }

        }

        public DateTime CustomerBirthDate
        {
            get
            {
                return _AccountCustomer.DateOfBirth;
            }
        }

        public string CustomerPhone
        {
            get
            {
                return _AccountCustomer.PhoneNumber;
            }
            //set
            //{
            //    if (String.IsNullOrEmpty(value))
            //    {
            //        _AccountCustomer.PhoneNumber = EMPTY_PHONE;
            //    }
            //    else
            //    {
            //        _AccountCustomer.PhoneNumber = value;
            //    }

            //}
        }

        public string CustomerAddress
        {
            get
            {
                return _AccountCustomer.Address;
            }
            //set
            //{
            //    if (String.IsNullOrEmpty(value))
            //    {
            //        _AccountCustomer.Address = EMPTY_ADDRESS;
            //    }
            //    else
            //    {
            //        _AccountCustomer.Address = value;
            //    }

            //}
        }

        int _AccountNumber;
        public int AccountNumber
        {
            get
            {
                return _AccountNumber;
            }
            //  There should be no set accessor
        }

        double _CurrentBalance;
        public double CurrentBalance
        {
            get
            {
                return _CurrentBalance;
            }
        }

        public double CurrentBalanceInForeignCurrency
        {
            get
            {
                return _CurrentBalance * ExchangeRate;
            }
        }

        List<Transaction> _ListOfTransactions;

        public List<Transaction> ListOfTransactions
        {
            get
            {
                return _ListOfTransactions;
            }
        }

        public Transaction LastTransaction
        {
            get
            {
                if (_ListOfTransactions.Count > 0)
                {
                    return _ListOfTransactions[_ListOfTransactions.Count - 1];
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
            _AccountCustomer = new Customer("ADMIN", new DateTime(2000, 1, 1), null, null);
            _AccountNumber = Guid.NewGuid().GetHashCode();

            _CurrentBalance = 0;
            _ListOfTransactions = new List<Transaction>();
        }

        // Copy Constructor
        public Account(Account aAccountToCopy)
        {
            _AccountNumber = aAccountToCopy._AccountNumber;
            _CurrentBalance = aAccountToCopy._CurrentBalance;

            _ListOfTransactions = new List<Transaction>();

            for (int i = 0; i < aAccountToCopy._ListOfTransactions.Count; i++)
            {
                _ListOfTransactions.Add(aAccountToCopy._ListOfTransactions[i]);
            }

            // shortcut
            // ListOfTransactions = new List<Transaction>(aAccountToCopy.ListOfTransactions);

            // copy customer
            _AccountCustomer = new Customer(aAccountToCopy._AccountCustomer);
        }

        // Initialization
        public Account(int aAccountId, string aCustomerName, DateTime aDateOfBirth, string aPhone = null, string aAddress = null)
        {

            _AccountCustomer = new Customer(aCustomerName, aDateOfBirth, aPhone, aAddress);
            //Generate random Globally Unique Identifiers Guid
            _AccountNumber = aAccountId;// Guid.NewGuid().GetHashCode();

            _CurrentBalance = 0;
            _ListOfTransactions = new List<Transaction>();

        }

        public Account(string aCustomerName, DateTime aDateOfBirth, string aPhone = null, string aAddress = null)
        {

            _AccountCustomer = new Customer(aCustomerName, aDateOfBirth, aPhone, aAddress);
            //Generate random Globally Unique Identifiers Guid
            _AccountNumber = Guid.NewGuid().GetHashCode();

            _CurrentBalance = 0;
            _ListOfTransactions = new List<Transaction>();

        }

        public void AddTransaction(Transaction newTransaction)
        {
            ListOfTransactions.Add(newTransaction);
        
            switch(newTransaction.TransactionTypeString)
            {
                case "deposit":
                    _CurrentBalance += newTransaction.MoneyAmount;
                    break;
                case "withdrawal":
                    _CurrentBalance -= newTransaction.MoneyAmount;
                    break;
            }
        }
        

        #endregion CONSTRUCTORS

        #region METHODS

        //Deposit Money Method
        public bool DepositMoney(double aAmount)
        {

            bool isSuccess = false;
            _CurrentBalance += aAmount;

            // 5. Create a transaction object and add it to the list
            Transaction myTransaction = new Transaction(aAmount, TransactionType.DEPOSIT);
            _ListOfTransactions.Add(myTransaction);

            return isSuccess;
        }

        // Withdraw Money Method
        public bool WithdrawMoney(double aAmount)
        {
            bool isSuccess = false;
            _CurrentBalance -= aAmount;

            // 6. Create a transaction object and add it to the list
            Transaction myTransaction = new Transaction(aAmount, TransactionType.WITHDRAWL);
            _ListOfTransactions.Add(myTransaction);

            return isSuccess;
        }

        //Update Phone

        #endregion METHODS


        #region NESTED TYPES
        //Nested Class

        #endregion NESTED TYPES
    }
}
