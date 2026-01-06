using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csodocs.cs7days.day1.type_system
{
    public class FullDelegate
    {
        private delegate void CallItBack(string message);

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
        



    }
}