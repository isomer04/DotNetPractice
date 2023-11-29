class Program
{
    static void Main(string[] args)
    {
        int testCases = int.Parse(Console.ReadLine());

        for(int i = 0; i < testCases; i++)
        {
            int num = int.Parse(Console.ReadLine());

            int count = 0;
            int digit = 1;
            int power = 0;

            while(digit <= num)
            {
                count += digit;

                digit = digit * 10 +1;
                power++;
            }

            Console.WriteLine(count);
        }
    }
}