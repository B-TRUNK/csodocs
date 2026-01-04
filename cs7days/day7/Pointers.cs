using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csodocs.cs7days.day7
{
    public class Pointers
    {
        public unsafe void ReliableCode(int x)
            {
                int* ptr = &x;
                Console.WriteLine($"Value: {*ptr}");
                Console.WriteLine($"Address: 0x{(ulong)ptr:X}");
            }
    }
}