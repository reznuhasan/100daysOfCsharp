
class Person
{
    public string fname;
    public string lname;
    public Person() : this(string.Empty, string.Empty) { }
    public Person(string fname,string lname)
    {
        this.fname = fname;
        this.lname = lname;
    }
}
