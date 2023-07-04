class Program
{
    public static void Main(string[] args)
    {
        int testCases = int.Parse(Console.ReadLine());

        for (int i = 0; i < testCases; i++)
        {
            string[] inputStr = Console.ReadLine().Split();

            int a = int.Parse(inputStr[0]);
            int b = int.Parse(inputStr[1]);

            int output = 0;

            if (a % b == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(b - (a % b));
            }
        }

    }
}