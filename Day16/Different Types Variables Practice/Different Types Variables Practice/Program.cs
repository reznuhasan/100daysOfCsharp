

namespace Different_Types_Variables_Practice
{
    public class Program
    {
       public static int number = 300;
        public const float pi = 3.14f;
        public readonly string intanceName;

        public Program(string name)
        {
            intanceName = name;
        }
        public void DisplayClassName()
        {
            Console.WriteLine(intanceName);
        }
    }
}