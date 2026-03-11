// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
StatisticsHelper.printNumbers(numbers);
int count = StatisticsHelper.countEvenNumbers(numbers);
Console.WriteLine("The number of even numbers is: " + count);
double average = StatisticsHelper.CalculateAverage(numbers);
Console.WriteLine("The average of the numbers is: " + average);
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

    public static double CalculateAverage(int[] values)
    {
        return values.Average();
    }

    public static int CalculateMax(int[] values)
    {
        int max = values[0];
        for (int i = 0; i < values.Length; i++)
        {
            if(values[i] > max) max = values[i];
        }

        return max;
    }

    public static int CalculateMin(int[] values)
    {
        int min = values[0];
        for (int i = 0; i < values.Length; i++)
        {
            if(values[i] > min) min = values[i];
        }

        return min;
    }
}