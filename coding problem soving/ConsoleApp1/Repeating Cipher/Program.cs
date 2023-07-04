using System.ComponentModel.DataAnnotations;

class Program
{
    public static void Main(string[] args)
    {
        int legnthOfString = int.Parse(Console.ReadLine());

        int repeat = 1;
        string str = Console.ReadLine();

        string result = Console.ReadLine();

        for(int i = 0; i< legnthOfString; i += repeat)
        {
            result += str[i];
            repeat++;
        }

        Console.WriteLine(result);


    }
}