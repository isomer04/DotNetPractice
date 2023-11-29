using System;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();

        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);

        bool colored = false;

        //string[] row = Console.ReadLine().Split();


        for (int i = 0; i < n; i++)
            
        {
            //Console.WriteLine("Give Char input ");

            string[] row = Console.ReadLine().Split();

            for (int j = 0; j < m; j++)
            {


                if (row[j] == "C" || row[j] == "M" || row[j] == "Y")
                {
                    colored = true;
                    break;
                }
            }

            if (colored)
                break;
        }

        if (colored)
        {
            Console.WriteLine("#Color");

        }
        else
        {
            Console.WriteLine("#Black&White");

        }
    }
}
