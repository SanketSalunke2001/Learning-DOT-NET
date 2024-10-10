using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_DOT_NET
{
    public class GenericListExample
    {
        public void Listexample()
        {
            // define
            List<string> list = new List<string>();
            //List<int> list2 = new List<int>();
            list.Add("Sanket");
            list.Add("paras");
            list.Add("amit");
            list.Add("dipak");


            // Read the values
            string value = list[0];  // we dont have to convert
            string value1 = list[1];
            string value2 = list[2];
            string value3 = list[3];

            //insert 
            list.Insert(0, "Anil"); // sanket ki jagah anil aa jaiga


            // update
            list[1] = "Rohit"; // paras ki jagah rohit aa gaya


            // loop
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }


            // remove
            list.RemoveAt(0); // at particular index


            // clear
            list.Clear();

            // count
            int count = list.Count;

            // contain
            bool valuev = list.Contains("paras");
        }

        public void DictionaryExample()
        {
            // define
            Dictionary<int, string> dict = new Dictionary<int, string>();

            // add values
            dict.Add(1, "paras");
            dict.Add(2, "amit");
            dict.Add(3, "dipak");
            dict.Add(4, "sanket");

            // Read
            string value1 = dict[1];
            string value2 = dict[2];
            string value3 = dict[3];
            string value4 = dict[4];


            // update
            dict[1] = "divuansh";
            dict[2] = "divua";
            dict[3] = "duansh";
            dict[4] = "diansh";

            // loop to get keys
            foreach (var key in dict.Keys)
            {
                Console.WriteLine(key);
            }

            // loop to get values
            foreach (var value in dict.Values)
            {
                Console.WriteLine(value);
            }

            // to whole loop (keys and values both)
            foreach (var dictkeyvalue in dict)
            {
                Console.WriteLine("keys=" + dictkeyvalue.Key + "value=" + dictkeyvalue.Value);
            }

            // count
            int count = dict.Count;

            //remove
            dict.Remove(1);


        }

        public void stackgeneric()  // LIFO
        {
            // define
            Stack<int> stack = new Stack<int>(); // bas batana padega kis tarah ka stack bana rhe ho

            //to add elements we use puch
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            // to remove and delete
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();

            // to remove but not delete
            stack.Peek();
            stack.Peek();
            stack.Peek();
            stack.Peek();

            


        }

        public void Queuegeneric()//FIFO
        {
            Queue<int> queue = new Queue<int>(); // same as stack

            // to Add we use enqueue
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            // to delete
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            // to remove but not delete
            queue.Peek();



        }


        // If we want to add Class
        public void ListClassExample()
        {
            Employee emp1 = new Employee();
            emp1.Id = 101;
            emp1.Name = "paras";
            emp1.Salary = 410000;

            Employee emp2 = new Employee();
            emp2.Id = 102;
            emp2.Name = "Tanu";
            emp2.Salary = 430000;

            Employee emp3 = new Employee();
            emp3.Id = 103;
            emp3.Name = "Anil";
            emp3.Salary = 480000;


            // Ab aisi list banainge jismai yeh sare employee pade ho
            List<Employee> listemp = new List<Employee>(); // iss list mai saare employee aa jainge
            listemp.Add(emp1);
            listemp.Add(emp2);
            listemp.Add(emp3);


            // to add new employee
            listemp.Add(new Employee() { Id=104,Name="sanket",Salary=485555});



            // for loop
            foreach (Employee emp in listemp)
            {
                Console.WriteLine("Employee Id"+emp.Id);
                Console.WriteLine("Employee Name" + emp.Name);
                Console.WriteLine("Employee Salary" + emp.Salary);
            }
        }

    }
}
