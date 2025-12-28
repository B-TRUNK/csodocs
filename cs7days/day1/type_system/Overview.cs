using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csodocs.cs7days.day1.type_system
{
    public class Overview
    {
        private double num;

        public void setNumber(double num)
        {
            this.num = num;
        }


        // type cast into double
        public double setInt()
        {
            int input = (int)num;
            return input;
        }

    }
}