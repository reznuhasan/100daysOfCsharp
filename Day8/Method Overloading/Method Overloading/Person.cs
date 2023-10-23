
using System;

class Person
{
    public string firstname;
    public string lastname;
    public Person(string fname,string lname)
    {
        this.firstname = fname;
        this.lastname = lname;
    }
    public void getName()
    {
        Console.WriteLine(this.firstname + " " + this.lastname); 
    }
    public void getName(string separate)
    {
        Console.WriteLine(this.firstname + separate+this.lastname);
    }
}