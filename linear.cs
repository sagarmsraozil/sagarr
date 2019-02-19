using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication90
{
    class Program
    {
        static int[] call(int a)
        {
            int[] num = new int[a];
            int count;
            count = 0;
            while(count<num.Length)
            {
                Console.WriteLine("enter number for "+count+":");
                num[count] = int.Parse(Console.ReadLine());
                
                count++;

            }
            return num;
        }
        static int lsearch(int[]t, int y)
        {
            int count;
            count = 0;
            int i;
            i = -1;
            while(count<t.Length)
            {
                if(t[count]==y)
                {
                    return count;
                }
                count++;
            }
            return i;
        }
        static void Main(string[] args)
        {
            int size;
            int select;
            Console.WriteLine("enter the size of array");
            size = int.Parse(Console.ReadLine());
            int[] ans = call(size);
            Console.WriteLine("enter number to select");
            select = int.Parse(Console.ReadLine());
            int r;
            r = lsearch(ans, select);
            if(r>=0)
            {
                Console.WriteLine("the number lies in "+(r+1)+" "+"position");
            }
            else
            {
                Console.WriteLine("there is no such number");
            }
            Console.ReadKey();
        }
    }
}
