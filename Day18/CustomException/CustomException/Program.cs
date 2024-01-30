

try
{
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    if (b % 2 == 1)
    {
        throw new ApplicationException("odd number not allowed");
    }
    int c = a / b;
    Console.WriteLine("the result is {0}", c);
}catch(FormatException ex1)
{
    Console.WriteLine("Only Numric value are allowed");
}catch(DivideByZeroException ex2)
{
    Console.WriteLine("Divided by Zero is not possible");
}catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Division Part are finished");
}
Console.WriteLine("Program are End");