using BankClassLibrary3;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankForm1
{
    //  Methods and properties to use file system as database
    public static class StorageUtilityFunctions
    {
        const string MainStorageDir = @"C:\temp";

        static StorageUtilityFunctions()
        {
            if(!CheckMainDirectory())
            {
                Directory.CreateDirectory(MainStorageDir);
            }
        }
        static bool CheckMainDirectory()
        {
            if(Directory.Exists(MainStorageDir)
            {
                return true;
            }
            return false;
        }

        public static Account GetLastAccount()
        {
            return null;
        }

        public static bool SaveAccount(Account aAccount)
        {
            // fileName     AccountId.dat
            // HeaderLine   AccountId_Customer
            // DataLine     Transaction_Type_Transaction_Amount_Transaction_Date_Location
            
            using (StreamWriter sw = File.CreateText(MainStorageDir + "\\" + aAccount.AccountNumber + ".dat"))
            {
                sw.WriteLine(aAccount.AccountNumber + "_" + aAccount.CustomerName);

                foreach (Transaction tr in aAccount.ListOfTransactions)
                {
                    string TransactionLine = tr.TransactionTypeString + "_" + tr.MoneyAmount + "_" + 
                        tr.TransactionDate.ToString("yyyy:MM:dd HH:mm") + "_" + tr.LocationString;
                    
                    sw.WriteLine(TransactionLine);
                }
            }

            return false;
        }
    }
}
