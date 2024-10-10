using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_DOT_NET
{
    public class PropertiesExample
    {
        // Properties   

        private int abc;
        public int Testprop
        {
            get
            {
                return abc;
            }
            set
            {
                abc = value;
            }
        }
        // Automated property or Auto Implemented Property
        public int size { get; set; }


        // Read only properties :- this is only readable but we cannot set values for that
        public int MyProperty { get; private set; } // only this class can able to change the set but outer cannot.


        public void Setmyproperty()
        {
            MyProperty = 50;
            Console.WriteLine(writeonprop);
        }

        // write only properties
        public int writeonprop { private get; set; }

    }
}
