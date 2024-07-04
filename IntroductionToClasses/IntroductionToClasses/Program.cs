using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToClasses
{
    class Customer
    {
        string _firstName;
        string _lastName;
        
        public Customer():this("Param", "Constructor")
        {

        }


        public Customer(string FirstName, string LastName)
        {
            this._firstName = FirstName;
            this._lastName = LastName;

        }

        public void PrintFullName()
        {
            Console.WriteLine("Full name is {0}", this._firstName + " " + this._lastName);
        }

        ~Customer()
        {

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer("Arjita", "Arora");
            Customer cust = new Customer();
            cust.PrintFullName();
            Console.ReadLine();
        }

    }
}
