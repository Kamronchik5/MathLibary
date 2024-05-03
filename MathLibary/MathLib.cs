using System.Diagnostics.CodeAnalysis;

namespace MathLibary
{
    internal class MathLib
    {
        public void Fibo(int x)
        {
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
                return num;
            }
        }  
        public bool Tub(int n) 
        {
            for (int i = 2; i * i <= n;i++)
                if(n%i == 0) return false;
            return true;
        }
        public bool Pifagor(double a,double b,double p)
        {
            double r;
            r =(a * a + b * b);
            if (p * p == r) return true;
            return false;
        }
        
    }
}
