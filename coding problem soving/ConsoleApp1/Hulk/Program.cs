using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string str = "I hate";

        for (int i = 2; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                str += " that I love";


            }
            else
            {
                str += " that I hate";

            }
        }

        str += " it";

        Console.WriteLine(str);
    }
}
