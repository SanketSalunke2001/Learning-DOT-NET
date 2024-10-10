using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_DOT_NET
{
    public interface Interface
    {
        void sum(int a, int b);    // this is definition
        void diff(int a, int b);
        void TestMethod();
        void firstmethod();
    }

    public interface iTest2
    {
        void TestMethod2();
        void firstmethod();
    }

    // we could also inherit class along with interface in a child class.

    public class Parentclass
    {
        void ParentClassMethod()
        {
            Console.WriteLine(" i am parent class method");
        }
    }

    public class Class1 : Parentclass, Interface, iTest2
    {
        public void diff(int a, int b)
        {
            Console.WriteLine("Substraction of two numbers is " + (a - b));
        }

        //public void firstmethod() //  we can acces and it is not mendatory to know which method was called.// ek hie body mai kam bann jaiga
        //{
        //    Console.WriteLine("i am first method");
        //}
        void Interface.firstmethod() // to use specific for iTest
        {
            Console.WriteLine("i am iTest method");
        }
        void iTest2.firstmethod() // for iTest 2
        {
            Console.WriteLine("i am iTest 2 method");
        }

        public void sum(int a, int b)
        {
            Console.WriteLine("Sum of two numbers is " + (a + b));
        }

        public void TestMethod()
        {
            Console.WriteLine(" ");
        }

        public void TestMethod2()  // this is child class method
        {
            Console.WriteLine("i am iTest Testmethod2");
        }

        public void childclassmethod()
        {
            Console.WriteLine("i am child class method");
        }


    }
}