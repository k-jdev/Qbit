using System;
namespace _1387
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int k = int.Parse(Console.ReadLine());

            SortDescending(arr, n);

            int sum = 0, maxSum = int.MinValue;
            for (int i = 1; i <= k; i++) 
            {
                sum = 0;
                for (int j = 0; j < i; j++)
                    sum += arr[j];

                maxSum = Math.Max(maxSum, sum);
            }

            Console.WriteLine(maxSum);
        }

        static void SortDescending(int[] arr, int n)
        {
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] < key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
    }
}
