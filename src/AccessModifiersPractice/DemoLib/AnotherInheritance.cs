using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib
{
    public class AnotherInheritance:InheritanceDemoClass
    {
        public void AnotherHello()
        {
            InternalMethod();
            ProtectedInternalMethod();
            PrivateProtectedMethod();
            ProtectedMethod();
            PublicMethod();
        }
    }
}
