class Program
{
    public static void Main(string[] args)
    {
        int testCases = int.Parse(Console.ReadLine());

        for(int i = 0; i < testCases; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int a  = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);
            int c = int.Parse(inputs[2]);

            int x = int.Parse(inputs[3]);
            int y = int.Parse(inputs[4]);

            if (x <= a && y <= b && (x + y) <= c)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}