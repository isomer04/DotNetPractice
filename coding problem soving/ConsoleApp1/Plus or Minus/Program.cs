class Program
{
    static void Main(string[] args)
    {
        int testCases = int.Parse(Console.ReadLine());

        for (int i = 0; i < testCases; i++)
        {
            string[] input = Console.ReadLine().Split();

            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);

            if( a + b == c ) Console.WriteLine("+");
            else Console.WriteLine("-");
        }
    }
}
