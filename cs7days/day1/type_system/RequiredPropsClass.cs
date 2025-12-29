using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csodocs.cs7days.day1.type_system
{
    public class RequiredPropsClass
    {
        // You can also use the required modifier on a property and allow callers to
        // use an object initializer to set the initial value of the property:
        public required string LastName {get; set;}
        public required string FirestName {get; set;}


    }
}