using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_DOT_NET // IN TERMS OF OBJECT
{
    public class StaticExample  // lifetime memory we use static
    {
        public int varint;
        public static int StaticVarInt;    // it does not defined with object and only accessible to static members

        public static void TestMethod()
        {
            Console.WriteLine("I am static method");
        }

        // for non static members we can assign static as well as non-static members
        public void TestMethod2()
        {
            varint = 20;
            StaticVarInt = 90;
        }


    }
}
