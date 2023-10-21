
using System;

class Student
{
    string name;
    int roll;
    public Student(string name,int roll)
    {
        this.name = name;
        this.roll = roll;
    }
    public Student(Student obj)
    {
        this.name = obj.name;
        this.roll = obj.roll;
    }
    public void ShowDetails()
    {
        Console.WriteLine("My name is {0}.My age {1}", name, roll);
    }
}
