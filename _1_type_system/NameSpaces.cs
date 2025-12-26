using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csodocs._1_type_system
{
    public class NameSpaces
    {
        
        private string name = "Default";
        private int age = 0;

        // Default Constructor
        public NameSpaces()
        {
            
        }

        // expression-bodied member (lambda like) rather than { }
        // tuple deconstruction assignment
        public NameSpaces (string nme, int ag) =>
        (name, age) = (nme, ag);


        public void setName(string name)
        {
            this.name = name;
        }

        public string? getName()
        {
            return name;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public int? getAge()
        {
            return age;
        }


    }
}