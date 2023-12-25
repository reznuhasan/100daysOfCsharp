String path = "../../../temp";
if (!Directory.Exists(path))
{

    Directory.CreateDirectory(path);
}

DirectoryInfo directoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory());
String path1 = Path.Combine(directoryInfo.Parent.Parent.Parent.FullName,"temp1");
String path2 = directoryInfo.Parent.Parent.Parent.FullName;
DirectoryInfo directoryInfo1= new DirectoryInfo(path1);
DirectoryInfo directoryInfo2=new DirectoryInfo(path2);
if (!directoryInfo1.Exists)
{
    directoryInfo1.Create();
    Console.WriteLine("directoryInfo1 create successfully");
}
if (!directoryInfo2.Exists)
{
    Console.WriteLine("directory Info create successfully");
    directoryInfo.Create();
}
else
{  
    foreach (var d in directoryInfo1.Parent.Parent.GetDirectories())
    {
        foreach (var f in d.GetFiles())
        {
            Console.WriteLine(f.FullName);
        }
    }
}

