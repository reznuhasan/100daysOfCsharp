
namespace Matrix_Multiplication
{
   public class Matrix
    {
        int a, b,c,d;
      public Matrix(int a,int b,int c,int d) {
           this.a = a; this.b = b;
           this.c = c; this.d = d;
      }
      public static Matrix operator *(Matrix obj1, Matrix obj2) {
            int first = (obj1.a * obj2.a) + (obj1.b * obj2.c);
            int second= (obj1.a * obj2.b)+(obj1.b * obj2.d);
            int third=(obj1.c*obj2.a)+(obj1.d*obj2.c);
            int fourth = (obj1.c * obj2.b) + (obj1.d * obj2.d);
            Matrix obj = new Matrix(first,second,third,fourth);
            return obj;
        }
    public void Display()
        {
            Console.WriteLine("a={0},b={1},c={2},d={3}",this.a,this.b,this.c,this.d);
        }
    }
}