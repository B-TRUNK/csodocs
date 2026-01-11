using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csodocs._1_type_system
{

    public record Person(string _1stname, string _2ndname)
    {
        private string firstName = _1stname;
        private string secondName = _2ndname;

        public string printName()
        {
            return ($"{firstName} + {secondName}");
        }

    }
    
}