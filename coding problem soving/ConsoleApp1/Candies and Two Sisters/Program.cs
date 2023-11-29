class Program
{
    public static void Main(string[] args)
    {
        int testCases = int.Parse(Console.ReadLine());

        for(int i = 0; i < testCases; i++)
        {
            int input = int.Parse(Console.ReadLine());

            int output = (input - 1) / 2;

            Console.WriteLine(output);
        }
    }
}