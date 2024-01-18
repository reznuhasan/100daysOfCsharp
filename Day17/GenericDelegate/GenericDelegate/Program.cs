
namespace GenericDelegate
{
    public class Program
    {
        public static double AddNums(int a,float b,double c)
        {
            return a + b + c;
        }
        public static void ShowNums(int a, float b, double c)
        {
            Console.WriteLine(a + b + c);
        }
        public static bool General(string m,string n)
        {
            if(m.Length > n.Length)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            Func<int,float,double,double> obj=AddNums;
            double result=obj(1,22.44f,30.4325);
            Console.WriteLine(result);
            Action<int, float, double> obj1 = ShowNums;
            obj1(25, 34.44f, 40.645);
            Func<string,string,bool>obj2= General;
            bool result1 = obj2("Rizwan", "Ahmed");
            Console.WriteLine(result1);
            Predicate<string> obj3 = (str) => {
                if (str.Length >= 2)
                {
                    return true;
                }
                return false;
            };
            Console.WriteLine(obj3("A"));
        }
    }
}