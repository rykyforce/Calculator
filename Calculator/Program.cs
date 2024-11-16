using Calculator.Main.Enumerators;
using Calculator.Main.Interfaces;
class Program
{
    //UI strings to add
    static string ui_line = "######################################################################";
    static string ui_name = "########################";
    static State CurrentState = State.Main;
    static bool isPlaying = true;
    
    static void Main() 
    {
        while (isPlaying)
        {
            switch (CurrentState)
            {
                case State.Main:
                    Console.Clear();
                    MainState();
                    break;
                case State.Operation:
                    Console.Clear();
                    OperationState();
                    break;
                case State.Help:
                    Console.Clear();
                    break;
                default:
                    break;
            }
        }

    }


    static void MainState()
    {
        Header();
        Console.WriteLine("Please select an option:");
        Console.WriteLine("" +
            "1. Operation\n" +
            "2. Exit\n" +
            "");
        string? response = Console.ReadLine();
        if (response != null) 
        {
            switch (response)
            {
                case "1":
                    CurrentState = State.Operation;
                    break;

                case "2":
                    Environment.Exit(0);
                    break;

                default:

                    break;
            }
            if (response == "1")
            {
            }
            Console.WriteLine(response);

        }

    }

    static void OperationState() 
    {
        //Variables
        double num1 = 0;
        double num2 = 0;
        double result = 0;
        bool wantToContinue = true;
        bool madeOperation = false;

        while (wantToContinue) 
        {
            Console.Clear();
            Header();
            Console.WriteLine("Entered Operation");
            Console.WriteLine("-> Please enter the operations like: 10 * 10. We only accept one operation at the time\n" +
                "-> Currently we support: multiplication(*), addition(+), subtraction(-), division(/)\n" +
                "-> If you wanna go back please write back");
            string response = Console.ReadLine();
            if (response != null)
            {
                if (response == "back") 
                {
                    CurrentState = State.Main;
                    break;
                }
                IOperation selectedOperation;
                List<string> resArray = response.Split(' ').ToList();
                if (resArray.Count == 3)
                {
                    if (double.TryParse(resArray[0], out num1) && double.TryParse(resArray[2], out num2))
                    {
                        switch (resArray[1])
                        {
                            case "+":
                                selectedOperation = OperationFactory.CreateOperation(OperationType.Addition);
                                result = selectedOperation.Execute(num1, num2);
                                madeOperation = true;
                                break;
                            case "-":
                                selectedOperation = OperationFactory.CreateOperation(OperationType.Subtraction);
                                result = selectedOperation.Execute(num1, num2);
                                madeOperation = true;
                                break;
                            case "*":
                                selectedOperation = OperationFactory.CreateOperation(OperationType.Multiplication);
                                result = selectedOperation.Execute(num1, num2);
                                madeOperation = true;
                                break;
                            case "/":
                                selectedOperation = OperationFactory.CreateOperation(OperationType.Division);
                                result = selectedOperation.Execute(num1, num2);
                                madeOperation = true;
                                break;
                            default:
                                Console.WriteLine("Selected operation is not on the accepted ones");
                                Console.WriteLine("Please press any key to try again");
                                madeOperation = false;
                                break;
                        }
                        if (madeOperation)
                        {
                            Console.WriteLine("The result was: " + result);
                            Console.WriteLine("Please press any key to try again");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.ReadKey();
                        }

                    }
                    else
                    {
                        Console.WriteLine("Wrong formating please press any key to try again");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Wrong formating please press any key to try again");
                    Console.ReadKey();
                }
            }
            

        }
    }

    static void Header()
    {
        Console.WriteLine(ui_line);
        Console.WriteLine(ui_name + " Operation Calculator " + ui_name);
        Console.WriteLine(ui_line);
    }

}

    



