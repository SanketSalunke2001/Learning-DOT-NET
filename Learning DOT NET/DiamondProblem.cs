using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_DOT_NET
{
    public class A
    {
        public virtual void method()
        {
            Console.WriteLine("Mohit");
        }
    }
    public class B : A
    {
        public override void method()
        {
            Console.WriteLine("Mohit 1 is override by B class");
        }
    }
    public class C : A
    {
        public override void method()
        {
            Console.WriteLine("Mohit 1 is override by C class");
        }
    }

    public class D : B   // this problem is known as diamond problem
    {

    }
         
}
