
namespace ConstructorChaining
{
    public class Program
    {
        public string name;
        public string description;
        public Program(string name):this(name,"Alif Layla"){ 
            this.name = name;
            Console.WriteLine("One Paramiterlaized Constructor");
        }
        public Program(string name,string description)
        {
            this.name = name;
            this.description = description;
            Console.WriteLine("Two Paramiterlaized Constructor");
        }
        /*public Program():this("Hossen","He is a playboy")
        {
            Console.WriteLine("Paramiterless Constructor");
        }*/
        public void Display()
        {
            Console.WriteLine("Name={0},des={1}", this.name, this.description);
        }
        static void Main(string[] args)
        {
           /* Program obj = new Program();
            obj.Display();*/
        }
    }
}
