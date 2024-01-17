
namespace OperatorOverloadingPractice
{
    public class Program
    {
        double dollars;
        double taka;
        public Program(double dollars, double taka)
        {
            this.dollars = dollars; this.taka = taka;
        }
        public override string ToString()
        {
            return "Dollars = "+this.dollars+ "\nTaka = "+this.taka;
        }
        public static Program operator +(Program obj1,Program obj2)
        {
            Program obj = new Program(obj1.dollars+obj2.dollars,obj1.taka+obj1.taka);
            return obj;
        }
        static void Main(string[] args)
        {
            Program obj1 = new Program(10, 123);
            Program obj2 = new Program(20, 30);
            Program obj=obj1 + obj2;
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(obj);
        }
    }
}
