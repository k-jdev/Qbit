using System;

class Program
{
    static void Main()
    {
        int[] digits = ReadDigitsUntilZero();
        int[] digitCounts = CountDigits(digits);
        MergeSort(digits, 0, digits.Length - 1);

        PrintResults(digitCounts, digits);
    }

    static int[] ReadDigitsUntilZero()
    {
        string input = Console.ReadLine();
        string[] tokens = input.Split(' ');

        int[] digits = new int[100000];
        int count = 0;

        for (int i = 0; i < tokens.Length; i++)
        {
            int digit = int.Parse(tokens[i]);

            if (digit == 0)
                break;

            digits[count] = digit;
            count++;
        }

        int[] result = new int[count];
        for (int i = 0; i < count; i++)
        {
            result[i] = digits[i];
        }

        return result;
    }

    static int[] CountDigits(int[] digits)
    {
        int[] counts = new int[10];

        for (int i = 0; i < digits.Length; i++)
        {
            counts[digits[i]]++;
        }

        return counts;
    }

    static void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;
            MergeSort(array, left, mid);
            MergeSort(array, mid + 1, right);
            Merge(array, left, mid, right);
        }
    }

    static void Merge(int[] array, int left, int mid, int right)
    {
        int leftSize = mid - left + 1;
        int rightSize = right - mid;

        int[] leftArray = new int[leftSize];
        int[] rightArray = new int[rightSize];

        for (int i = 0; i < leftSize; i++)
            leftArray[i] = array[left + i];
        for (int j = 0; j < rightSize; j++)
            rightArray[j] = array[mid + 1 + j];

        int iLeft = 0, iRight = 0, iMerged = left;

        while (iLeft < leftSize && iRight < rightSize)
        {
            if (leftArray[iLeft] <= rightArray[iRight])
                array[iMerged++] = leftArray[iLeft++];
            else
                array[iMerged++] = rightArray[iRight++];
        }

        while (iLeft < leftSize)
            array[iMerged++] = leftArray[iLeft++];

        while (iRight < rightSize)
            array[iMerged++] = rightArray[iRight++];
    }

    static void PrintResults(int[] digitCounts, int[] sortedDigits)
    {
        Console.Write(digitCounts[1]);
        for (int i = 2; i <= 9; i++)
        {
            Console.Write(" " + digitCounts[i]);
        }
        Console.WriteLine();

        Console.WriteLine(sortedDigits.Length);

        if (sortedDigits.Length > 0)
        {
            Console.Write(sortedDigits[0]);
            for (int i = 1; i < sortedDigits.Length; i++)
            {
                Console.Write(" " + sortedDigits[i]);
            }
        }
        Console.WriteLine();
    }
}
