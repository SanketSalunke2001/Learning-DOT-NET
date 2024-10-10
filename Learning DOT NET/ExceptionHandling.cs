using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_DOT_NET
{
    public class ExceptionHandling
    {
        //int _result_ = 10; // this(_result_) class level variable
        public void TestMethod( int value1)
        {
            
            try
            {                
                int i = 100;
                int j = 10;

                // throw new exception

                try // This is nested try and catch
                {
                    int a = 10000;
                    int b = 0;
                    int n = a / b;

                    Console.WriteLine(n);
                }
                catch(DivideByZeroException ex)
                {
                    Console.WriteLine("This is a nested try catch");
                }

                if (value1 < 10)
                {
                    throw new ArgumentException("value is less than 10 ");
                }
                int result = i / j;
                Console.WriteLine(result);
                Console.WriteLine("This is business");
            }

            catch(ArgumentException ex)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("this is argument exception");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("This divide by zero exception");
            }
            catch (Exception ex) // ex exception ko catch krta hai ya yaha catch ho jati hai exception 
            // yeh excetion sabka PAPA hai
            {
                Console.WriteLine("This is a generic acception" + ex.Message + ex.StackTrace);
            }

            finally // agar exception hume mil rhi hai and agar exception nahi tho bhi execute hoga
            {
                Console.WriteLine("This code will be executed irrespective of exception");
            }
        }
    }

}
