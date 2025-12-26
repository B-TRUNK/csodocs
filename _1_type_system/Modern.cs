using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csodocs._1_type_system
{

    // C# 12+ Member Constructor
    public class Modern(string _title, string _role)
    {
        private string title => _title;
        private string role => _role;

    }
}