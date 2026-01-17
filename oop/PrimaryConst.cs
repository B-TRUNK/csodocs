using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csodocs.oop
{
    public class PrimaryConst(int _age)
    {
        private int age = _age;

        public int GetAge()
        {   
            return this.age;
        }
    }
}