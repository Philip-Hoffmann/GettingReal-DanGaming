using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal_DanGaming.Models
{
    public class Employee
    {
        private string _id;
        private string _pincode;
        private DateTime date;


        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Pincode
        {
            get { return _pincode; }
            set { _pincode = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        /*
        public string GetEmployeeInfo()
        {
            return $"Employee ID: {_id}, Pincode: {_pincode}, Date: {date:dd-MM-yyyy}";
        }

        
        public bool IsValidPincode()
        {            
            return !string.IsNullOrEmpty(_pincode) && _pincode.Length == 4 && _pincode.All(char.IsDigit);
        }
        */

        sfsdfsdff

    }


}        





