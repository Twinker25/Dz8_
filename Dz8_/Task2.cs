using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz8_
{
    struct Number
    {
        public int num;

        public Number(int Num)
        {
            num = Num;
        }
        public string Binary()
        {
            return Convert.ToString(num, 2);
        }

        public string Octal()
        {
            return Convert.ToString(num, 8);
        }

        public string Hexadecimal()
        {
            return Convert.ToString(num, 16);
        }
    }
}
