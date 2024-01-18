
namespace DelegatePractice2
{
    public delegate void GreetingsDelegate(string name);
    public delegate string FindNameDelegate(string name);
    public delegate int OperationDelegate(int a,int b);
    public class Program
    {
        public static void Greetings(String name)
        {
            Console.WriteLine("Hello " + name + ", Good Morning");
        }
        static void Main(string[] args)
        {
            GreetingsDelegate obj = Program.Greetings;
            obj("Rizwan");
            FindNameDelegate findName = delegate (string name)
            {
                return name;
            };
            string Name=findName("Leo");
            //annonymus delegate
            OperationDelegate add = delegate (int a, int b)
            {
                return a + b;
            };
            //lamda delegate
            OperationDelegate sub = (int c, int d) =>
            {
                return c - d;
            };
            Console.WriteLine(add(45, 69));
            Console.WriteLine(sub(20, 12));
            Console.WriteLine(Name);

        }
    }
}