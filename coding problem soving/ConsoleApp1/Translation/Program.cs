class Program
{
    static void Main(string[] args)
    {
      

        string inputString1 = Console.ReadLine();
        string inputString2 = Console.ReadLine();

       
        char[] stringArray = inputString1.ToCharArray();
        Array.Reverse(stringArray);
        string reversedStr = new string(stringArray);
       
        if (reversedStr == inputString2) {
            Console.WriteLine("YES");
        } else
        {
            Console.WriteLine("NO");
        }

      
    }



}
