
using System.Text;

String path=Directory.GetCurrentDirectory();
// make a file
DirectoryInfo directoryInfo=new DirectoryInfo(path);
String pathName =Path.Combine(directoryInfo.Parent.Parent.Parent.FullName,"Test");
Console.WriteLine(pathName);
DirectoryInfo directoryInfo1=new DirectoryInfo(pathName);

if (!directoryInfo1.Exists)
{
    directoryInfo1.Create();
    Console.WriteLine("File Create Successfully");
}

String fileInfoPath = Path.Combine(pathName, "Hello.txt");
FileInfo fileInfo=new FileInfo(fileInfoPath);

if (!fileInfo.Exists)
{
    fileInfo.Create();
    Console.WriteLine("File Create Successfully");
}

Stream fileStream = fileInfo.Open(FileMode.Open);
String message = "Hello Everyone,Subscribe My Channel";
byte[] bytes=Encoding.UTF8.GetBytes(message);
/*fileStream.Write(bytes,0,bytes.Length);
fileStream.Flush();*/

byte[] bytes1=new byte[fileInfo.Length];
string outText=Encoding.UTF8.GetString(bytes);
int outCount = fileStream.Read(bytes1, 0, bytes1.Length);
Console.WriteLine(outText);
Console.WriteLine(outCount);
