//МОДУЛЬ
//=============================================================================================================\\
using System;

public class ArrayAnalyzer
{
    public static int CountElementsGreaterThanNeighbors(int[] array)
    {
        int count = 0;
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                count++;
            }
        }
        return count;
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 3, 2, 5, 4, 6 };
            int count = ArrayAnalyzer.CountElementsGreaterThanNeighbors(array);
            Console.WriteLine("Количество элементов массива, больших двух своих соседей: " + count);
        }
    }
}





//=============================================================================================================\\
//XUnit
//=============================================================================================================\\

using Xunit;

public class ArrayAnalyzerTests
{
    [Fact]
    public void TestCountElementsGreaterThanNeighbors()
    {
        
        int[] array = { 1, 3, 2, 5, 4, 6 };

        
        int result = ArrayAnalyzer.CountElementsGreaterThanNeighbors(array);

        
        Assert.Equal(2, result);
    }
}

