using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        List<int> listNumbers = new List<int>();

        int[] firstArrayNumbers = { 1, 2, 1 };
        int[] secondArrayNumbers = { 3, 2 };

        AddUniqueNumbers(listNumbers, firstArrayNumbers);
        AddUniqueNumbers(listNumbers, secondArrayNumbers);

        foreach (int number in listNumbers)
        {
            Console.WriteLine(number);
        }
    }

    static void AddUniqueNumbers(List<int> listNumbers, int[] arrayNumbers)
    {
        int arrayLength = arrayNumbers.Length;

        for (int i = 0; i < arrayLength; i++)
        {
            if (listNumbers.Contains(arrayNumbers[i]) == false)
            {
                listNumbers.Add(arrayNumbers[i]);
            }
        }
    }
}