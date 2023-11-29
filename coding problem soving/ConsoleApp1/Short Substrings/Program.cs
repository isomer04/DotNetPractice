class Program
{
    static void Main(string[] args)
    {
        int testCases = int.Parse(Console.ReadLine());

        for( int i = 0; i < testCases; i++ )
        {
            string str = Console.ReadLine();

            string result = "";

            for(int j = 0; j < str.Length; j += 2)
            {
                result += str[j];
            }
            result += str[str.Length - 1];


            Console.WriteLine(result);
        }
    }
}