class Program
{
    public  static void Main(string[] args)
    {
        int testCases = int.Parse(Console.ReadLine());


        for(int i = 0; i < testCases; i++)
        {
            string s = Console.ReadLine().ToUpper();
            
           if(s == "YES") Console.WriteLine("YES");
           else Console.WriteLine("NO");
        }

    }
}