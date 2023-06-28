class Program
{
    static void Main(String[] args)
    {
        int numOfTestcases = int.Parse(Console.ReadLine());

        for(int i = 0; i < numOfTestcases; i++)
        {
            int ratingINt = int.Parse(Console.ReadLine());

            if (ratingINt >= 1900)
            {
                Console.WriteLine("Division 1");
            } else if (ratingINt >= 1600)
            {
                Console.WriteLine("Division 2");

            } else if(ratingINt >= 1400)
            {
                Console.WriteLine("Division 3");
            } 
            else Console.WriteLine("Division 4");
            
        }
    }
}