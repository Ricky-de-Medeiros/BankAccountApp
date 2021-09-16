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
        const string CustStorageDir = @"C:\temp2";
        const string DateStringFormat = "yyyy:MM:dd HH:mm";

        //public static string CustomerName { get; private set; }

        static StorageUtilityFunctions()
        {
            if(!CheckMainDirectory())
            {
                Directory.CreateDirectory(MainStorageDir);
                Directory.CreateDirectory(CustStorageDir);
            }
        }
        static bool CheckMainDirectory()
        {
            if(Directory.Exists(MainStorageDir) && Directory.Exists(CustStorageDir))
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
                        tr.TransactionDate.ToString(DateStringFormat) + "_" + tr.LocationString;
                    
                    sw.WriteLine(TransactionLine);
                }
            }

            // File name       CustomerName.dat
            // Header          CustomerName_BirthDate_Phone
            // DataLines       AddressLine1\nAddressLine2\nAddressLine3 ...
              
            
            FileInfo FileInfoObject = new FileInfo(CustStorageDir + "\\" + aAccount.CustomerName + ".dat");

            using (StreamWriter sw = FileInfoObject.CreateText())
            {
                sw.WriteLine(aAccount.CustomerName + "_" + aAccount.CustomerBirthDate.ToString(DateStringFormat) + "_" +
                    aAccount.CustomerPhone);


                string[] addressLines = aAccount.CustomerAddress.Split(new char[] { '\r', '\n' });

                foreach (string addressLine in addressLines)
                {
                    sw.WriteLine(addressLine);
                }

                return false;
            }
        }
    }
}
