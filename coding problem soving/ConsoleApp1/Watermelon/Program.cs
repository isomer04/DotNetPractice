﻿public class Program
{
    public static void Main(string[] args)
    {
        int weight = int.Parse(Console.ReadLine());

        if (weight % 2 == 0 && weight > 2)
            {
                Console.WriteLine("YES");
            
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
