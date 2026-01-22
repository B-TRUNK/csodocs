using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csodocs.oop
{
    public class BaseClass
    {
        public virtual void DoWork() {}
        public virtual int  WorkProperty => 0;

        /*
        This is just a property, equivalent to:
        public virtual int get_WorkProperty()
        {
            return 0;
        }
        */

    }
}