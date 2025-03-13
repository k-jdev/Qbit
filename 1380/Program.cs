using System;
namespace _1380
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] inputDigits = Console.ReadLine().Split();

            int[] freqMin = new int[10];
            int[] freqMax = new int[10];

            for (int i = 0; i < n; i++)
            {
                int digit = int.Parse(inputDigits[i]);
                freqMin[digit]++;
                freqMax[digit]++;
            }

            Console.WriteLine(FindMinNumber(freqMin, n));
            Console.WriteLine(FindMaxNumber(freqMax, n));
        }

        static string FindMinNumber(int[] freq, int n)
        {
            char[] result = new char[n];
            int index = 0;

            int firstDigit = 1;
            while (firstDigit < 10 && freq[firstDigit] == 0)
            {
                firstDigit++;
            }
            if (firstDigit < 10)
            {
                result[index++] = (char)(firstDigit + '0');
                freq[firstDigit]--;
            }

            while (freq[0] > 0 && index < n)
            {
                result[index++] = '0';
                freq[0]--;
            }
            for (int i = 1; i < 10; i++)
            {
                while (freq[i] > 0 && index < n)
                {
                    result[index++] = (char)(i + '0');
                    freq[i]--;
                }
            }

            return new string(result);
        }

        static string FindMaxNumber(int[] freq, int n)
        {
            char[] result = new char[n];
            int index = 0;
            for (int i = 9; i >= 0; i--)
            {
                while (freq[i] > 0)
                {
                    result[index++] = (char)(i + '0');
                    freq[i]--;
                }
            }

            return new string(result);
        }
    }
}