using System.Text;

Random random = new Random(DateTime.Now.Millisecond);

long fileSizeBytes = 5 * (long)Math.Pow(1024,1);
StringBuilder fileContent = new StringBuilder();
for (int i = 0; i < fileSizeBytes; i++)
    fileContent.Append(GetRandomChar());

DirectoryInfo mainDirtory=new DirectoryInfo(Directory.GetCurrentDirectory());
String pathFile= mainDirtory.Parent.Parent.FullName;
Console.WriteLine(pathFile);
char GetRandomChar()
{
    return (char)random.Next('A', 'Z');
}