// See https://aka.ms/new-console-template for more information
using System.Text;

String filePath = "../../../Test/Hello1.txt";
if (!File.Exists(filePath))
{
    File.Create(filePath);
}
else
{
    Console.WriteLine("File Already Exists");
}
File.WriteAllText(filePath, "I am Rizwan Hasan .NET Developer");
String filePath1 = "../../../Test/Hello2.txt";
FileInfo fileInfo = new FileInfo(filePath1);
if (!fileInfo.Exists)
{
    fileInfo.Create();
}
else
{
    Console.WriteLine("File Info Already Create");
}
using Stream fileStream = fileInfo.Open(FileMode.Open);
String message = "I am nothing to say.";
String message1 = "Hello How Are You";
byte[] bytes1=Encoding.UTF8.GetBytes(message1);
byte[] bytes=Encoding.UTF8.GetBytes(message);
fileStream.Write(bytes, 0, message.Length);
fileStream.Write(bytes1,0, message1.Length);
fileStream.Flush();