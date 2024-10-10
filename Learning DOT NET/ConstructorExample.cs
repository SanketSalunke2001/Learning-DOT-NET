using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_DOT_NET
{
    public class ConstructorExample
    {
        public int varInt;
        public string varString;
        public static int StaticInt;
        public ConstructorExample() // when No value is passed then this will call
        {
            varInt = 100;
            varString = "i am Sanket";
        }
        public ConstructorExample(int varInt, string varstring) // when value is passed then this will call
        {
            this.varInt = varInt;         // this means it related with the class because of same names so for that we use This keyword
            this.varString = varstring;
        }

        // copy constructor
        public ConstructorExample(ConstructorExample obj)
        {
            this.varInt= obj.varInt;
            this.varString = obj.varString;
        }
        // static constructor 
        static ConstructorExample() // parameter is also not possible just like default constructor
        {
            StaticInt = 100;        // it can access because it is an static variable
        }


    }
}
