class Program
{
    static void Main(string[] args)
    {
        string[] weights = Console.ReadLine().Split();

        int limak = int.Parse(weights[0]);
        int bob = int.Parse(weights[1]);

        int years = 0;

        while (limak <= bob)
        {
            limak *= 3;
            bob *= 2;

            years++;
        }

        Console.WriteLine(years);
    }
}
