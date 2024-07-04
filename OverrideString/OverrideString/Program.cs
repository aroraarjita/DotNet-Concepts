using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideString
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            C1.FirstName = "Arjita";
            C1.LastName = "Arora";

            Customer C2 = new Customer();
            C2.FirstName = "Arjita";
            C2.LastName = "Arora";

            Console.WriteLine(C1 == C2);
            Console.WriteLine(C1.Equals(C2));

            Console.WriteLine(C1.GetHashCode());

            Console.ReadLine();
        }
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }

            if(!(obj is Customer))
            {
                return false;
            }

            return this.FirstName == ((Customer)obj).FirstName &&
                this.LastName == ((Customer)obj).LastName;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();

        }


    }
}
