using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csodocs._1_type_system
{
    public record RecordClass
    {

        public required string Name {get; init;}
        public required ushort Age {get; init;}
        
    }
}