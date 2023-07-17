//Do the same as task 6, but this time using anonymous object.





List<object> lists = new List<object>();

lists.Add(("James wagner", 25));
lists.Add(("Jackson Heights", 45));
lists.Add(("Ray White", 24));





foreach (object list in lists)
{
    Console.WriteLine(list);
}

