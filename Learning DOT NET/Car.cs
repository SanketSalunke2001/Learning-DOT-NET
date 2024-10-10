using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_DOT_NET
{
    public class Car
    {
        //properties;
        public string Brand { get; set; }
        public string Name { get; set; }
        public int Noofseats { get; set; }
        public string color { get; set; }

        // methods

        // access modifier | return type | method name | method parameters

        public void Accelerator(int pressure)
        {
            int speed = pressure * 10;
            Console.WriteLine("the speed is "+speed);
        }
        public void brake(int pressure)
        {
            int speed = pressure / 10;
            Console.WriteLine("speed of car is "+speed);
        }
    }
}
