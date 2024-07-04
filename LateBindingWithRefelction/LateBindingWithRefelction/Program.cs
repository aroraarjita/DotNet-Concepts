using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace LateBindingWithRefelction
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            Type customerType = executingAssembly.GetType("LateBindingWithRefelction.Customer");

            object customerInstance = Activator.CreateInstance(customerType);
            MethodInfo getFullNameMethod = customerType.GetMethod("GetFullName");

            string[] parameters = new string[2];
            parameters[0] = "Arjita";
            parameters[1] = "Arora";

            string fullName = (string)getFullNameMethod.Invoke(customerInstance, parameters);
            Console.WriteLine("Full Name - {0}", fullName);
            Console.ReadLine();

        }
    }


    public class Customer
    {
        public string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    }
}
