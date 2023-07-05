class Program
{
    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine());

        for (int i = 0; i < testCases; i++)
        {
            char character = char.Parse(Console.ReadLine());

            if (character == 'c' || character == 'o' || character == 'd' || character == 'e' || character == 'f' || character == 'o' || character == 'r' || character == 'c' || character == 'e' || character == 's')


                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
