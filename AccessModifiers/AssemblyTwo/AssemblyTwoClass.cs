using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssemblyOne;


namespace AssemblyTwo
{
    public class AssemblyTwoClass: AssemblyOne.AssemblyOneClass
    {
      public void Test()
        {
            AssemblyOne.AssemblyOneClass instance = new AssemblyOne.AssemblyOneClass();
            instance.Print();
        }


    }
}
