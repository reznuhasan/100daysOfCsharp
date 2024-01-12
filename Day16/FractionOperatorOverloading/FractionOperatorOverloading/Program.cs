
namespace FractionOperatorOverloading
{
    public class Fraction
    {
        int a;
        int b;
        public Fraction(int a = 0, int b = 0)
        {
            this.a = a;
            this.b = b;
        }
        public static double operator +(Fraction obj1, Fraction obj2)
        {
            double c=(double)obj1.a/(double)obj1.b;
            double d=(double)obj2.a/(double)obj2.b;
            return c + d;
        }
        public static double operator -(Fraction obj1, Fraction obj2)
        {
            double c = (double)obj1.a / (double)obj1.b;
            double d = (double)obj2.a / (double)obj2.b;
            return c - d;
        }
        static void Main(string[] args)
        {
            Fraction obj1 = new Fraction(2,4);
            Fraction obj2= new Fraction(8,8);
            double value=obj1+obj2;
            double value2 = obj2 - obj1;
            Console.WriteLine(value);
            Console.WriteLine(value2);  

        }
    }
}
