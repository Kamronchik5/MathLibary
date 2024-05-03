using MathLibary;

internal class Program
{
    private static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle();
        Triangle obj = new Triangle();
        Console.WriteLine(rectangle.Area(50, 60));
        Console.WriteLine(obj.Area(20, 30,40));
    }
}