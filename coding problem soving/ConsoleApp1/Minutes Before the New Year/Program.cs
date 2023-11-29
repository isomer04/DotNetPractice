class Program
{
    static void Main(string[] args)
    {
        int testCases =  int.Parse(Console.ReadLine());

        for (int i = 0; i < testCases; i++)
        {
            string[] inputStrArray = Console.ReadLine().Split(); ;

            int h = int.Parse(inputStrArray[0]);
            int m = int.Parse(inputStrArray[1]);

            int output = (24 * 60) - (h  * 60 +  m);

            Console.WriteLine(output);


        }
    }
}