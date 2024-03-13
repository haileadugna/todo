// See https://aka.ms/new-console-template for more information
using Task1;
using Task2;
using Task3;

class Program
{
    static void Main()
    {
        // Task1
        Console.WriteLine("Task 1");
        Calculator calculator = new Calculator();
        calculator.Calculate();

        // Task2
        Console.WriteLine("Task 2");
        WordFrequencyCounter wordFrequencyCounter = new WordFrequencyCounter();
        wordFrequencyCounter.Count();

        // Task3
        Console.WriteLine("Task 3");
        PalindromeCheck palindromeCheck = new PalindromeCheck();
        palindromeCheck.Check();
    }
}