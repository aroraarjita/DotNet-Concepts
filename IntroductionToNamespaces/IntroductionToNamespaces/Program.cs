using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;



namespace IntroductionToNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PATA.ClassA.Print();
            PATB.ClassA.Print();
            Console.ReadLine();
 
        }
    }
}

//namespace ProjectA
//{
//    namespace TeamA
//    {
//        class ClassA
//        {
//            public static void Print()
//            {
//                Console.WriteLine("This is Team A");
//            }
//        }
//    }

//}

//namespace ProjectA
//{
//    namespace TeamB
//    {
//        class ClassA
//        {
//            public static void Print()
//            {
//                Console.WriteLine("This is Team B!");
//            }

//        }
        
//    }
//}
