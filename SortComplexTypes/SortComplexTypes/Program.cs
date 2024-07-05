using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortComplexTypes
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

            List<Customer> listCustomers = new List<Customer>(100);
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            //Before Sorting
            foreach (Customer item in listCustomers)
            {
                Console.WriteLine(item.Salary);
            }
            listCustomers.Sort();


            Console.WriteLine();
            //After Sorting
            foreach (Customer item in listCustomers)
            {
                Console.WriteLine(item.Salary);
            }


            SortByName sortByName = new SortByName();
            listCustomers.Sort(sortByName);


            //Sorting by name
            foreach (Customer item in listCustomers)
            {
                Console.WriteLine(item.Name);
            }


            //Before Sorting
            foreach (Customer item in listCustomers)
            {
                Console.WriteLine(item.Name);
            }


            listCustomers.Sort((c1,c2) => c1.ID.CompareTo(c2.ID));

            //After Sorting
            foreach (Customer item in listCustomers)
            {
                Console.WriteLine(item.Name);
            }


            Console.WriteLine("Do all customers have a salary greater than 5000 " + 
                listCustomers.TrueForAll(x => x.Salary > 5000));


            ReadOnlyCollection<Customer> readOnlyCustomers = listCustomers.AsReadOnly();

            Console.WriteLine("The count of collection is " + listCustomers.Capacity);
            listCustomers.TrimExcess();
            Console.WriteLine("The count of collection is " + listCustomers.Capacity);




            Console.ReadLine();




        }

    }

    public class Customer : IComparable<Customer>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }


        public int CompareTo(Customer other)
        {
            return this.Name.CompareTo(other.Name);
        }

    }

    public class SortByName : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
