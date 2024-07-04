using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssemblyOne;

namespace AssemblyTwo
{
    public class AssemblyTwoClassOne: AssemblyOneClassI
    {
        public void Print()
        {
            AssemblyOne.AssemblyOneClassI A1 = new AssemblyOneClassI();
            base.ID = 101;


            AssemblyTwoClassOne A2 = new AssemblyTwoClassOne();
            

        }






    }
}
