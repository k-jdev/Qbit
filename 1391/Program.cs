using System;
using System.Linq;
namespace _1391
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var pairs = new (int value, int index)[n];
            for (int i = 0; i < n; i++)
            {
                pairs[i] = (arr[i], i);
            }

            Array.Sort(pairs, (a, b) => {
                int absA = Math.Abs(a.value);
                int absB = Math.Abs(b.value);

                if (absA != absB)
                    return absA.CompareTo(absB);

                if (a.value != b.value)
                    return a.value.CompareTo(b.value);

                return a.index.CompareTo(b.index);
            });

            Console.WriteLine(string.Join(" ", pairs.Select(p => p.value)));
        }
    }
}
