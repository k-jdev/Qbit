namespace _1375
{
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
            int evenCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenCount++;
                }
            }
            int[] arrOfEvenNums = new int[evenCount];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arrOfEvenNums[index++] = arr[i];
                }
            }
            for (int i = 0; i < arrOfEvenNums.Length - 1; i++)
            {
                for (int j = i + 1; j < arrOfEvenNums.Length; j++)
                {
                    if (arrOfEvenNums[i] > arrOfEvenNums[j])
                    {
                        int temp = arrOfEvenNums[i];
                        arrOfEvenNums[i] = arrOfEvenNums[j];
                        arrOfEvenNums[j] = temp;
                    }
                }
            }
            index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arr[i] = arrOfEvenNums[index++];
                }

            }
        }
    }
}