using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    abstract class Customer
    {
        int Id;
        public abstract void Print();
       

        public  void PrintImplemented()
        {
            Console.WriteLine("Print!!");
        }
    }

    public interface ICustomer
    {
        void  Print();
    }

    class Program: Customer
    {
        public override void Print()
        {
            Console.WriteLine("Print Method!");
        }

        static void Main(string[] args)
        {
            //Customer program = new Program();
            //program.Print();
            //Console.ReadLine();
        }


    }
}
