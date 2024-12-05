using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Input the starting number: ");
        Int32.TryParse(Console.ReadLine(), out int number);
        int count = 0;
        while (count < 20)
        {
            if (IsPrime(number))
            {
                Console.WriteLine(number);
                count++;
            }
            number++;
        }
    }

    public static bool IsPrime(int number)
    {
        for (double i = 2.0; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}