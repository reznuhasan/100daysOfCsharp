//static ways file create

using System.Text;

String filePath = "../../../Test/Hello.txt";
if (File.Exists(filePath))
{
    Console.WriteLine("File already Exist");
}
else
{
    Console.WriteLine("Create File Successfully");
    File.Create(filePath);
}
if (File.Exists(filePath))
{
    File.WriteAllText(filePath, "I will trying my best in this field.");
    //File.WriteAllText(filePath, "Until,Unless I fulfill My Own Ambition");
}
String filePath1 = "../../../Test/Hello1.txt";

FileInfo fileInfo=new FileInfo(filePath1);
if (fileInfo.Exists)
{
    Console.WriteLine("File Info Already Exists");
}else
{
    fileInfo.Create();
}

using Stream fileStream = fileInfo.Open(FileMode.Open);
string message = "I'm unstopable";
byte[] bytes=Encoding.UTF8.GetBytes(message);
fileStream.Write(bytes, 0, message.Length);
fileStream.Flush();