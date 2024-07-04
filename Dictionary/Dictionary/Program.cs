using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

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

            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();
            dictionaryCustomers.Add(customer1.ID, customer1);
            dictionaryCustomers.Add(customer2.ID, customer2);
            dictionaryCustomers.Add(customer3.ID, customer3);

            //if (!dictionaryCustomers.ContainsKey(customer1.ID))
            //{
            //    dictionaryCustomers.Add(customer1.ID, customer1);
            //}


            if (dictionaryCustomers.ContainsKey(135))
            {
                Customer customer = dictionaryCustomers[135];
            }


            Customer testCustomer;
            //bool itContains = dictionaryCustomers.TryGetValue(119, out testCustomer);


            //foreach (KeyValuePair<int,Customer> item in dictionaryCustomers)
            //{
            //    Console.WriteLine("Key is {0}", item.Key);
            //    Customer customer = item.Value;

            //    Console.WriteLine("Id = {0}, Name = {1} and Salary {2}", customer.ID, 
            //        customer.Name, customer.Salary);

            //    Console.WriteLine("-------------------------------------------------------");


            //}



            //foreach (int customerKey  in dictionaryCustomers.Keys)
            //{
            //    Console.WriteLine("Key is {0}", customerKey);
            //    Customer customer = dictionaryCustomers[customerKey];

            //    Console.WriteLine("Id = {0}, Name = {1} and Salary {2}", customer.ID,
            //        customer.Name, customer.Salary);

            //    Console.WriteLine("-------------------------------------------------------");


            //}


            if(dictionaryCustomers.TryGetValue(119, out testCustomer))
            {
                Console.WriteLine("Id is {0}, Name is {1} and Salary is {2}", testCustomer.ID,
                    testCustomer.Name, testCustomer.Salary);
            }
            else
            {
                Console.WriteLine("The key is not null");
            }

            Console.WriteLine("Total number of classes in dictionary is {0}", 
                dictionaryCustomers.Count());


            Console.WriteLine("Number of employess with salary greater than 4000 is {0}",
               dictionaryCustomers.Count(x => x.Value.Salary > 4000));




            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Before Removing third item");
            foreach (Customer customer in dictionaryCustomers.Values)
            {


                Console.WriteLine("Id = {0}, Name = {1} and Salary {2}", customer.ID,
                    customer.Name, customer.Salary);

                Console.WriteLine("-------------------------------------------------------");


            }


            //Remove an the item with salary 3500
            //dictionaryCustomers.Remove(119);


            //Console.WriteLine("-------------------------------------------");
            //Console.WriteLine("After Removing third item and before clear");
            //foreach (Customer customer in dictionaryCustomers.Values)
            //{


            //    Console.WriteLine("Id = {0}, Name = {1} and Salary {2}", customer.ID,
            //        customer.Name, customer.Salary);

            //    Console.WriteLine("-------------------------------------------------------");


            //}


            //Customer[] customers = new Customer[3];
            //customers[0] = customer1;
            //customers[1] = customer2;
            //customers[2] = customer3;


            List<Customer> customers = new List<Customer>();
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);


            Dictionary<int, Customer> dict = customers.ToDictionary(cust => cust.ID, cust => cust);

            //Print dictionary items
            foreach (KeyValuePair<int,Customer> item in dict)
            {
                Console.WriteLine("Key value is {0}", item.Key);
                Customer customer = item.Value;
                Console.WriteLine("Id is {0}, Name is {1} and Salary is {2}", customer.ID, 
                    customer.Name, customer.Salary);
            }






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
