
namespace AbstractRecap
{
    public abstract class Person
    {
        public abstract void ShowName(string name);
    }
    public class Employee:Person
    {
        public override void ShowName(string name)
        {
            Console.WriteLine(name);
        }
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.ShowName("Rizwan");
        }
    }
 
}
