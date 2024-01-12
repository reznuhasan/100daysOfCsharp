
namespace MethodOverridingRecap
{
    public class Person
    {
       public virtual void Display() {
            Console.WriteLine("Parent Method");
        }
        public void Display1()
        {
            Console.WriteLine("Parent Hiding");
        }
    }
}
