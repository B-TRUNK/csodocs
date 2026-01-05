using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csodocs.cs7days.day1.type_system
{
    public class ValRefOut
    {
        // Pass By Value
        public int PassByValue(int i)
        {
            return i + 1;
        }

        // Pass By Reference
        public int PassByReference(ref int j)
        {
            return j + 1;
        }

        // out Modifier
        public void OutModified(out int z) // Pass as output using 'out'
        {
            // Cannot read 'i' before assigning a value
            z = 10 ;  // Must assign a value before returning
        }
    }
}