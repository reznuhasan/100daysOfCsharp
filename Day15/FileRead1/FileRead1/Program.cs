// See https://aka.ms/new-console-template for more information
if (!File.Exists("../../../Test/Hello.txt"))
{
    File.Create("../../../Test/Hello.txt");
}
File.WriteAllText("../../../Test/Hello.txt", "I'm Rizwan");

if (File.Exists("../../../Test/Hello.txt"))
{
    Console.WriteLine("File is Exist");
    String text= File.ReadAllText("../../../Test/Hello.txt");
    Console.WriteLine(text); 
}
else
{
    Console.WriteLine("File is Not Found");
}