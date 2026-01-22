using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csodocs.oop
{
    public class DerivedClass : BaseClass
    {
        public override void DoWork()
        {
            Console.WriteLine("You must do your Work");
            base.DoWork();
        }

        public override int WorkProperty
        {
            get {return 0;}
        }
    }
}