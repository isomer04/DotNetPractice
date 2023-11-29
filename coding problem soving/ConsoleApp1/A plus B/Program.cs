using System;

class Program
{
    static void Main(string[] args)
    {
        int testCases = int.Parse(Console.ReadLine());

        for (int i = 0; i < testCases; i++)
        {
            string str = Console.ReadLine();

            string[] eachTest = str.Split('+');

            int a = int.Parse(eachTest[0]);
            int b = int.Parse(eachTest[1]);

            int result = a + b;

            Console.WriteLine(result);
        }
    }
}
