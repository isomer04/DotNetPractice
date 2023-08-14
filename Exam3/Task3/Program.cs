//In this task, write a Linq query to print all person data sorted according to name first and then by age (in case name is same). Print both name and age.

List<(int id, string name, int age)> persons = new List<(int id, string name, int age)>();
persons.Add((1, "Jalaluddin", 42));
persons.Add((2, "Hasan", 32));
persons.Add((3, "Maruf", 23));
persons.Add((4, "Hasan", 33));


var personNameAge = persons.OrderBy(person => person.name).ThenBy(person => person.age);

for (int i = 0; i < personNameAge.Count(); i++)
{
    Console.WriteLine($"Name: {personNameAge.ElementAt(i).name}, Age: {personNameAge.ElementAt(i).age}");
}
