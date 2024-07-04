using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegate
{

    public delegate void SampleDelegate(out int number);
    class Program
    {
        static void Main(string[] args)
        {
            //SampleDelegate del1, del2, del3, del4;
            //del1 = new SampleDelegate(SampleMethod1);
            //del2 = new SampleDelegate(SampleMethod2);
            //del3 = new SampleDelegate(SampleMethod3);

            SampleDelegate del = new SampleDelegate(SampleMethod1);
            del += SampleMethod2;

            int DelegateReturnedParameterValue = -1;

            del(out DelegateReturnedParameterValue);
            


            //del4 = del1 + del2 + del3;
            //del4();

            Console.WriteLine("DelegateReturnedValue - {0}", DelegateReturnedParameterValue);

            Console.ReadLine();
        }

        public static void SampleMethod1(out int number1)
        {
            number1 = 1;
        }

        public static void SampleMethod2(out int number2)
        {
            number2 = 2;
        }


    }
}
