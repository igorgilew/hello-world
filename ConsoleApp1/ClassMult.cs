using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ClassMult
    {
        public int x { set; get; }
        public int y { set; get; }
        public int Mult()
        {
            return x * y;
        }

        public ClassMult(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
