using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllExec
{
    class P3
    {
        interface I_interface
        {

            // This method is only
            // have its declaration
            // not its definition
            void display_1();

          
            public void Display_2()
            {
                Console.WriteLine("Hello!! Default Method");
            }
        }

        // A class that implements
        // the I_interface interface.
        class Example_Class : I_interface
        {

            // Providing the body
            // part of the method
            public void display_1()
            {
                Console.WriteLine("Hello!! Method");
            }

            // Main Method
            public static void Main(String[] args)
            {

                // Creating an object
                Example_Class t = new Example_Class();

                // Calling method
                t.display_1();

                // Creating an object
                I_interface obj = t;

                // Calling default method
              //  obj.Display_2();
            }
        }
    }
}