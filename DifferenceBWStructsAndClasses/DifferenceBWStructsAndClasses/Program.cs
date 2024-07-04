using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceBWStructsAndClasses
{
    interface ICusomer1
    {
        void Print1();
    }

    interface ICustomer2 : ICusomer1
    {
        void Print2();
    }

 





    public class Customer: ICustomer2
    {
   
       public void Print2()
        {
            Console.WriteLine("This is Print2");
        }

        public void Print1()
        {
            Console.WriteLine("This is Print1");
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            ICusomer1 customer = new Customer();
            customer.Print1();
         



        }
    }
}
