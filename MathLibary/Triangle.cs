namespace MathLibary
{
    internal class Triangle : Rectangle
    {
        public double c {  get; set; }
        public double Area()
        {
            double p,s;
            p = (a + b + c)/2;
            s = p * (p - a) * (p - b) * (p - c);
            return Math.Sqrt(s);
        }
    }
}
