//МОДУЛЬ
//=============================================================================================================\\
using System;
using System.Linq;

public class NumberPermutation
{
    public static int MaximizeNumber(int n)
    {
        // Преобразуем число в массив цифр
        char[] digits = n.ToString().ToCharArray();

        // Сортируем цифры в порядке убывания
        Array.Sort(digits);
        Array.Reverse(digits);

        // Собираем число из отсортированных цифр
        int result = int.Parse(new string(digits));

        return result;
    }
}


class Program
{
    static void Main(string[] args)
    {
        
        int number = 123456;
        int result = NumberPermutation.MaximizeNumber(number);
        Console.WriteLine("Наибольшее число после перестановки цифр: " + result);
    }
}





//=============================================================================================================\\
//XUnit
//=============================================================================================================\\

using Xunit;

public class NumberPermutationTests
{
    [Fact]
    public void TestMaximizeNumber()
    {
        
        int n = 12345;

        int result = NumberPermutation.MaximizeNumber(n);

        Assert.Equal(54321, result);
    }
}


