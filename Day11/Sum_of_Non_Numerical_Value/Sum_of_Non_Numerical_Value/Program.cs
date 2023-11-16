using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Non_Numerical_Value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value1 = Console.ReadLine();
            string value2 = Console.ReadLine();
            StringBuilder sum=new StringBuilder();
            int len = 0;
            int dif = 0;
            string big, smalll;
            if (value1.Length > value2.Length)
            {
                len=value2.Length-1;
                dif=value1.Length-value2.Length;
                big = value1.Substring(0, value1.Length);
                smalll = value2.Substring(0,value2.Length);
            }
            else
            {
                len= value1.Length-1;
                dif = value2.Length - value1.Length;
                big = value2.Substring(0, value2.Length);
                smalll = value1.Substring(0, value1.Length);
            }
            int carry = 0;
            for(int i = len; i>=0; i--)
             {

                 int digit1 = int.Parse(big[i+dif].ToString());
                 int digit2 = int.Parse(smalll[i].ToString());
                 int add= carry+digit1+digit2;
                 sum.Append(add % 10);
                 carry = add/10;
             }
             if (big.Length != smalll.Length)
             {
                int len2 = dif-1;
                 if (carry != 0)
                 {
                     int add = carry + int.Parse(big[len2].ToString());
                     sum.Append(add);
                     for (int i = len2 - 1; i >=0; i--)
                     {
                         int val= int.Parse(big[i].ToString());
                         sum.Append(val);
                     }
                 }
                 else
                 {
                    for (int i = len2; i >= 0; i--)
                    {
                        int val = int.Parse(big[i].ToString());
                        sum.Append(val);
                    }
                }
             }
             for(int i = sum.Length-1; i >=0; i--)
             {
                 Console.Write("{0}", sum[i]);
             }

            Console.ReadLine();
        }
    }
}
