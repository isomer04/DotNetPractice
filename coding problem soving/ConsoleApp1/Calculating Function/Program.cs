class Program
{
    static void Main(string[] args)
    {
        int inputDigit1 = int.Parse(Console.ReadLine());


        int result = 0;

        for(int i = 1; i< inputDigit1+1; i++)
        {
            if(i % 2 == 0)
            {
                result += i;



            }
            else
            {
                result -= i;


            }
        } 


        Console.WriteLine(result);


    }
}
