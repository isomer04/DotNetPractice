using System;

class Program
{
    static void Main(string[] args)
    {
        string[] weights = Console.ReadLine().Split();

        int a = int.Parse(weights[0]);
        int b = int.Parse(weights[1]);

        int years = 0;
        while (a <= b)
        {
            a *= 3;
            b *= 2;
            years++;
        }

        Console.WriteLine(years);
    }
}
