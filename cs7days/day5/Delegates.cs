using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csodocs.cs7days.day5
{
    public class Delegates
    {
        public delegate void Callback(string message);

        // Create a method for a delegate.
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

        public object? Instantiate()
        {
            Callback handler = DelegateMethod;
            return handler.DynamicInvoke("Hello World from Delegate");
        }
    }
}