class Program
{
    public static void Main()
    {
        var square1 = new Square(5);
        var square2 = new Square(10);

        Console.WriteLine($"Side: {square1.Side}\nArea: {square1.Area()}\nPerimeter: {square1.Perimeter()}");
        Console.WriteLine($"Side: {square2.Side}\nArea: {square2.Area()}\nPerimeter: {square2.Perimeter()}");
    }
}
