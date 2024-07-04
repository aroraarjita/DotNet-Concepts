using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
           int result = Add(10, 20);
        }

        [Obsolete("Please use Add(List<int> NumberList) method")]
        static int Add(int Number1, int Number2)
        {
            return Number1 + Number2;
        }

        static int Add(List<int> NumberList)
        {
            int sum = 0;
            foreach(int number in NumberList)
            {
                sum += number;
            }

            return sum;
        }
    }
}
