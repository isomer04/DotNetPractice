public class Program
{
    public static void Main(string[] args)
    {
        int lengthStr = int.Parse(Console.ReadLine());

        int count = 0;

        string str = Console.ReadLine();

        for (int i = 0; i < lengthStr; i++)
        {
            if (i > 0 && str[i] == str[i - 1])
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}