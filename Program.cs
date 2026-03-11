// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
StatisticsHelper.printNumbers(numbers);
int count = StatisticsHelper.countEvenNumbers(numbers);
Console.WriteLine("The number of even numbers is: " + count);
public class StatisticsHelper
{
    public static void printNumbers(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }

    public static int countEvenNumbers(int[] numbers)
    {
        int count = 0; 
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0) count++;
        }
        return count;
    }
}