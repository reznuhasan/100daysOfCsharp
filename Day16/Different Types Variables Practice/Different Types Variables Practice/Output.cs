

using DPClass=Different_Types_Variables_Practice.Program;
using printOutput = System.Console;

DPClass program1 = new DPClass("program1");
/*Console.WriteLine(DPClass.number);
DPClass.number = 400;
Console.WriteLine(DPClass.number);
*/
program1.DisplayClassName();
printOutput.WriteLine(DPClass.number);
printOutput.WriteLine(DPClass.pi);
/*gives readonly variables error cause 
program1.intanceName = "Program2";
*/