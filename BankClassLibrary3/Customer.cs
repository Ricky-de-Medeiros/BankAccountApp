using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClassLibrary3
{
    public class Customer
    {
        
        public string CustomerName;
        DateTime DateOfBirth;
        public string PhoneNumber;
        public string Address;

        public Customer(string aCustomerName, DateTime aDateOfBirth, string aPhoneNumber = null, string aAddress = null)
        {
            CustomerName = aCustomerName;
            DateOfBirth = aDateOfBirth;
            PhoneNumber = aPhoneNumber;
            Address = aAddress;
            
        }

        // copy constructor
        public Customer(Customer accountCustomer)
        {
            CustomerName = accountCustomer.CustomerName;
            DateOfBirth = accountCustomer.DateOfBirth;
            PhoneNumber = accountCustomer.PhoneNumber;
            Address = accountCustomer.Address;
        }

        //void UpdatePhone(string aNewPhone)
        //{
        //    //TODO
        //}


        //// Update Address
        //void UpdateAddress(string aNewAddress)
        //{
        //    //TODO
        //}
    }
}
