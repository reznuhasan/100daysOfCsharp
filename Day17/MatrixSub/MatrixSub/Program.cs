
namespace MatrixSub
{
    public class Program
    {
        int a, b,c,d;
        public Program(int a,int b,int c,int d)
        {
            this.a = a; this.b = b; 
            this.c = c; this.d = d;
        }
        public override string ToString()
        {
            return "a = "+this.a+" b = "+this.b+" c = "+this.c+" d = "+this.d;
        }
        public static Program operator +(Program obj1, Program obj2)
        {
            Program obj = new Program(obj1.a - obj2.a, obj1.b - obj2.b, obj1.c - obj2.c, obj1.d - obj2.d);
            return obj;
        }
        static void Main(string[] args)
        {
            Program obj1 = new Program(43,23,33,53);
            Program obj2 = new Program(10, 20, 30, 40);
            Program obj=obj1 + obj2;
            Console.WriteLine(obj);

        }
    }
}
