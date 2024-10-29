using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Main.Interfaces;

namespace Calculator.Main.Classes
{
    public class Division : IOperation
    {
        public double Execute(double number1, double number2)
        {
            return number1 / number2;
        }
    }
}
