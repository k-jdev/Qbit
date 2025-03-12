using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(input[i]);
        }
        SortEvenNumbers(arr);
        Console.WriteLine(string.Join(" ", arr));
    }

    static void SortEvenNumbers(int[] arr)
    {
        int evenCount = (arr.Length + 1) / 2;
        int oddCount = arr.Length / 2;

        int[] evenIndexedElements = new int[evenCount];
        int[] oddIndexedElements = new int[oddCount];
        int evenIndex = 0, oddIndex = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (i % 2 == 0)
                evenIndexedElements[evenIndex++] = arr[i];
            else
                oddIndexedElements[oddIndex++] = arr[i];
        }

        for (int i = 0; i < evenIndexedElements.Length - 1; i++)
        {
            for (int j = i + 1; j < evenIndexedElements.Length; j++)
            {
                if (evenIndexedElements[i] < evenIndexedElements[j])
                {
                    int temp = evenIndexedElements[i];
                    evenIndexedElements[i] = evenIndexedElements[j];
                    evenIndexedElements[j] = temp;
                }
            }
        }
        for (int i = 0; i < oddIndexedElements.Length - 1; i++)
        {
            for (int j = i + 1; j < oddIndexedElements.Length; j++)
            {
                if (oddIndexedElements[i] > oddIndexedElements[j])
                {
                    int temp = oddIndexedElements[i];
                    oddIndexedElements[i] = oddIndexedElements[j];
                    oddIndexedElements[j] = temp;
                }
            }
        }
        evenIndex = 0;
        oddIndex = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (i % 2 == 0)
                arr[i] = evenIndexedElements[evenIndex++];
            else
                arr[i] = oddIndexedElements[oddIndex++];
        }
    }
}