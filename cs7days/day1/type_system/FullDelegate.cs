using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csodocs.cs7days.day1.type_system
{
    public class FullDelegate
    {
        public delegate void CallItBack(string message);

        // Create a method for a delegate.
        private static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

        public void DelegateInstantiate()
        {
            // Instantiate the delegate.
            CallItBack handler = DelegateMethod;
            // Call the delegate.
            handler("Hello I'm a Delegate!");
        }

        public static void MethodWithCallback(int param1, int param2, CallItBack callItBack)
        {
            callItBack("The number is: " + (param1 + param2).ToString());
        }
        



    }
}