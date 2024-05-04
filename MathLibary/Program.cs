using MathLibary;

internal class Program
{
    private static void Main(string[] args)
    {
        MathLib math = new MathLib();
        math.a = 3;
        math.b = 4;
        math.p= 5;
        Console.WriteLine(math.Pifagor());

        int n = int.Parse(Console.ReadLine());
        int[] fib = new int[n];
        fib = math.Fibonaci(n);

        foreach (int  result in fib)
        {
            Console.WriteLine(result);
        }

       Console.WriteLine(math.Tub(10));

        Rectangle angle = new Rectangle();
        angle.a = 10;
        angle.b = 20;
        Console.WriteLine(angle.Area());

        Triangle triangle = new Triangle();
        triangle.a = 10;
        triangle.b = 20;
        triangle.c = 30;
        
        Console.WriteLine(triangle.Area());

    }
}