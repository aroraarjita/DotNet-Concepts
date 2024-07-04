using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A Implementation");
        }
    }

    class B: A
    {
        public override void Print()
        {
            Console.WriteLine("B Implementation");
        }

    }

    class C : A
    {
        public override void Print()
        {
            Console.WriteLine("C Implementation");
        }
    }


    class D: C, B
    {

    }


    class Program
    {
        static void Main(string[] args)
        {
            D d = new D();
            d.Print();
        }
    }
}
