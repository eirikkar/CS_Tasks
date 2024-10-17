public class Fundament : IFundament
{
    public void CheckOddOrEven(double a)
    {
        if (a % 2 == 0)
        {
            Console.WriteLine($"{a} is an even number");
        }
        else
        {
            Console.WriteLine($"{a} is an odd number");
        }
    }

    public string GetAInterestingFact(string fact)
    {
        return fact;
    }

    public void SumTwoNumbers()
    {
        int firstNumber = 15;
        double SecoundNumber = 15.5D;
        Console.WriteLine(firstNumber + SecoundNumber);
    }

    public double SumTwoNumbersOfGivenType(double a, double b)
    {
        return a + b;
    }

    // Extra challenges

    public void PrintFibonnaciSeries()
    {
        int a = 0;
        int b = 1;
        int c;
        Console.Write($"10 Fibonacci numbers: {a} {b} ");
        for (int i = 0; i < 8; i++)
        {
            c = a + b;
            Console.Write($"{c} ");
            a = b;
            b = c;
        }
        Console.WriteLine();
    }

    public string ReverseString(string str)
    {
        char[] reverse = str.ToCharArray();
        Array.Reverse(reverse);
        return new string(reverse);
    }

    public double RecursiveFactorial(double n)
    {
        if (n == 0)
        {
            return 1;
        }
        return n * RecursiveFactorial(n - 1);
    }
}
