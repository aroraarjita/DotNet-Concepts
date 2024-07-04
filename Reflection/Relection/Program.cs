using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Relection
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            Type customerType = C1.GetType();
            //Type customerType = typeof(Customer);
            //Type customerType = Type.GetType("Relection.Customer");
            Console.WriteLine("Full Name = {0}", customerType.FullName);
            Console.WriteLine("Just the Name = {0}", customerType.Name);
            Console.WriteLine("Just the namespace = {0}", customerType.Namespace);


            Console.WriteLine("Properties to customers");
            PropertyInfo[] properties = customerType.GetProperties();

            foreach (PropertyInfo propertyInfo in properties)
            {
                Console.WriteLine(propertyInfo.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Methods in Customer Class");
            MethodInfo[] methodInfos =  customerType.GetMethods();
            foreach (MethodInfo methodInfo in methodInfos)
            {
                Console.WriteLine(methodInfo.ReturnType.Name + "" + methodInfo.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Constructors in Customer class");
            ConstructorInfo[] constructorInfos = customerType.GetConstructors();
            foreach( ConstructorInfo constructorInfo in constructorInfos)
            {
                Console.WriteLine(constructorInfo.ToString());
            }


            Console.ReadLine();

        }

    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int ID, string Name)
        {
            this.Id = ID;
            this.Name = Name;
        }

        public Customer()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }

        public void PrintId()
        {
            Console.WriteLine("Id = {0}", this.Id);
        }

        public void PrintName()
        {
            Console.WriteLine("Name ={0}", this.Name);
        }



    }
}
