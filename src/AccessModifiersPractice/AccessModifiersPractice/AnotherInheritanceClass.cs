using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersPractice
{
    public class AnotherInheritanceClass:InheritanceDemo
    {
        public void Test()
        {
            ProtectedInternalMethod();
            ProtectedMethod();
            PublicMethod();
        }
    }
}
