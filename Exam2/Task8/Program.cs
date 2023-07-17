//Create a Generic class named Grid that takes two generic parameters. Create two properties using those generic parameters and apply generic parameter constraint so that the first parameter must be class and the 2nd parameter must be structure.


class Grid<T, S> where T : class where S : struct
{
    public T MyProperty { get; set; }
    public S MyProperty1 { get; set; }
}