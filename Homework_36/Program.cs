using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        int[] firstArrayNumbers = { 1, 2, 1 };
        int[] secondArrayNumbers = { 3, 2 };

        List<int> listNumbers = new List<int>();

        SortOutNumbers(firstArrayNumbers, firstArrayNumbers.Length, listNumbers);
        SortOutNumbers(secondArrayNumbers, secondArrayNumbers.Length, listNumbers);

        foreach (int number in listNumbers)
        {
            Console.WriteLine(number);
        }
    }

    static void SortOutNumbers(int[] arrayNumbers, int arrayLength, List<int> listNumbers)
    {
        for (int i = 0; i < arrayLength; i++)
        {
            if (listNumbers.Contains(arrayNumbers[i]) == false)
            {
                listNumbers.Add(arrayNumbers[i]);
            }
        }
    }
}