// See https://aka.ms/new-console-template for more information
using System.Text;

String path = "../../../Test/Hello.txt";

FileInfo fileInfo=new FileInfo(path);

/*if (!fileInfo.Exists)
{
    Console.WriteLine("file create successfully");
    fileInfo.Create();
}
else
{
    Console.WriteLine("file already exist");
    using Stream fileStream =fileInfo.Open(FileMode.Open);
    String message = "I will try my best";
    byte[] bytes=Encoding.UTF8.GetBytes(message);
    fileStream.Write(bytes, 0, bytes.Length);
    fileStream.Flush();

    byte[] bytes1 = new byte[fileInfo.Length];
    int count=fileStream.Read(bytes1, 0, bytes1.Length);
    String outText=Encoding.UTF8.GetString(bytes1);
    Console.WriteLine(outText);
    Console.WriteLine(count);
}
*/

if(!fileInfo.Exists)
{
    Console.WriteLine("File is not found");
}
else
{
   using Stream fileStream= fileInfo.Open(FileMode.Open);
    byte[] bytes=new byte[fileInfo.Length];
    int count=fileStream.Read(bytes, 0, bytes.Length);
    String outText=Encoding.UTF8.GetString(bytes);
    Console.WriteLine("{0} , {1}",count,outText);
}


