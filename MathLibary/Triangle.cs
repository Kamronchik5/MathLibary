namespace MathLibary
{
    internal class Triangle : Rectangle
    {
        public double Area(double a , double b , double c)
        {
            double p,s;
            p = (a + b + c);
            s = p * (p - a) * (p - b) * (p - c);
            return Math.Sqrt(s);
        }
    }
}
