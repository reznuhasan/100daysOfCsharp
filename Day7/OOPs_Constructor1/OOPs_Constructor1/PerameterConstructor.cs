
using System;

class Person
{
    string name;
    int age;
    public Person(string name,int age)
    {
        this.name = name;
        this.age = age;
    }
    public void showDetails()
    {
        Console.WriteLine("My name is {0}.My age {1}",name,age);
    }
}
