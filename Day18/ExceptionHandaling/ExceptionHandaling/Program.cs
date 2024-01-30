

try
{
    int a = int.Parse(Console.ReadLine());
    int b=int.Parse(Console.ReadLine());
    double d = (double)a / (double)b;
    Console.WriteLine("The Result is {0}",d);
}
catch(DivideByZeroException ex1)
{
    Console.WriteLine(ex1.Message);
    Console.WriteLine("Divide By Zero It's not possible");
}
catch(FormatException ex2)
{
    Console.WriteLine(ex2.Message);
    Console.WriteLine("The input must be numeric");
}
catch(Exception ex)
{
    Console.WriteLine(ex.ToString());
}
finally
{
    Console.WriteLine("Try Catch Part is complete");
}
Console.WriteLine("Program is end");