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

        //Data Storage Layer
        public static Account GetLastAccount()
        {
            Account lastAccount = new Account();

            DirectoryInfo dirInfo = new DirectoryInfo(MainStorageDir);
            FileInfo[] fileInfoArray = dirInfo.GetFiles();

            // foreach(var fi in fileInfoArray) ....  too much coding
            // Instead use L.I.N.Q (Language Integrated Queries)

            FileInfo lastFileInfo = fileInfoArray.OrderByDescending(f => f.LastWriteTime).First();

            if (lastFileInfo.Length == 0)
            {
                return null;
            }

            string filePath = lastFileInfo.FullName;
            string fileName = Path.GetFileNameWithoutExtension(filePath);  // AccountId

            int accountId = Convert.ToInt32(fileName);

            string customerName;
            DateTime birthDate;
            string phoneNumber;
            string address;


            using (StreamReader sr = File.OpenText(filePath))
            {
                string headerLine = sr.ReadLine(); // AccountId_Customer

                string[] headerParts = headerLine.Split('_');
                customerName = headerParts[1];

                string nextLine;

                using (StreamReader srForCustomer = File.OpenText(CustStorageDir + "\\" + customerName + ".dat"))
                {
                    nextLine = srForCustomer.ReadLine(); // Header          CustomerName_BirthDate_Phone

                    headerParts = nextLine.Split('_');

                    birthDate = DateTime.ParseExact(headerParts[1], DateStringFormat, null);
                    phoneNumber = headerParts[2];

                    nextLine = srForCustomer.ReadLine();
                    address = nextLine;

                    while (!string.IsNullOrEmpty(nextLine))
                    {
                        string addressLine = nextLine;

                        address += "\n" + addressLine;

                        nextLine = srForCustomer.ReadLine();
                    
                    }

                }

                lastAccount = new Account(accountId, customerName, birthDate, phoneNumber, address);

                nextLine = sr.ReadLine();

                while(!string.IsNullOrEmpty(nextLine))
                {
                    // transaction line
                    string transactionLine = nextLine;
                    nextLine = sr.ReadLine();

                    string[] transactionParts = transactionLine.Split('_'); //Transaction_Type_Transaction_Amount_Transaction_Date_Location

                    string transactionType = transactionParts[0];

                    double transactionAmount = Convert.ToDouble(transactionParts[1]);
                    DateTime transactionDate = DateTime.ParseExact(transactionParts[2], DateStringFormat, null);
                    string transactionLocation = transactionParts[3];

                    switch (transactionType)
                    {
                        case "deposit":
                            lastAccount.DepositMoney(transactionAmount, transactionDate, transactionLocation);
                            break;
                        case "withdrawal":
                            lastAccount.WithdrawMoney(transactionAmount, transactionDate, transactionLocation);
                            break;
                    }


                    

                    //Transaction newTransaction = new Transaction(transactionAmount, transactionType,
                    //    transactionDate, transactionLocation);
                    ////
                    //lastAccount.AddTransaction(newTransaction);


                }
            }

            return lastAccount;
            //string[] accountFiles = Directory.GetFiles(MainStorageDir); // Does not guarantee the file order

            //if (accountFiles.Length == 0)
            //{
            //    return null;
            //}

            //string lastAccountFile = accountFiles[accountFiles.Length - 1];
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
