using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_DOT_NET
{


    public class Parent    // but yeh class ka object child class ko access nahi kr sakta
    {

        public Parent()   //1
        {
            Console.WriteLine("i am parent class constructor");
        }
        static Parent()   //2
        {
            Console.WriteLine("i am static parent class constructor");
        }
        public void Parentmethod()
        {
            Console.WriteLine("i an parent method");
        }
        public virtual void ParentMethod2()  // we can override this or we can change it further due to our requirements.// It is a concept of changing parent method functionality in a child class.
        {
            Console.WriteLine("i am virtual parent method");
        }
    }

    public class Child : Parent // humane iss class ko bataya ki tumara parent yeh hai yani Parent Class 

    {
        public Child()  //3
        {
            Console.WriteLine("i am child class constructor");
        }
        static Child()  //4
        {
            Console.WriteLine("i am static child class constructor");
        }
        public void Childmethod()     // is class ka object iss class ko and parent class ko access kr sakta hai
        {
            Console.WriteLine("i am child method");
        }

        public new void Parentmethod() // we can create same method in child of parent by using new keyword 
        {

        }


        public override void ParentMethod2() // we can sealed here then its child will not be able to inherit
        {
            Console.WriteLine("i am changed override parent method in child class");
        }
    }
    public class Child2 : Parent
    {
        public void Child2method()
        {
            Console.WriteLine("i am child 2 method");
        }
    }

    public class Grandchild : Child  // this grandclass class can access child and parent class // it can cannot access Child2 class
    {
        public void Grandchildmethod()
        {
            Console.WriteLine("i am grand child ");
        }
        public sealed override void ParentMethod2()
        {
            Console.WriteLine("i am changed override parent method in grand child class");
        }
    }


}
