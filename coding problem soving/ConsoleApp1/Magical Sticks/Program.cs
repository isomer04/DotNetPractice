class Program
{
    static void Main(string[] args)
    {
        int testCases =  int.Parse(Console.ReadLine());

        for(int i = 0; i < testCases; i++)
        {
            int n =  int.Parse(Console.ReadLine());

            int rssult = (n + 1) / 2;
            Console.WriteLine(rssult);
        }
    }
}