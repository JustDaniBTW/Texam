using System;
using System.Linq;

public class SmallestNumberPermutator
{
    public static int PermuteToSmallestNumber(int N)
    {
        if (N < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(N), "Число должно быть положительным.");
        }

        // Преобразуем число в массив цифр
        int[] digits = N.ToString().Select(c => int.Parse(c.ToString())).ToArray();

        // Сортируем массив цифр по возрастанию
        Array.Sort(digits);

        // Если первая цифра равна нулю, находим первую ненулевую цифру и меняем их местами
        if (digits[0] == 0)
        {
            int firstNonZeroIndex = Array.FindIndex(digits, d => d != 0);
            if (firstNonZeroIndex != -1)
            {
                int temp = digits[0];
                digits[0] = digits[firstNonZeroIndex];
                digits[firstNonZeroIndex] = temp;
            }
        }

        // Преобразуем отсортированный массив обратно в число
        int smallestNumber = int.Parse(string.Join("", digits));

        return smallestNumber;
    }
}



public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите натуральное трехзначное число:");
        int number = int.Parse(Console.ReadLine());

        try
        {
            int smallestNumber = SmallestNumberPermutator.PermuteToSmallestNumber(number);
            Console.WriteLine($"Наименьшее число, образованное из цифр {number}: {smallestNumber}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}


///XUnit

using Xunit;

public class SmallestNumberPermutatorTests
{
    [Theory]
    [InlineData(321, 123)]
    [InlineData(98765, 56789)]
    [InlineData(100, 1)]
    [InlineData(5308, 3058)]
    [InlineData(100, 100)]
    
    public void TestPermuteToSmallestNumber(int N, int expectedSmallestNumber)
    {
      
        int smallestNumber = SmallestNumberPermutator.PermuteToSmallestNumber(N);

      
        Assert.Equal(expectedSmallestNumber, smallestNumber);
    }
}