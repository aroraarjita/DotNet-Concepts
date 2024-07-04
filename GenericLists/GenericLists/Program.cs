using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000,
                Type = "RetailCustomer"
            };

            Customer customer2 = new Customer
            {
                ID = 110,
                Name = "Pam",
                Salary = 6500,
                Type = "RetailCustomer"

            };

            Customer customer3 = new Customer
            {
                ID = 119,
                Name = "John",
                Salary = 3500,
                Type = "RetailCustomer"
            };

            Customer customer4 = new Customer
            {
                ID = 104,
                Name = "John",
                Salary = 6500,
                Type = "CorporateCustomer"
            };

            Customer customer5 = new Customer
            {
                ID = 105,
                Name = "Sam",
                Salary = 3500,
                Type = "CorporateCustomer"
            };

            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);


            List<Customer> listCorporateCustomers = new List<Customer>();
            listCorporateCustomers.Add(customer4);
            listCorporateCustomers.Add(customer5);

            listCustomers.AddRange(listCorporateCustomers);

            foreach (Customer item in listCustomers)
            {
                Console.WriteLine("Name of the customer is {0} and customer type is {1}",
                    item.Name, item.Type);
            }

            //List<Customer> customers = new List<Customer>();
            //customers = listCustomers.GetRange(3, 2);

            listCustomers.InsertRange(0, listCorporateCustomers);


            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            foreach (Customer item in listCustomers)
            {
                Console.WriteLine("Name of the customer is {0} and Type is {1}",
                    item.Name, item.Type);
            }

            listCustomers.RemoveAll(x=> x.Type == "RetailCustomer");

            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            foreach (Customer item in listCustomers)
            {
                Console.WriteLine("Name of the customer is {0} and Type is {1}",
                    item.Name, item.Type);
            }




            Console.ReadLine();






        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }

    }
}
