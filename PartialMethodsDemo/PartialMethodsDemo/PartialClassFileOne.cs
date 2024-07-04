using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialMethodsDemo
{
    public partial class SamplePartialClass
    {

        public void PublicMethod()
        {
            Console.WriteLine("Public Method Invoked");
            SamplePartialMethod();
        }
    }
}
