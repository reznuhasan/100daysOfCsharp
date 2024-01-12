
namespace Matrix_Addition
{
    public class Matrix
    {
        int a, b, c, d;
        public Matrix(int a,int b,int c,int d) { 
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public static Matrix operator +(Matrix obj1,Matrix obj2)
        {
            Matrix obj=new Matrix(obj1.a+obj2.a,obj1.b+obj2.b,obj1.c+obj2.c,obj1.d+obj2.d);
            return obj;
        }
        static void Main(string[] args) {
            Matrix obj1 = new Matrix(20, 12, 36, 40);
            Matrix obj2 = new Matrix(30, 13, 50, 40);
            Matrix addMatrix = obj1 + obj2;
            Console.WriteLine("a={0},b={1},c={2},d={3}",addMatrix.a, addMatrix.b, addMatrix.c, addMatrix.d);
        }
    }
}