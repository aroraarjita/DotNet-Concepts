using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddNumbers(10, 20);
            //AddNumbers(10, 20, new int[] { 30, 40, 50 });
            //AddNumbers(10, 20, new int[] { 30, 40, 50 });
            //AddNumbers(10, 20, 30, 40, 50);
            //AddNumbers(10, 20, new object[] {30,40,50});

            AddNumbers(10);
            //AddNumbers(10, c:3);

            AddNumbers(10, 20);
            AddNumbers(10, 20, new int[] { 30, 40, 50 });


            Console.ReadLine();

        }


        public static void AddNumbers(int firstNumber, int secondNumber)
        {
            AddNumbers(firstNumber, secondNumber, null);
        }

        //public static void AddNumbers(int firstNumber, int secondNumber, params object[] restOfNumbers)
        //{
        //    int result = firstNumber + secondNumber;

        //    if (restOfNumbers != null)
        //    {
        //        foreach (int number in restOfNumbers)
        //        {
        //            result += number;
        //        }
        //    }

        //    Console.WriteLine("Sum = " + result);

        //}

        //public static void AddNumbers(int firstNumber, int secondNumber, int[] restOfNumbers)
        //{
        //    int result = firstNumber + secondNumber;

        //    if (restOfNumbers != null)
        //    {
        //        foreach (int number in restOfNumbers)
        //        {
        //            result += number;
        //        }
        //    }

        //    Console.WriteLine("Sum = " + result);

        //}


        public static void AddNumbers(int a, int b = 20, int c = 30)
        {
            int result = a + b + c;

            Console.WriteLine("Sum = " + result);

        }

        public static void AddNumbers(int firstNumber, int secondNumber, [Optional] int[] restOfNumbers)
        {
            int result = firstNumber + secondNumber;

            if (restOfNumbers != null)
            {
                foreach (int item in restOfNumbers)
                {
                    result += item;
                }
            }

            Console.WriteLine(result);
        }

    }
}
