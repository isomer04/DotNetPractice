//Create a List<> of Tuple. The Tuple should have a string name and int age. Add some value in it and then print all values using loop.


using System.Collections.Generic;

List<(string name, int age)> lists = new List<(string name, int age)>();

lists.Add(("James wagner", 25));
lists.Add(("Jackson Heights", 45));
lists.Add(("Ray White", 24));





foreach ((string name, int age) list in lists)
{
    Console.WriteLine(list);
}
 