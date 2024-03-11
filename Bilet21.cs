using System;

public class Program
{
    public static double SumOfSequence(double[] sequence)
    {
        double sum = 0;
        foreach (double element in sequence)
        {
            sum += element;
        }
        return sum;
    }

    static void Main()
    {
        Console.WriteLine("Введите количество элементов в последовательности:");
        int n = int.Parse(Console.ReadLine());
        double[] sequence = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите {i + 1}-й элемент последовательности: ");
            sequence[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Сумма всех элементов последовательности: {SumOfSequence(sequence)}");
    }
}
