using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;

namespace SoapFormatterSolution
{
  
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void Serialize()
        {
            Hashtable address = new Hashtable();
            address.Add("Jeff", "123 Main Street, Redmond, WA 98052");
            address.Add("Fred", "987 Pine Road, Phila., PA 19116");
            address.Add("Mary", "PO Box 112233, Palo Alto, CA 94301");

            FileStream fs = new FileStream("Datafile.soap", FileMode.Create);
            SoapFormatter formatter = new SoapFormatterSolution();

        }


    }
}
