

using myIndex= IndexerPractice.Program;

myIndex obj = new myIndex(1010, 10, "Alauddin", "Science", "A", 88.99);

for(int i = 0; i < 6; i++)
{
    Console.WriteLine(obj[i]);
}
Console.WriteLine("Student Previous Marks : " + obj["marks"]);
obj[5] = 34.56;
Console.WriteLine("Student Present Marks : " + obj["marks"]);
