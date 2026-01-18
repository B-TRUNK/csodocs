using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csodocs.oop
{
    public struct Structy
    {
         private string Name;
         private int    Age;

         public string name => Name;

         public Structy(string Name, int Age)
        {
            this.Name = Name;
            this.Age  = Age;
        }

        public string GetPersonData()
        {
            return (this.Name + this.Age).ToString();
        }

        // for testing only, but structs shouldn't be mutable
        public void SetName(string newName)
        {
            this.Name = newName;
        }

    }
}