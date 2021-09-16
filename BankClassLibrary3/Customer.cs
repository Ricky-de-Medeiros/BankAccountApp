using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClassLibrary3
{
    public class Customer
    {
        
        string _CustomerName;
        DateTime _DateOfBirth;
        string _PhoneNumber;
        string _Address;

        public string CustomerName
        {
            get
            {
                return _CustomerName;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return _DateOfBirth;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return _PhoneNumber;
            }
            set
            {
                _PhoneNumber = value;
            }
        }

        public string Address
        {
            get
            {
                return _Address;
            }
            set
            {
                _Address = value;
            }
        }
        public Customer(string aCustomerName, DateTime aDateOfBirth, string aPhoneNumber = null, string aAddress = null)
        {
            _CustomerName = aCustomerName;
            _DateOfBirth = aDateOfBirth;
            _PhoneNumber = aPhoneNumber;
            _Address = aAddress;
            
        }

        // copy constructor
        public Customer(Customer accountCustomer)
        {
            _CustomerName = accountCustomer._CustomerName;
            _DateOfBirth = accountCustomer._DateOfBirth;
            _PhoneNumber = accountCustomer._PhoneNumber;
            _Address = accountCustomer._Address;
        }

        //public string CustomerName
        //{

        //}

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
