//Create a HashSet of type string. Take some names as input from the user and finally print the names from HashSet. Give duplicate names in input. 

HashSet<string> nameHashSet = new HashSet<string>();

string input1 = Console.ReadLine();
string input2 = Console.ReadLine();

string input3 = Console.ReadLine();
string input4 = Console.ReadLine();



nameHashSet.Add(input1);
nameHashSet.Add(input2);
nameHashSet.Add(input3);
nameHashSet.Add(input4);

foreach (string name in nameHashSet)
{
    Console.WriteLine(name);
}





