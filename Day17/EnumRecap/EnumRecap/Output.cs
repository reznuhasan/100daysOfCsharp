

using EnumRecap;
using TestNameSpace;

TestClass obj=new TestClass();
obj.TakeDays(Days.Tuesday);
foreach (int day in Enum.GetValues(typeof(Days)))
{
    Console.WriteLine(day+" : "+(Days)day);
}
foreach (string day in Enum.GetNames(typeof(Days)))
{
    Console.WriteLine(day);
}