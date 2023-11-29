class Program
{
    static void Main(string[] args)
    {
        int inputDigit1 = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');


        int[] responses = new int[inputDigit1];

        for(int i = 0; i< inputDigit1; i++)
        {
            responses[i] = int.Parse(input[i]); 
        }  

        bool hardProblem = false;
        
        for(int i  = 0; i < inputDigit1; i++)
        {
            if (responses[i] == 1)
            {
                hardProblem = true;
                break;
            } 
            
        }

        if (hardProblem) {
            Console.WriteLine("HARD");
        } else
        {
            Console.WriteLine("EASY");
        }

    }
}
