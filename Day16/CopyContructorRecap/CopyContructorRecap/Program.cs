
namespace CopyConstructorRecap
{
    class CopyConstructor
    {
        int x;
        public CopyConstructor(int x)
        {
            this.x = x;
        }
        public CopyConstructor(CopyConstructor obj)
        {
            this.x = obj.x;
        }
        public void Display()
        {
            Console.WriteLine("Value of x is {0}", x);
        }
        
        static void Main(string[] args)
        {
            CopyConstructor obj1 = new CopyConstructor(10);
            CopyConstructor obj2=new CopyConstructor(20);
            CopyConstructor obj3=new CopyConstructor(obj1);
            obj1.Display();
            obj2.Display();
            obj1.Display();
            obj3.Display();
        }
    }
    
}