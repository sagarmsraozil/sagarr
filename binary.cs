using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication89
{
    class Program
    {
        static int binary(int[] num, int r)
        {
            int max;
            int mid;
            int min;
            max = num.Length;
            min = 0;
            int i;
            i = -1;
            while(max>=min)
            {
                mid = (min + max) / 2;
                if(num[mid]==r)
                {
                    return mid;
                }
                if(num[mid]>r)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return i;
        }
        static void Main(string[] args)
        {
            int[] num = new int[5];
            int select;
            Console.WriteLine("enter a number which you want to search");
            select = int.Parse(Console.ReadLine());
            int count;
            count = 0;
            Console.WriteLine("enter the total stored numbers in ascending order");
            while(count<num.Length)
            {
                num[count] = int.Parse(Console.ReadLine());
                count++;

            }
            binary(num, select);
            Console.WriteLine();
            Console.WriteLine("The number is stored in "+binary(num,select)+" "+"th terms");
            Console.ReadLine();

        }
    }
}
