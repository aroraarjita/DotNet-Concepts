using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffBWStringAndBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string usrString = "C# ";
            usrString += "Video ";
            usrString += "Tutorial ";
            usrString += "for ";
            usrString += "Beginners";

            Console.WriteLine(usrString);


            StringBuilder userString = new StringBuilder();
            userString.Append("C# ");
            userString.Append("Tutorial ");
            userString.Append("for ");
            userString.Append("Beginners");

            Console.WriteLine(userString);

            Console.ReadLine();
        }
    }
}
