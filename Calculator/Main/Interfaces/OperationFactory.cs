using Calculator.Main.Classes;
using Calculator.Main.Enumerators;

namespace Calculator.Main.Interfaces
{
    public static class OperationFactory
    {
        //The factory that creates a new operations in which operation is selected in the OperationType 
        public static IOperation CreateOperation(OperationType operation)
        {
            switch (operation)
            {
                case OperationType.Multiplication:
                    return new Multiplication();

                case OperationType.Division:
                    return new Division();

                case OperationType.Addition:
                    return new Addition();

                case OperationType.Subtraction:
                    return new Subtraction();

                default:
                    return null;
            }

        }
    }
}
