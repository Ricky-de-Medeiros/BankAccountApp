using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClassLibrary3
{
    public class Transaction
    {

        #region FIELDS AND PROPERTIES

        double _MoneyAmount;
        DateTime _TransactionDate;
        string _Location;

        TransactionType _TypeOfTransaction;

        public double MoneyAmount
        {
            get
            {
                return _MoneyAmount;
            }
            set
            {
                _MoneyAmount = value;
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
                return (_TypeOfTransaction == TransactionType.DEPOSIT ? "Deposit" : "Withdraw");
            }
        }

        public string LocationString
        {
            get
            {
                return _Location;
            }
        }

        public DateTime TransactionDate
        {
            get
            {
                return _TransactionDate;
            }
        }

        public string DateString
        {
            get
            {
                return _TransactionDate.ToString("yyyy/MM/dd hh:mm:dd");
            }
        }

        #endregion FIELDS AND PROPERTIES

        #region METHODS

        

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
            _MoneyAmount = aAmountOfTransaction;
            _TypeOfTransaction = atransactionType;

            _TransactionDate = DateTime.Now;
            _Location = "EARTH";
        }

        // Copy Constructor
        public Transaction(Transaction aTransaction)
        {
            _MoneyAmount = aTransaction._MoneyAmount;
            _TypeOfTransaction = aTransaction._TypeOfTransaction;
            _TransactionDate = aTransaction._TransactionDate;
            _Location = aTransaction._Location;
        }

        public Transaction(double aAmountOfTransaction, string aTransactionTypeString, DateTime aTransactionDate, 
            string aTransactionLocation)
        {
            _MoneyAmount = aAmountOfTransaction;
            _TransactionDate = aTransactionDate;
            _Location = aTransactionLocation;
            
            switch(aTransactionTypeString)
            {
                case "Deposit":
                    _TypeOfTransaction = TransactionType.DEPOSIT;
                    break;
                case "Withdraw":
                    _TypeOfTransaction = TransactionType.WITHDRAWL;
                    break;
            }
        }


        #endregion CONSTRUCTORS

    }

    //  ENUM
    public enum TransactionType
    {
        DEPOSIT,
        WITHDRAWL
    }
}

