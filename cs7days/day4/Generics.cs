using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csodocs.cs7days.day4
{
    public class Generics<V>
    {
        
        public V Data {get; set;} // V is a placeholder type

        public void PrintData(V value)
        {
            Console.WriteLine(value);
        }

    }
}