public interface IFundament
{
    /// <summary>
    /// Sums two numbers together, in void, we can specify if these numbers are integers, doubles or long
    /// </summary>
    void SumTwoNumbers();

    /// <summary>
    /// sums together two numbers that it recieves as parameter arguments
    /// </summary>
    /// <param name="a">the value of a</param>
    /// <param name="b">the value of b</param>
    /// <returns>a + b</returns>
    double SumTwoNumbersOfGivenType(double a, double b);

    /// <summary>
    /// check whether a number is even (divisible by two) or odd
    /// </summary>
    void CheckOddOrEven(double a);

    /// <summary>
    /// A method that returns a interesting fact, that the user of the program can define as a parameter argument
    /// </summary>
    /// <param name="fact">a interesting fact</param>
    /// <returns>a fact of type: string</returns>
    string GetAInterestingFact(string fact);

    /// <summary>
    /// Prints 10 Fibonacci numbers
    /// </summary>

    void PrintFibonnaciSeries();

    /// <summary>
    /// Takes in a string, copies string to char array and reverses it. Returns the char array as new string
    /// </summary>
    /// <param name="str"></param>
    /// <returns>reversed string </returns>
    string ReverseString(string str);

    /// <summary>
    /// Uses a recursive function to call itself inside the function to find the fractotial of the param n
    /// </summary>
    /// <param name="n"></param>
    /// <returns>returns the param n * the function with n -1 inside the parm</returns>
    double RecursiveFactorial(double n);
}
