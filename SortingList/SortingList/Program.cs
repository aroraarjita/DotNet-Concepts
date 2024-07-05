using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 8, 7, 5, 2, 3, 4, 9, 6 };

            Customer customer1 = new Customer
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };

            Customer customer2 = new Customer
            {
                ID = 110,
                Name = "Pam",
                Salary = 6500

            };

            Customer customer3 = new Customer
            {
                ID = 119,
                Name = "John",
                Salary = 3500
            };

            Console.WriteLine("Numbers before sorting");
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            numbers.Sort();

            Console.WriteLine();
            Console.WriteLine("Numbers after sorting");
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }


            numbers.Reverse();
            Console.WriteLine();
            Console.WriteLine("Numbers in desecending order");
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            List<string> alphabets = new List<string>() { "B", "F", "D", "E", "A", "C" };

            Console.WriteLine();
            Console.WriteLine("Albhabets before sorting");
            foreach (string item in alphabets)
            {
                Console.WriteLine(item);
            }

            alphabets.Sort();
            Console.WriteLine();
            Console.WriteLine("Albhabets after sorting");
            foreach (string item in alphabets)
            {
                Console.WriteLine(item);
            }


            alphabets.Reverse();
            Console.WriteLine();
            Console.WriteLine("Albhabets in desecending order");
            foreach (string item in alphabets)
            {
                Console.WriteLine(item);
            }


            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);






            Console.ReadLine();
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

    }
}
