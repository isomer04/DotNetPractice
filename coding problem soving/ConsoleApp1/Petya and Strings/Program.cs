class Program
{
    static void Main(string[] args)
    {
        string str1 = Console.ReadLine().ToLower();
        string str2 = Console.ReadLine().ToLower();

        int result = 0;

        for(int i = 0; i < str1.Length; i++)
        {
            if (str1[i] < str2[i])
            {
                result = -1;
                break;
            } else  if (str1[i] > str2[i])
            {
                result = 1;
                break;
            } 
        }

        Console.WriteLine(result);


    }
}