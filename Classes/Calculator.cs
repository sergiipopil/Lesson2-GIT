using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_GIT.Classes
{
    internal class Calculator
    {
        private int _x1;
        private int _x2;
        public Calculator(int x1, int x2)
        {
            _x1 = x1;
            _x2 = x2;
        }
        public int Sum()
        {
            return _x1 + _x2;
        }
    }
}
