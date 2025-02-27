﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            bool Equal = Calculator<string>.AreEqual("AB","AB");

            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else{
                Console.WriteLine("Not Equal");
            }

            Console.ReadLine();

        }

    }

    public class Calculator<T>
    {
        public static bool AreEqual(T Value1,T Value2)
        {
            return Value1.Equals(Value2);
        }
    }
}
