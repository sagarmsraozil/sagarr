using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linearsearching
{
    class Program
    {
        static void bubble(int[]num)
        {
            int count;
            count = 0;
            int l;
            int swap;
            while(count<num.Length)
            {
                l = count + 1;
                while(l<num.Length)
                {
                    if(num[count]>num[l])
                    {
                        swap = num[count];
                        num[count] = num[l];
                        num[l] = swap;
                    }
                    l++;
                }
                Console.WriteLine();
                Console.Write("{0} ",num[count]);
                count++;
            }
            
        }

        static int binary(int[]num,int select)
        {
            int max;
            int min;
            int mid;
            max = num.Length;
            min = 0;
            while(max>=min)
            {
                mid = (max + min) / 2;
                if(num[mid]==select)
                {
                    return mid;
                }
                if(num[mid]>select)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("enter the size of array");
            size = int.Parse(Console.ReadLine());
            int[] num = new int[size];
            int count;
            count = 0;
            while(count<num.Length)
            {
                Console.WriteLine("enter the number for "+(count+1)+" "+"position");
                num[count] = int.Parse(Console.ReadLine());
                count++;
            }
            int searchitem;
            Console.WriteLine("enter the number you want to search");
            searchitem = int.Parse(Console.ReadLine());
            bubble(num);
            int y;
            y=binary(num, searchitem);
            if(y>=0)
            {
                Console.WriteLine();
                Console.WriteLine("The number lies in "+(y+1)+" "+"position");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("There is no search item in cointainer");
            }
            Console.ReadKey();
        }
    }
}
