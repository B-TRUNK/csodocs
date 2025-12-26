using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csodocs._1_type_system
{
    public class NameSpaces
    {
        
        private string? name;
        private int? age;

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