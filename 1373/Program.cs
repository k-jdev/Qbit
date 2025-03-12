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
        SortEvenIndexedElements(arr);
        Console.WriteLine(string.Join(" ", arr));
    }
    static void SortEvenIndexedElements(int[] arr)
    {
        int evenCount = (arr.Length + 1) / 2; 
        int[] evenIndexedElements = new int[evenCount];

        int index = 0;
        for (int i = 0; i < arr.Length; i += 2)
        {
            evenIndexedElements[index++] = arr[i];
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

        index = 0;
        for (int i = 0; i < arr.Length; i += 2)
        {
            arr[i] = evenIndexedElements[index++];
        }
    }
}