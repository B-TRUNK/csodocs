using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csodocs.cs7days.day4
{
    public class GenMethods
    {
        // Generic Method
        public void swap<V>(ref V lhs, ref V rhs)
        {
            V temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}