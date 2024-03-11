using System;

public class AgeValidator
{
    public static bool IsValidAge(int age, int birthYear)
    {
        if (age < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(age), "Отрицательное значение возраста!");
        }

        int currentYear = DateTime.Now.Year;
        if (birthYear > currentYear)
        {
            throw new ArgumentException("Год рождения больше текущего года!");
        }

        return true;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите ваш возраст:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш год рождения:");
            int birthYear = int.Parse(Console.ReadLine());

            bool isValid = AgeValidator.IsValidAge(age, birthYear);
            Console.WriteLine($"Ваш возраст и год рождения допустимы: {isValid}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Некорректный формат ввода числа.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
        }
    }
}
///MSUnit

using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class AgeValidatorTests
{
    [TestMethod]
    public void TestValidAge()
    {
        // Arrange
        int age = 25;
        int birthYear = 1999;

        // Act
        bool isValid = AgeValidator.IsValidAge(age, birthYear);

        // Assert
        Assert.IsTrue(isValid);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void TestNegativeAge()
    {
        // Arrange
        int age = -25;
        int birthYear = 1999;

        // Act
        AgeValidator.IsValidAge(age, birthYear);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestFutureBirthYear()
    {
        // Arrange
        int age = 25;
        int birthYear = DateTime.Now.Year + 1;

        // Act
        AgeValidator.IsValidAge(age, birthYear);
    }
}