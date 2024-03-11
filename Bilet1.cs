//МОДУЛЬ
//=============================================================================================================\\
using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // Входные данные
        int K = 100; // Количество членов последовательности
        double A = 2.5; // Заданное число

        // Поиск первого члена последовательности, большего A
        double sum = 0;
        for (int i = 1; i <= K; i++)
        {
            sum += 1.0 / i;
            if (sum > A)
            {
                Console.WriteLine($"Первый член больше {A}: {sum}");
                break;
            }
        }
    }
}
//=============================================================================================================\\
//Nunit
//=============================================================================================================\\

using NUnit.Framework;

[TestFixture]
public class SequenceTests
{
    [Test]
    
    public void FindFirstGreaterThan_Test()
    {
        
        int K = 100;
        double A = 2.5;

        double result = FindFirstGreaterThan(K, A);

        Assert.That(result, Is.EqualTo(2.59285714285714).Within(0.0001));
    }


    public double FindFirstGreaterThan(int K, double A)
    {
        double sum = 0;
        for (int i = 1; i <= K; i++)
        {
            sum += 1.0 / i;
            if (sum > A)
            {
                return sum;
            }
        }
        return -1; // Если не найдено
    }
}
