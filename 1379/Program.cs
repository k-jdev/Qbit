using System;
using System.Text;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();

        int[] counts = new int[10];
        int totalDigits = 0;

        foreach (string s in input)
        {
            int digit = int.Parse(s);
            if (digit == 0)
                break;

            counts[digit]++;
            totalDigits++;
        }

        StringBuilder firstLine = new StringBuilder();
        for (int i = 1; i <= 9; i++)
        {
            firstLine.Append(counts[i] + " ");
        }
        Console.WriteLine(firstLine.ToString().Trim());

        Console.WriteLine(totalDigits);

        StringBuilder sortedSequence = new StringBuilder();
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 0; j < counts[i]; j++)
            {
                sortedSequence.Append(i + " ");
            }
        }
        Console.WriteLine(sortedSequence.ToString().Trim());
    }
}