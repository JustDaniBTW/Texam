using System;
using System.Collections.Generic;

class QuickSort
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива через пробел:");
        string input = Console.ReadLine();
        string[] elements = input.Split(' ');
        List<int> array = new List<int>();
        foreach (string element in elements)
        {
            int num;
            if (int.TryParse(element, out num))
            {
                array.Add(num);
            }
        }
        QuickSortArray(array, 0, array.Count - 1);
        Console.WriteLine("Отсортированный массив:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
    }

    static void QuickSortArray(List<int> array, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(array, left, right);
            QuickSortArray(array, left, pivotIndex - 1);
            QuickSortArray(array, pivotIndex + 1, right);
        }
    }

    static int Partition(List<int> array, int left, int right)
    {
        int pivot = array[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, right);
        return i + 1;
    }

    static void Swap(List<int> array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}


====================MSUnix==============================

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

[TestClass]
public class QuickSortTests
{
    [TestMethod]
    public void QuickSort_SortsArrayCorrectly()
    {
        List<int> unsortedArray = new List<int> { 5, 2, 9, 3, 7 };
        QuickSortArray(unsortedArray, 0, unsortedArray.Count - 1);
        CollectionAssert.AreEqual(new List<int> { 2, 3, 5, 7, 9 }, unsortedArray);
    }

    [TestMethod]
    public void QuickSort_EmptyArray_RemainsEmpty()
    {
        List<int> emptyArray = new List<int>();
        QuickSortArray(emptyArray, 0, emptyArray.Count - 1);
        CollectionAssert.AreEqual(new List<int>(), emptyArray);
    }

    [TestMethod]
    public void QuickSort_SingleElementArray_RemainsSame()
    {
        List<int> singleElementArray = new List<int> { 42 };
        QuickSortArray(singleElementArray, 0, singleElementArray.Count - 1);
        CollectionAssert.AreEqual(new List<int> { 42 }, singleElementArray);
    }

    static void QuickSortArray(List<int> array, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(array, left, right);

            QuickSortArray(array, left, pivotIndex - 1);
            QuickSortArray(array, pivotIndex + 1, right);
        }
    }

    static int Partition(List<int> array, int left, int right)
    {
        int pivot = array[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, right);
        return i + 1;
    }

    static void Swap(List<int> array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}