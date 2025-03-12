namespace _1377
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
            int positiveCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    positiveCount++;
                }
            }
            int[] arrOfPositiveNums = new int[positiveCount];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    arrOfPositiveNums[index++] = arr[i];
                }
            }
            for (int i = 0; i < arrOfPositiveNums.Length - 1; i++)
            {
                for (int j = i + 1; j < arrOfPositiveNums.Length; j++)
                {
                    if (arrOfPositiveNums[i] > arrOfPositiveNums[j])
                    {
                        int temp = arrOfPositiveNums[i];
                        arrOfPositiveNums[i] = arrOfPositiveNums[j];
                        arrOfPositiveNums[j] = temp;
                    }
                }
            }
            index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    arr[i] = arrOfPositiveNums[index++];
                }

            }
        }
    }
}