
class Program
{
    static void Main(string[] args)
    {
        int testCases = int.Parse(Console.ReadLine());

        for (int i = 0; i < testCases; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');

            int n = int.Parse(inputs[0]);
            int x = int.Parse(inputs[1]);

            int floor = 1;

            if (n > 2)
            {
                floor = (n - 3) / x + 2;
            }

            Console.WriteLine(floor);
        }
    }
}
