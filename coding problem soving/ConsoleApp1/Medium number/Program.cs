class Program
{
    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine());

        for (int i = 0; i < testCases; i++)
        {
            string[] inputStr = Console.ReadLine().Split();

            int a = int.Parse(inputStr[0]);
            int b = int.Parse(inputStr[1]);
            int c = int.Parse(inputStr[2]);

            if (a < b)
            {
                if (b < c)
                {
                    Console.WriteLine(b);
                }
                else if (a < c)
                {
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(a);
                }
            }

            else
            {
                if (a < c)
                {
                    Console.WriteLine(a);
                }
                else if (b < c)
                {
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(b);
                }

            }
        }
    }
}
