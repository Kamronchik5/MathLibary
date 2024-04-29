namespace MathLibary
{
    internal class Fibonaci
    {
        public void Fibo(int x)
        {
            Console.WriteLine("Input the n");
            string numbs = Console.ReadLine();
            int n = Convert.ToInt32(numbs);
            int[] numbers = new int[n];
            numbers[0] = 0;
            numbers[1] = 1;

            for (int i = 2; i < n; i++)
            {
                numbers[i] = numbers[i - 1] + numbers[i - 2];
            }
            foreach (int num in numbers)
            {
                Console.Write(num + "  ");
            }
        }  
    }
}
