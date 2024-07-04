using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadStartDelegate
{
    public delegate void SumOfNumbersCallback(int SumOfNumbers);
    class Program
    {
        public static void PrintSumOfNumbers(int sum)
        {
            Console.WriteLine("Sum of numbers is =" + sum);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the target number");
            int target = Convert.ToInt32(Console.ReadLine());

            SumOfNumbersCallback callback = new SumOfNumbersCallback(PrintSumOfNumbers);

            Number number = new Number(target, callback);
            //ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(number.PrintNumbers);
            Thread T1 = new Thread(number.PrintNumbers);
            T1.Start();
            Console.ReadLine();


        }
    }


    class Number
    {
        int _target = 0;
        SumOfNumbersCallback callbackMethod;


        public Number(int target, SumOfNumbersCallback callback)
        {
            this._target = target;
            this.callbackMethod = callback;
        }

        public void PrintNumbers()
        {
            int sum = 0;

             for (int i = 1; i <= this._target; i++)
              {
                sum = sum + i;
              }

             if(callbackMethod!= null)
            {
                callbackMethod(sum);
            }

        }
    }
}
