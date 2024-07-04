using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesOfEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Gender gender = (Gender)3;
            int Num = (int)Gender.Unknown;

            Gender gender1 = (Gender)Season.Winter;

            Console.WriteLine("Gender is {0}", gender);
            Console.WriteLine("Number is {0}", Num);
            Console.WriteLine("Gender corresponding to winter is {0}", gender1);


            //int[] Values = (int[])Enum.GetValues(typeof(Gender));

            //foreach(int value in Values)
            //{
            //    Console.WriteLine(value);
            //}

            //string[] Names = (string[])Enum.GetNames(typeof(Gender));

            //foreach(string name in Names)
            //{
            //    Console.WriteLine(name);
            //}

            Console.ReadLine();
        }
    }

    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

    public enum Season
    {
        Winter = 1,
        Spring = 2,
        Summer = 3
    }

}
