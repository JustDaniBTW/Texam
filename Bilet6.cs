//МОДУЛЬ
//=============================================================================================================\\
using System;

public class QuadraticEquationSolver
{
    public static (double, double) Solve(double a, double b, double c)
    {
        double discriminant = b * b - 4 * a * c;
        if (discriminant < 0)
        {
            throw new Exception("Уравнение не имеет действительных корней.");
        }
        else if (discriminant == 0)
        {
            double root = -b / (2 * a);
            return (root, root);
        }
        else
        {
            double sqrtDiscriminant = Math.Sqrt(discriminant);
            double root1 = (-b + sqrtDiscriminant) / (2 * a);
            double root2 = (-b - sqrtDiscriminant) / (2 * a);
            return (root1, root2);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        double a = 1;
        double b = -3;
        double c = 2;
        try
        {
            var roots = QuadraticEquationSolver.Solve(a, b, c);
            Console.WriteLine("Корни уравнения: " + roots.Item1 + ", " + roots.Item2);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }
}





//=============================================================================================================\\
//XUnit
//=============================================================================================================\\

using Xunit;

public class QuadraticEquationSolverTests
{
    [Fact]
    public void TestSolve()
    {
        
        double a = 1;
        double b = -3;
        double c = 2;

     
        var roots = QuadraticEquationSolver.Solve(a, b, c);

        Assert.Equal(2, roots.Item1);
        Assert.Equal(1, roots.Item2);
    }
}


