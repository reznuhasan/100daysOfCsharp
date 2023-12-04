using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Practice1
{
    public class Dog:IAdress,IAnimal
    {
        public string Name { get; set; }
        
        public void SetName(string name)
        {
            Name = name;
        }
        public string location(string livingPlace)
        {
            return $"{Name} live in {livingPlace}";
        }
        public void MakeSound() {
            Console.WriteLine("ghew ghew");
        }
        public string PerformAction(string action)
        {
            return $"{Name} is {action}";
        }
        static void Main(string[] args)
        {

            Dog dog = new Dog();
            dog.SetName("Tommy");
            Console.WriteLine(dog.Name);
            Console.WriteLine(dog.location("Road"));
            dog.MakeSound();
            Console.WriteLine(dog.PerformAction("Nothing"));
            Console.ReadLine();
        }
    }
}
