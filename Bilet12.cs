using System;

public class TriangleClassifier
{
    public static string ClassifyTriangle(int a, int b, int c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            throw new ArgumentException("Длины сторон должны быть положительными числами.");
        }

        if (a + b <= c || a + c <= b || b + c <= a)
        {
            return "Треугольник с такими сторонами не существует.";
        }

        if (a == b && b == c)
        {
            return "Равносторонний треугольник";
        }
        else if (a == b || a == c || b == c)
        {
            return "Равнобедренный треугольник";
        }
        else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
        {
            return "Прямоугольный треугольник";
        }
        else
        {
            return "Разносторонний треугольник";
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите длины сторон треугольника:");

        Console.Write("Сторона a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Сторона b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Сторона c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        try
        {
            string triangleType = TriangleClassifier.ClassifyTriangle(a, b, c);
            Console.WriteLine($"Треугольник с такими сторонами - {triangleType}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}

///XUNIT\\
using Xunit;

public class TriangleClassifierTests
{
    [Theory]
    [InlineData(3, 3, 3, "Равносторонний треугольник")]
    [InlineData(4, 4, 5, "Равнобедренный треугольник")]
    [InlineData(3, 4, 5, "Прямоугольный треугольник")]
    [InlineData(6, 7, 8, "Разносторонний треугольник")]
    public void TestClassifyTriangle(int a, int b, int c, string expected)
    {
        // Act
        var result = TriangleClassifier.ClassifyTriangle(a, b, c);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestInvalidSideLengths()
    {
        // Assert
        Assert.Throws<ArgumentException>(() => TriangleClassifier.ClassifyTriangle(-1, 2, 3));
    }

    [Fact]
    public void TestNonexistentTriangle()
    {
        // Assert
        Assert.Equal("Треугольник с такими сторонами не существует.", TriangleClassifier.ClassifyTriangle(1, 1, 3));
    }
}
