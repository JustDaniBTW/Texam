//ПРОГА
//=============================================================================================================\\
using System;
using System.Collections.Generic;


 public class MainClass
{
    public static void Main(string[] args)
    {
        // Генерация массива вещественных чисел
        double[] numbers = GenerateNumbersArray(100);

        // Поиск всех минимальных положительных элементов
        List<double> minPositiveElements = FindMinPositiveElements(numbers);

        // Вывод результатов
        Console.WriteLine("Минимальные положительные элементы массива:");
        foreach (var element in minPositiveElements)
        {
            Console.WriteLine(element);
        }
    }

    // Генерация массива вещественных чисел в диапазоне от -10 до 10
    public static double[] GenerateNumbersArray(int size)
    {
        Random random = new Random();
        double[] numbers = new double[size];
        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.NextDouble() * 20 - 10; // Генерация числа от -10 до 10
        }
        return numbers;
    }

    // Поиск всех минимальных положительных элементов в массиве
    public static List<double> FindMinPositiveElements(double[] numbers)
    {
        List<double> minPositiveElements = new List<double>();
        double minPositive = double.PositiveInfinity;
        foreach (var number in numbers)
        {
            if (number > 0 && number < minPositive)
            {
                minPositive = number;
                minPositiveElements.Clear();
                minPositiveElements.Add(number);
            }
            else if (number > 0 && number == minPositive)
            {
                minPositiveElements.Add(number);
            }
        }
        return minPositiveElements;
    }
}



//=============================================================================================================\\
//Nunit
//=============================================================================================================\\

using NUnit.Framework;
[TestFixture]
public class ArrayTests
{
    [Test]
    public void FindMinPositiveElements_Test()
    {
        
        double[] numbers = { -9, -5, 0, 2, 2, 5, 7, 7 };

        var result = MainClass.FindMinPositiveElements(numbers).Distinct();

        Assert.That(result, Is.EquivalentTo(new double[] { 2 }));
    }
}

//Этот тест проверяет правильность работы функции FindMinPositiveElements, которая ищет все минимальные положительные элементы в массиве чисел