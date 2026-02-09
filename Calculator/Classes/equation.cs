using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Classes
{
    internal class Equation
    {
        public int id;
        public string equation;
        public string result;
        public Equation(int id, string equation, string result)
        {
            this.id = id;
            this.equation = equation;
            this.result = result;
        }
    }
}
