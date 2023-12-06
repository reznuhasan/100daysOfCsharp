using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_Recap
{
    public class Program
    {
        public string password;

        public string Password
        {
            get {
                if (password!="123456")
                {
                    return "incorrect password";
                }
                return $"User login successfully";
            }
            set {
                if (value.Length < 6)
                {
                    Console.WriteLine("Password is too Short");
                }
                else
                {
                    password = value;
                    Console.WriteLine("Password setup Successfully");
                }
            }
        }
        static void Main(string[] args)
        {
            Program obj=new Program();
            obj.Password = "123456";
            Console.WriteLine(obj.Password);
            Console.ReadLine();
        }
    }
}
