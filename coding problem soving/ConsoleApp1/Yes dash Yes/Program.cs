using System;

public class Program
{

    

    public static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());
        for (int i = 0; i < t; i++)
        {
            string s = Console.ReadLine();
            Console.WriteLine(IsSubstring(s) ? "YES" : "NO");
        }
    }

    public static bool IsSubstring(string s)
    {
        int count = 0;
        foreach (char c in s)
        {
            if (c == 'Y')
            {
                count++;
            }
            else if (c == 'e')
            {
                count--;
            }
            else
            {
                return false;
            }
            if (count < 0)
            {
                return false;
            }
        }
        return true;
    }
}