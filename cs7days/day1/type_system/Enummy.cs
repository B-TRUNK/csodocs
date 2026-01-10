using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csodocs.cs7days.day1.type_system
{
    public class Enummy
    {

        private string[] Items = new string[Enum.GetNames<Seasons>().Length];
        private enum Seasons : ushort{
            summer = 0,
            winter = 1,
            autoumn = 2,
            spring = 3
        }

        public Enummy()
        {
            var values = Enum.GetValues<Seasons>();
            for (int i = 0; i < values.Length; i++)
            {
                Items[i] = values[i].ToString();
            }
        }

        public void ShowEnumValues()
        {
            for(ushort i = 0; i < Items.Length; i++)
            {
                Console.WriteLine(Items[i]);
            }
        }

    }
}