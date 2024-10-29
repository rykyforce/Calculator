using Calculator.Main.Interfaces;

namespace Calculator.Main.Classes
{
    public class Multiplication : IOperation
    {
        public double Execute(double number1, double number2)
        {
            return number1 * number2;
        }
    }
}
