class Program
{
    static void Main(string[] args)
    {
        long inputDigit1 = long.Parse(Console.ReadLine());


        long result = 0;

        {
            if(inputDigit1 % 2 == 0)
            {
                result = inputDigit1 /2;
            }
            else
            {
                result = -(inputDigit1 + 1) /2;


            }
        } 


        Console.WriteLine(result);


    }
}
