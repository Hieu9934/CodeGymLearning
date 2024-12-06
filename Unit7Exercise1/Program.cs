using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] array = new int[10];
        array[0] = 10;
        array[1] = 4;
        array[2] = 6;
        array[3] = 7;
        array[4] = 8;
        Console.WriteLine(PrintArray(array));

        Console.Write("Provide your input: ");
        Int32.TryParse(Console.ReadLine(), out int input);
        Console.Write("Provide your index: ");
        Int32.TryParse(Console.ReadLine(), out int index);
        do
        {
            Console.Write("Invalid index, provide your index again: ");
            Int32.TryParse(Console.ReadLine(), out  index);
        } while (index < 0 || index > 9);
        for (int i = array.Length - 2; i >= index; i--) {
            array[i + 1] = array[i];
        }
        array[index] = input;
        Console.WriteLine(PrintArray(array));
    }

    public static string PrintArray(int[] array)
    {
        string result = "[" + array[0];
        for (int i = 1; i < array.Length; i++)
        {
            result += ", " + array[i];
        }
        return result + "]";
    }
}