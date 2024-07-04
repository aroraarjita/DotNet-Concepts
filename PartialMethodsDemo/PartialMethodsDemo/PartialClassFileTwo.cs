using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialMethodsDemo
{
    public partial  class SamplePartialClass
    {
        partial void SamplePartialMethod();
        partial void SamplePartialMethod()
        {
            Console.WriteLine("SamplePartialMethod Invoked");
        }

    }
}
