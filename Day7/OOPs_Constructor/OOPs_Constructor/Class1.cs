
class Person
{
    string name;
    int age;
    public Person(string name,int age)
    {
        this.name = name;
        this.age = age;
    }
    public string showDetails()
    {
        return this.name + " " + this.age;
    }
}
