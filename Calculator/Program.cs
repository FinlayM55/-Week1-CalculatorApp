CalculatorApp();

void CalculatorApp()
{

    int firstnumber = 0;
    int secondnumber = 0;
    int result = 0;
    int choice = 0;

    Console.WriteLine("Type in the first number followed by the Enter key");
    firstnumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Type in the second number followed by the Enter key");
    secondnumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Choose an option from the following list:");
    Console.WriteLine("1 - Add");
    Console.WriteLine("2 - Subtract");
    Console.WriteLine("3 - Divide");
    Console.WriteLine("4 - Multiply");

    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1)
    {
        result = firstnumber + secondnumber;
        Console.WriteLine("Adding {0} and {1} equals {2}", firstnumber, secondnumber,  result);
    }
    else if(choice == 2)
    {
        result = firstnumber - secondnumber;
        Console.WriteLine("Subtracting {0} and {1} equals {2}", firstnumber, secondnumber, result);
    }
    else if (choice == 3)
    {
        result = firstnumber / secondnumber;
        Console.WriteLine("Dividing {0} and {1} equals {2}", firstnumber, secondnumber, result);
    }
    else if (choice == 4)
    {
        result = firstnumber * secondnumber;
        Console.WriteLine("Multiplying {0} and {1} equals {2}", firstnumber, secondnumber, result);
    }



    Console.WriteLine("The result is {0}", result);
}


