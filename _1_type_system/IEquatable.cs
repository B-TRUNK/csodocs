using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csodocs._1_type_system
{
    public interface IEquatable<T>
    {
        bool Equals(T obj);
    }
}