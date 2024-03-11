//МОДУЛЬ
//=============================================================================================================\\
using System;

public class BubbleSort
{
    public static void Sort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Обмен значениями
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        int[] array = { 3, 1, 4, 1, 5, 9, 2, 6 };

        Console.WriteLine("Массив до сортировки:");
        PrintArray(array);

        BubbleSort.Sort(array);

        Console.WriteLine("\nМассив после сортировки:");
        PrintArray(array);
    }

    public static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
    
}






//=============================================================================================================\\
//NUnit
//=============================================================================================================\\

using NUnit;
using NUnit.Framework;

[TestFixture]

public class BubbleSortTests
{
    [Test]
    public void TestSort()
    {
        // Arrange
        int[] array = { 3, 1, 4, 1, 5, 9, 2, 6 };

        // Act
        BubbleSort.Sort(array);

        // Assert
        Assert.AreEqual(new int[] { 1, 1, 2, 3, 4, 5, 6, 9 }, array);
    }
}

