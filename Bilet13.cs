
using System;

public class Stack
{
    private int[] items;
    private int top;

    public Stack(int size)
    {
        items = new int[size];
        top = -1;
    }

    public void Push(int value)
    {
        if (top == items.Length - 1)
        {
            throw new OverflowException("Стек переполнен");
        }
        items[++top] = value;
    }

    public int Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Стек пуст");
        }
        return items[top--];
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Стек пуст");
        }
        return items[top];
    }

    public bool IsEmpty()
    {
        return top == -1;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Stack stack = new Stack(5);

        // Пример использования стека
        Console.WriteLine("Добавление элементов в стек:");
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Console.WriteLine("Верхний элемент стека: " + stack.Peek());

        Console.WriteLine("Извлечение элементов из стека:");
        while (!stack.IsEmpty())
        {
            int item = stack.Pop();
            Console.WriteLine("Извлеченный элемент: " + item);
        }
    }
}
//==============================================================================================================\\
                                     //XUNIT\\

                         using Xunit;

public class StackTests
{
    [Fact]
    public void TestPushAndPop()
    {
        // Arrange
        Stack stack = new Stack(5);

        // Act
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        int poppedValue = stack.Pop();

        // Assert
        Assert.Equal(3, poppedValue);
        Assert.False(stack.IsEmpty());
    }

    [Fact]
    public void TestPeek()
    {
        // Arrange
        Stack stack = new Stack(5);

        // Act
        stack.Push(1);
        stack.Push(2);
        int peekedValue = stack.Peek();

        // Assert
        Assert.Equal(2, peekedValue);
        Assert.False(stack.IsEmpty());
    }

    [Fact]
    public void TestEmptyStack()
    {
        // Arrange
        Stack stack = new Stack(5);

        // Assert
        Assert.True(stack.IsEmpty());
    }

    [Fact]
    public void TestFullStack()
    {
        // Arrange
        Stack stack = new Stack(2);

        // Act
        stack.Push(1);
        stack.Push(2);

        // Assert
        Assert.Throws<OverflowException>(() => stack.Push(3));
    }

    [Fact]
    public void TestPopFromEmptyStack()
    {
        // Arrange
        Stack stack = new Stack(5);

        // Assert
        Assert.Throws<InvalidOperationException>(() => stack.Pop());
    }

    [Fact]
    public void TestPeekEmptyStack()
    {
        // Arrange
        Stack stack = new Stack(5);

        // Assert
        Assert.Throws<InvalidOperationException>(() => stack.Peek());
    }
}            

