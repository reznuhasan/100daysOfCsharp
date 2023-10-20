long myValue;
while (true)
{
    myValue = long.Parse(Console.ReadLine());
    if(myValue>=1 && myValue<= 1000000000000000000)
    {
        break;
    }
}
int flag = 0;
int totalNumber = 0;
while (myValue>0)
{
    int reminder = (int)(myValue % 10);
    if(reminder==7 || reminder == 4)
    {
        flag++;
    }
    myValue /= 10;
    totalNumber++;

}


 int count = 0;
 int countNo = 0;
 while (flag > 0)
    {
      int res = flag % 10;
      if(res==4 || res == 7)
        {
            count++;
        }
      countNo++;
      flag /= 10;

    }
 if (count == countNo)
    {
      Console.WriteLine("YES");
 }
 else
   {
     Console.WriteLine("NO");
 }
}
           
Console.ReadLine();