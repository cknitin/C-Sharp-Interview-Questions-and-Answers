using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProtectedLibrary
{
    public class Base
    {
        protected private void M()
        {
            Console.WriteLine("From Base.M()");
        }
    }

    public class D1 : Base
    {
        new public void M()
        {
            Console.WriteLine("From D1.M()");
            base.M();
        }
    }

    public class C
    {
        public void M()
        {
            Base b = new Base();
            // Base.M() is inaccessibledue to protection level
            //b.M();

            D1 d = new D1();
            d.M();
        }
    }


}
