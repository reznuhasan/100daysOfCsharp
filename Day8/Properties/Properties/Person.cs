
using System;

class Person
{
    private string firstName;
    private string lastName;
    private string password;
    public string FirstName
    {
        get
        {
            while (true)
            {
                Console.Write("Enter your password:");
                string userpassword = Console.ReadLine();
                if (userpassword == password)
                {
                    break;
                }
                Console.WriteLine("wrong password (: try again");
            }
            return this.firstName;
        }
        set
        {
            
            while (true)
            {
                Console.Write("Enter your password:");
                string userpassword = Console.ReadLine();

                if (userpassword == password)
                {
                    break;
                }
                Console.WriteLine("wrong password (: try again");
            }
            while (true)
            {
                Console.Write("Enter your firstname:");
                value = Console.ReadLine();

                if (!string.IsNullOrEmpty(value))
                {
                    this.firstName = value;
                    Console.WriteLine("value insert successfully");
                    break;
                }
                Console.WriteLine("first name is not valid");
            }
        }
    }
    public string LastName{
        get
        {
            return this.lastName;
        }
        set
        {
            this.lastName = value;
        }
    }
    public Person()
    {
        this.firstName = "Rizwan";
        this.lastName = string.Empty;
        this.password = string.Empty;
    }
    public Person(string password):this()
    {
        this.password = password;
    }
}