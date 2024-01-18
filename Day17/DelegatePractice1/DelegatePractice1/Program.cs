

namespace DelegatePractice1
{
    public delegate void SayDelegate();
    public delegate string SendDelegate(string dev);
    public delegate int OperationDelegate(int a,int b);
    public class Program
    {
        string name;
        int a, b;
        public Program(string name,int a,int b)
        {
            Console.WriteLine("Constractor Called Perfectly");
            this.name = name;
            this.a = a;
            this.b = b;
         }
        public void SayHello()
        {
            Console.WriteLine("Hello "+this.name);
        }
        public static string SendMessage(string Dev)
        {
            return "Hello Form " ;
        }
        public int AddValue(int a,int b)
        {
            return a + b;
        }
        public int SubValue(int a,int b)
        {
            return a - b;
        }
        public int MultiValue(int a,int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            Program obj = new Program("Rizwan",30,40);
            SayDelegate say = new SayDelegate(obj.SayHello);
            say();
            SendDelegate send = new SendDelegate(SendMessage);
            Console.WriteLine(send("Alaudding"));
            OperationDelegate add = new OperationDelegate(obj.AddValue);
           int myValue= add(50, 60);
            OperationDelegate sub=new OperationDelegate(obj.SubValue);
            Console.WriteLine(myValue);
            Console.WriteLine(sub(70,32));
        }

    }
}