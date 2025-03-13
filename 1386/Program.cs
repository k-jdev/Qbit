using System;
namespace _1386
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] points = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] indexes = new int[n];
            for (int i = 0; i < n; i++)
                indexes[i] = i + 1;

            SortPoints(points, indexes, n);

            var (minDist, minIndex1, minIndex2) = FindMinDistancePair(points, indexes, n);
            var (maxDist, maxIndex1, maxIndex2) = FindMaxDistancePair(points, indexes, n);

            Console.WriteLine($"{minDist} {Math.Min(minIndex1, minIndex2)} {Math.Max(minIndex1, minIndex2)}");
            Console.WriteLine($"{maxDist} {Math.Max(maxIndex1, maxIndex2)} {Math.Min(maxIndex1, maxIndex2)}");
        }

        static void SortPoints(int[] points, int[] indexes, int n)
        {
            for (int i = 1; i < n; i++)
            {
                int key = points[i];
                int keyIndex = indexes[i];
                int j = i - 1;

                while (j >= 0 && points[j] > key)
                {
                    points[j + 1] = points[j];
                    indexes[j + 1] = indexes[j];
                    j--;
                }
                points[j + 1] = key;
                indexes[j + 1] = keyIndex;
            }
        }

        static (int, int, int) FindMinDistancePair(int[] points, int[] indexes, int n)
        {
            int minDist = int.MaxValue, minIndex1 = -1, minIndex2 = -1;
            for (int i = 1; i < n; i++)
            {
                int dist = points[i] - points[i - 1];
                if (dist < minDist)
                {
                    minDist = dist;
                    minIndex1 = indexes[i - 1];
                    minIndex2 = indexes[i];
                }
            }
            return (minDist, Math.Min(minIndex1, minIndex2), Math.Max(minIndex1, minIndex2));
        }

        static (int, int, int) FindMaxDistancePair(int[] points, int[] indexes, int n)
        {
            int maxDist = int.MinValue, maxIndex1 = -1, maxIndex2 = -1;
            for (int i = 1; i < n; i++)
            {
                int dist = points[i] - points[i - 1];
                if (dist > maxDist)
                {
                    maxDist = dist;
                    maxIndex1 = indexes[i - 1];
                    maxIndex2 = indexes[i];
                }
            }
            return (maxDist, Math.Max(maxIndex1, maxIndex2), Math.Min(maxIndex1, maxIndex2));
        }
    }
}
