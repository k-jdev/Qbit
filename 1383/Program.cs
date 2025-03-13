using System;
namespace _1383
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long[] array = ReadArray(n);

            QuickSort(array, 0, n - 1);

            CheckAndPrintResult(array, n);

        }

        static long[] ReadArray(int n)
        {
            string[] inputValues = Console.ReadLine().Split();
            long[] array = new long[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = long.Parse(inputValues[i]);
            }

            return array;
        }

        static void QuickSort(long[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(array, left, right);
                QuickSort(array, left, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, right);
            }
        }

        static int Partition(long[] array, int left, int right)
        {
            long pivot = array[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, right);
            return i + 1;
        }

        static void Swap(long[] array, int i, int j)
        {
            long temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        static void CheckAndPrintResult(long[] array, int n)
        {
            if (n <= 2)
            {
                Console.WriteLine("YES");
                Console.WriteLine(n == 1 ? 0 : array[1] - array[0]);
                return;
            }

            long difference = array[1] - array[0];
            bool isArithmeticProgression = IsArithmeticProgression(array, difference);

            if (isArithmeticProgression)
            {
                Console.WriteLine("YES");
                Console.WriteLine(difference);
            }
            else
            {
                Console.WriteLine("NO");
                Console.WriteLine(array[n - 1] - array[0]);
            }
        }

        static bool IsArithmeticProgression(long[] array, long difference)
        {
            for (int i = 2; i < array.Length; i++)
            {
                if (array[i] - array[i - 1] != difference)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
