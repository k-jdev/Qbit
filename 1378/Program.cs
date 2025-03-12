namespace _1378
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
            int negativeCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    positiveCount++;
                }
                if (arr[i] < 0)
                {
                    negativeCount++;
                }
            }
            int[] arrOfPositiveNums = new int[positiveCount];
            int[] arrOfNegativeNums = new int[negativeCount];
            int positiveIndex = 0;
            int negativeIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    arrOfPositiveNums[positiveIndex++] = arr[i];
                }
                if (arr[i] < 0)
                {
                    arrOfNegativeNums[negativeIndex++] = arr[i];
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
            for (int i = 0; i < arrOfNegativeNums.Length - 1; i++)
            {
                for (int j = i + 1; j < arrOfNegativeNums.Length; j++)
                {
                    if (arrOfNegativeNums[i] > arrOfNegativeNums[j])
                    {
                        int temp = arrOfNegativeNums[i];
                        arrOfNegativeNums[i] = arrOfNegativeNums[j];
                        arrOfNegativeNums[j] = temp;
                    }
                }
            }
            positiveIndex = 0;
            negativeIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    arr[i] = arrOfPositiveNums[positiveIndex++];
                }
                if (arr[i] < 0)
                {
                    arr[i] = arrOfNegativeNums[negativeIndex++];
                }

            }
        }
    }
}