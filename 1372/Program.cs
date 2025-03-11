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

        SortOddIndexedElements(arr);
        Console.WriteLine(string.Join(" ", arr));
    }

    static void SortOddIndexedElements(int[] arr)
    {
        int[] oddIndexedElements = new int[arr.Length / 2];
        int index = 0;

        for (int i = 1; i < arr.Length; i += 2)
        {
            oddIndexedElements[index++] = arr[i];
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

        index = 0;
        for (int i = 1; i < arr.Length; i += 2)
        {
            arr[i] = oddIndexedElements[index++];
        }
    }
}
