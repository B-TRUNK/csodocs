using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csodocs.cs7days.day1.type_system
{
    // Beginning with C# 12, you can define a primary constructor as part of the 
    // class declaration:
    public class PrimaryConstClass(int _x, string _name)
    {

        private int x = _x;
        private string name = _name;

    }
}