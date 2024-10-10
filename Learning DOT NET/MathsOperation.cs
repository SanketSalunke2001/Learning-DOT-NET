
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_DOT_NET
{
    public class MathsOperation
    {
        int varl = 10;           // we can change the value os varl
                                 //public void Sum(int a,int b)
                                 //{
                                 //    int result =a + b;            
                                 //    Console.WriteLine(result);

        //}

        public int Sum(int x, int y)
        {
            int result = x + y;
            return result;
        }


        // method with array

        public int sum(int[] array1)
        {
            int result = 0;
            foreach (int value in array1)
            {
                result += value;  //result=result+value;
            }
            return result;
        }

        // return type of array

        public int[] Arrayfromno(int a, int b, int c)
        {
            int[] result = new int[3];
            result[0] = a;
            result[1] = b;
            result[2] = c;
            return result;   // this will return the int of array which is named as result
        }

        // params keyword :- we can pass no. of values

        //public int Add(params int[] array)
        //{
        //    int result = 0;
        //    foreach (int value in array)
        //    {
        //        result = result + value;
        //    }
        //    return result;
        //}


        public int Add(int a, params int[] array)  // yaha pehli value Add(24) ki jo hogi usko int le lega
        {
            int result = 0;
            foreach (int value in array)
            {
                result = result + value;
            }
            return result;
        }


        

    }
}
