using MathLibary;

internal class Program
{
    private static void Main(string[] args)
    {
        MathLib obj = new MathLib();
        c = Convert.ToInt32(Console.ReadLine());

        switch (c)
        {
             case 1:
                {
                    obj.Fibo(20);
                    break;
                }
             case 2:
                {
                    obj.Tub(23);
                    break;
                }
             case 3:
                {

                }

        }
    }
}