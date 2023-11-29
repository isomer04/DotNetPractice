class Program
{
     static void Main(string[] args)
    {
        int numOfpolyhedrons = int.Parse(Console.ReadLine());


        int output = 0;

        for(int i = 0; i < numOfpolyhedrons; i++)
        {
            string polyhedrons = Console.ReadLine();
            if (polyhedrons == "Tetrahedron")
            {
                output += 4;
            } else if (polyhedrons == "Cube")
            {
                output += 6;
            } else if(polyhedrons == "Octahedron")
            {
                output += 8;
            } else if (polyhedrons == "Dodecahedron")
            {
                output += 12;
            } else if(polyhedrons == "Icosahedron")
            {
                output += 20;
            }
        }

        Console.WriteLine(output);
    }
}