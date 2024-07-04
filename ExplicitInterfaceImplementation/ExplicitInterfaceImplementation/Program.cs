using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceImplementation
{
    interface I1
    {
        void InterfaceMethod();
    }

    interface I2
    {
        void InterfaceMethod();
    }




    class Program: I1, I2
    {

        public void InterfaceMethod()
        {
            Console.WriteLine("I1 Interface Method");
        }

        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 Interface Method");
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            program.InterfaceMethod();
            ((I2)program).InterfaceMethod();



            //I1 i1 = new Program();
            //I2 i2 = new Program();

            //i1.InterfaceMethod();
            //i2.InterfaceMethod();

            Console.ReadLine();
        }
    }

}
