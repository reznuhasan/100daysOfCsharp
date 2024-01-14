
namespace StructureRecap
{
    public interface ITest
    {
         void GetName();
    }
    public interface ITest1
    {
        void GetAge();
    }
    public struct Program:ITest,ITest1
    {
        public Program() {
            Console.WriteLine("Structure Constractor Called");
        }
        public void GetName() {
            Console.WriteLine("My Name is Rizwan");
        }
        public void GetAge()
        {
            Console.WriteLine("My Age is 25");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.GetName();
            program.GetAge();
        }
    }
    /*public struct Test : Program
    {

    }*/
}