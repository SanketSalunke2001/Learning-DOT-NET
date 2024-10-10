using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_DOT_NET
{
    public class CollectionExamles
    {
        public void ArrayListCollection()
        {
            //how to define 
            ArrayList objArrayList = new ArrayList(); // yeh dotnet ki bani bani class hai

            // Add values
            objArrayList.Add(10); // value type insert kr rhe hai aur reference yani object mai covert kr dega
            objArrayList.Add("Test");
            objArrayList.Add(true);    // its boolean statement which means (true and false)
            objArrayList.Add(DateTime.Now);


            //Read values from the ArrayList
            int value1 = Convert.ToInt32(objArrayList[0]); // ab yaha pe convert tho kr dega object mai par to return particular data type value ke liyeh convert lagana padega
            string value2 = Convert.ToString(objArrayList[1]);
            bool value3 = Convert.ToBoolean(objArrayList[2]);
            DateTime value4 = Convert.ToDateTime(objArrayList[3]);

            
            // update
            objArrayList[2] = 100; // updated true to 100



            // Insert  :- yeh update nahi krta yeh uss jagah set hoga aur jo pehle waha tha usko niche kr dega
            objArrayList.Insert(1, "paras"); // 10,"paras","Test",true,Datetime.now



            // count
            int count = objArrayList.Count; // 3

            bool isvalue = objArrayList.Contains(10); // agar object 10 value contain krta hai tho true return kr dega




            // Remove
            objArrayList.Remove("Test"); // yeh test ko remove kr dega aur baki dono ko upper khiska dega
            objArrayList.RemoveAt(2);  // to remove from index



            // Remove all
            objArrayList.Clear(); // to remove all
        }

        public void HashTablecollection()  // we prefer this get elements faster or to sort elements much faster than array.
        {
            // hash table
            Hashtable objhash = new Hashtable();


            // Add value
            objhash.Add(1, "Test"); // here 1 is key
            objhash.Add("key2", 10);
            objhash.Add(2, DateTime.Now);
            objhash.Add(3, true);


            //Read(unboxing)

            string value1 = Convert.ToString(objhash[1]); // we have to give key in object
            int value2 = Convert.ToInt32(objhash["key2"]);
            DateTime value3 = Convert.ToDateTime(objhash[2]);
            bool value4 = Convert.ToBoolean(objhash[3]);


            // update :- we can update it on the basis of keys

            objhash["key2"] = 100;
            objhash[1] = 200;

            // count
            int count = objhash.Count;

            // to check contain

            bool isexist = objhash.Contains(10); // false aa jaiga

            // delete
            objhash.Remove("key");

            // to delete or clear all

            objhash.Clear();

            // to check how many keys are there

            foreach (object key in objhash.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (object item in objhash.Values)
            {
                Console.WriteLine(item);
            }
        }

        public void Stackoperation() // LIFO (last in first out)
        {
            Stack objstack = new Stack();

            // push to insert value
            objstack.Push(1);  // we can add any value
            objstack.Push("test");
            objstack.Push(DateTime.Now);
            objstack.Push(true);

            // peek :- to remove but cannot delete it
            bool valuepeek = Convert.ToBoolean(objstack.Peek()); // return value but do not delete it
            // hamesha usko last wali method yani true milega because kuch delete hie nahi kr rha


            // to get value | pop
            bool value1 = Convert.ToBoolean(objstack.Pop()); // returns value and delete it
            DateTime value2 = Convert.ToDateTime(objstack.Pop());
            string value3 = Convert.ToString(objstack.Pop());
            int value4 = Convert.ToInt32(objstack.Pop());


            // count
            int count = objstack.Count; //0

            // to clear
            objstack.Clear();
        }

        public void QueueOperation() // FIFO(first in first out)
        {
            Queue objqueue = new Queue();

            // Insert
            objqueue.Enqueue(1);
            objqueue.Enqueue(10);
            objqueue.Enqueue(14);
            objqueue.Enqueue(16);

            // delete
            int value1 = Convert.ToInt32(objqueue.Dequeue()); //1
            int value2 = Convert.ToInt32(objqueue.Dequeue()); // 10
            int value3 = Convert.ToInt32(objqueue.Dequeue());// 14
            int value4 = Convert.ToInt32(objqueue.Dequeue());// 16



            // peek
            int value = Convert.ToInt32(objqueue.Peek()); // 1 will be removed and har baar 1 hie milega
        }
    }
}
