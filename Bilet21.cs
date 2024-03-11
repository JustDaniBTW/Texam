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

================xUnix=======================

using Xunit;

public class SequenceSumTests
{
    [Fact]
    public void SumOfSequence_WithPositiveIntegers_ReturnsCorrectSum()
    {
        double[] sequence = { 1, 2, 3, 4, 5 };
        double expectedSum = 15;
        double actualSum = Program.SumOfSequence(sequence);
        Assert.Equal(expectedSum, actualSum);
    }

    [Fact]
    public void SumOfSequence_WithNegativeIntegers_ReturnsCorrectSum()
    {
        double[] sequence = { -1, -2, -3, -4, -5 };
        double expectedSum = -15;
        double actualSum = Program.SumOfSequence(sequence);
        Assert.Equal(expectedSum, actualSum);
    }

    [Fact]
    public void SumOfSequence_WithMixedIntegers_ReturnsCorrectSum()
    {
        double[] sequence = { -1, 2, -3, 4, -5 };
        double expectedSum = -3;
        double actualSum = Program.SumOfSequence(sequence);
        Assert.Equal(expectedSum, actualSum);
    }

    [Fact]
    public void SumOfSequence_WithEmptyArray_ReturnsZero()
    {
        double[] sequence = new double[0];
        double expectedSum = 0;
        double actualSum = Program.SumOfSequence(sequence);
        Assert.Equal(expectedSum, actualSum);
    }
}
