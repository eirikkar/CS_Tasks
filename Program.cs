namespace CS_Tests;

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance of the Greeting class
        Greetings greetings = new Greetings();

        // Create a new instance of the Fundament class
        Fundament fundament = new Fundament();

        // 2 double variables
        double num1 = 4;
        double num2 = 5;

        // 2 string facts and a string name
        string fact1 = "The first computer virus was created in 1983";
        string fact2 = "The earth is 4.54 billion years old";
        string name = "Eirik";

        // Gets 2 interesting facts
        Console.WriteLine(fundament.GetAInterestingFact(fact1));
        Console.WriteLine(fundament.GetAInterestingFact(fact2));

        // checks if double a is odd or even
        fundament.CheckOddOrEven(num1);

        // Sums 2 numbers from inside the void function
        fundament.SumTwoNumbers();

        // sums to doubles inside function
        Console.WriteLine(
            $"Sum of {num1} and {num2} is {fundament.SumTwoNumbersOfGivenType(num1, num2)}"
        );

        // English greeting
        greetings.SayHello();

        // Japanese greeting
        greetings.YoiTsuitachi();

        // Prints 10 fibonnaci numbers
        fundament.PrintFibonnaciSeries();

        //Reverses string name
        Console.WriteLine(fundament.ReverseString(name));

        // Finds the Factorial of num1
        Console.WriteLine($"Factorial of {num1} is {fundament.RecursiveFactorial(num1)}");
    }
}
