using System;

public class DigitProductCalculator
{
    public static int CalculateDigitProduct(int number)
    {
        if (number < 100 || number > 999)
        {
            throw new ArgumentOutOfRangeException(nameof(number), "Число должно быть трехзначным.");
        }

        int digit1 = number / 100;
        int digit2 = (number / 10) % 10;
        int digit3 = number % 10;

        return digit1 * digit2 * digit3;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите трехзначное число:");
        int number = int.Parse(Console.ReadLine());

        try
        {
            int product = DigitProductCalculator.CalculateDigitProduct(number);
            Console.WriteLine($"Произведение цифр числа {number}: {product}");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
        }
    }
}

///XUnit

using Xunit;

public class DigitProductCalculatorTests
{
    [Theory]
    [InlineData(123, 6)]
    [InlineData(456, 120)]
    [InlineData(789, 504)]
    public void TestCalculateDigitProduct(int number, int expectedProduct)
    {
        // Act
        int product = DigitProductCalculator.CalculateDigitProduct(number);

        // Assert
        Assert.Equal(expectedProduct, product);
    }

    [Fact]
    public void TestInvalidNumber()
    {
        // Arrange
        int number = 9999;

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => DigitProductCalculator.CalculateDigitProduct(number));
    }
}