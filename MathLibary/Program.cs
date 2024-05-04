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

    }
}