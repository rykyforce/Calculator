using Calculator.Main.Enumerators;
class Program
{
    //UI strings to add
    static string ui_line = "######################################################################";
    static string ui_name = "########################";
    static State CurrentState = State.Main;
    static void Main() 
    {
        while (true)
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
        Console.WriteLine("1. Operation\n2. Help");
        string? response = Console.ReadLine();
        if (response != null) 
        {
            Console.WriteLine(response);
            CurrentState = State.Operation;

        }

    }

    static void OperationState() 
    {
    Console.WriteLine("Entered Operation");
    string? response = Console.ReadLine();
    }

    static void Header()
    {
        Console.WriteLine(ui_line);
        Console.WriteLine(ui_name + " Operation Calculator " + ui_name);
        Console.WriteLine(ui_line);
    }

}

    



