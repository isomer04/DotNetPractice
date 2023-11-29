class Program
{
    public static void  Main(string[] args)
    {
        string[] strArray =  Console.ReadLine().Split(' ');

        int[] diffColor = new int[4];

        for(int i = 0; i < strArray.Length; i++)
        {
            diffColor[i] = int.Parse(strArray[i]);
        }

        HashSet<int> uniqueColor = new HashSet<int>(diffColor);

        

        int minShoes1 = 4 - uniqueColor.Count;

        Console.WriteLine(minShoes1);



    }
}