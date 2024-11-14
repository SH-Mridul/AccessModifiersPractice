using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib
{
    public class InheritanceDemoClass : AccessDemo
    {
        private void SayHello()
        {
            PrivateProtectedMethod();
            ProtectedInternalMethod();
            ProtectedMethod();
            InternalMethod();
            PublicMethod();
        }
    }
}
