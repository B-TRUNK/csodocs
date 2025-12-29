using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csodocs.cs7days.day1.type_system
{
    public class NewClass
    {
        private int _number;
        
        // You can require callers to provide an initial value by defining a c
        // onstructor that's responsible for setting that initial value:
        public NewClass(int number) => _number = number;

    }
}