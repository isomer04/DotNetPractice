//Create an enum named “Fruits” and add 5 options in it with specific values 5, 8, 9, 4, 6 for the options. Create a class and create a property with Fruits type, create a method that takes Fruits type as parameter. You do not need to implement the body of the method.

enum Fruits
{
    Strawberry = 5,
    BlueBerry = 8,
    RaseBerry = 9,
    Cranberry = 4,
    Blackberry = 6
}

class Fruit
{
    public Fruits Fruits { get; set; }

    public void FruitTypeMethod(Fruits fruits)
    {

    }
}