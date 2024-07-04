using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyOne
{
    class AssemblyClassOneSameProject
    {
        public void Test()
        {
            AssemblyOne.AssemblyOneClass instance = new AssemblyOne.AssemblyOneClass();
            instance.Print();
        }
    }
}
