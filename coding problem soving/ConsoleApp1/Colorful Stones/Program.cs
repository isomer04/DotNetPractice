class Program
{
    public static void Main(string[] args)
    {
        string strS = Console.ReadLine();
        string strT = Console.ReadLine();

        int index = 1; 

        for (int i = 0; i < strT.Length; i++)
        {
            if (strS[index - 1] == strT[i])
            {
                index++; 
            }
        }

        Console.WriteLine(strT);
    }
}
