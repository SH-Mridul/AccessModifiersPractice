using DemoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersPractice
{
    public class InheritanceDemo:AccessDemo
    {
        public void Test()
        {
            // in another project i can call this all method after inheritance
            ProtectedInternalMethod(); 
            ProtectedMethod();
            PublicMethod();
        }
    }
}
