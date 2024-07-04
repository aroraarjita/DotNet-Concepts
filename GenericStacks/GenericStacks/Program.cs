using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStacks
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer
            {
                ID = 101,
                Name = "Mark",
                Gender = "Male"
            };

            Customer customer2 = new Customer
            {
                ID = 110,
                Name = "Pam",
                Gender = "Male"

            };

            Customer customer3 = new Customer
            {
                ID = 119,
                Name = "John",
                Gender = "Male"
            };

            Customer customer4 = new Customer
            {
                ID = 104,
                Name = "Mary",
                Gender = "Female"
            };

            Customer customer5 = new Customer
            {
                ID = 105,
                Name = "Suse",
                Gender = "Female"
            };

            Stack<Customer> stackCustomers = new Stack<Customer>();
            stackCustomers.Push(customer1);
            stackCustomers.Push(customer2);
            stackCustomers.Push(customer3);
            stackCustomers.Push(customer4);
            stackCustomers.Push(customer5);

            //Customer c1 = stackCustomers.Pop();
            //Console.WriteLine(c1.ID + "-" + c1.Name);
            //Console.WriteLine("Items left in the stack = " + stackCustomers.Count);

            //Customer c2 = stackCustomers.Pop();
            //Console.WriteLine(c2.ID + "-" + c2.Name);
            //Console.WriteLine("Items left in the stack = " + stackCustomers.Count);

            //Customer c3 = stackCustomers.Pop();
            //Console.WriteLine(c3.ID + "-" + c3.Name);
            //Console.WriteLine("Items left in the stack = " + stackCustomers.Count);

            //Customer c4 = stackCustomers.Pop();
            //Console.WriteLine(c4.ID + "-" + c4.Name);
            //Console.WriteLine("Items left in the stack = " + stackCustomers.Count);

            //Customer c5 = stackCustomers.Pop();
            //Console.WriteLine(c5.ID + "-" + c5.Name);
            //Console.WriteLine("Items left in the stack = " + stackCustomers.Count);



            Customer c11 = stackCustomers.Peek();
            Console.WriteLine(c11.ID + "-" + c11.Name);
            Console.WriteLine("Items left in the stack = " + stackCustomers.Count);

            Customer c21 = stackCustomers.Peek();
            Console.WriteLine(c21.ID + "-" + c21.Name);
            Console.WriteLine("Items left in the stack = " + stackCustomers.Count);

            Customer c31 = stackCustomers.Peek();
            Console.WriteLine(c31.ID + "-" + c31.Name);
            Console.WriteLine("Items left in the stack = " + stackCustomers.Count);

            Customer c41 = stackCustomers.Peek();
            Console.WriteLine(c41.ID + "-" + c41.Name);
            Console.WriteLine("Items left in the stack = " + stackCustomers.Count);

            Customer c51 = stackCustomers.Peek();
            Console.WriteLine(c51.ID + "-" + c51.Name);
            Console.WriteLine("Items left in the stack = " + stackCustomers.Count);




            Console.ReadLine();

        }
    }


    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

    }
}
