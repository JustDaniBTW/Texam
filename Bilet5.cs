//МОДУЛЬ
//=============================================================================================================\\
using System;
using System.Linq;

public class MainClass
{
    public static void Main(string[] args)
    {
        // Пример использования функции и вывод результата
        int[] array = { 1, 3, 5, 7, 9 };
        int sum = SumWithoutMax(array);
        Console.WriteLine($"Сумма всех элементов, кроме максимального: {sum}");
    }

    // Функция для определения суммы всех элементов массива, которые не равны максимальному
    public static int SumWithoutMax(int[] array)
    {
        int max = array.Max();
        return array.Where(x => x != max).Sum();
    }
}




//=============================================================================================================\\
//XUnit
//=============================================================================================================\\

using System;
using Xunit;

public class ArrayTests
{
    [Fact]
    public void SumWithoutMax_Test()
    {
        
        int[] array = { 1, 3, 5, 7, 9 };

        int result = MainClass.SumWithoutMax(array);

        Assert.Equal(16, result);
    }
}


//Этот тест проверяет правильность работы функции FindMinPositiveElements, которая ищет все минимальные положительные элементы в массиве чисел