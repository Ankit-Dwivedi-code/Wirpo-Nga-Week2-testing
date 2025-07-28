using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_MathLibrary_Testing_using_NUnit
{
    public class Calculator
    {
        public int Add(int x, int y) { return x + y; }

        public int Subtract(int x, int y) => x - y; //returning value using lambda expression "=>"
    }
}
