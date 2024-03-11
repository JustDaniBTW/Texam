using System;

class QuadraticEquationSolver
{
    static void Main()
    {
        Console.WriteLine("Введите коэффициенты квадратного уравнения ax^2 + bx + c = 0:");

        Console.Write("Введите коэффициент a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введите коэффициент b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Введите коэффициент c: ");
        double c = double.Parse(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("У уравнения два действительных корня:");
            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
        }
        else if (discriminant == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("У уравнения один действительный корень:");
            Console.WriteLine("x = " + x);
        }
        else
        {
            double realPart = -b / (2 * a);
            double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
            Console.WriteLine("У уравнения два комплексных корня:");
            Console.WriteLine("x1 = " + realPart + " + " + imaginaryPart + "i");
            Console.WriteLine("x2 = " + realPart + " - " + imaginaryPart + "i");
        }
    }
}
