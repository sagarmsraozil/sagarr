using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication88
{
    class Program
    {
        static void bubble(int[]a)
        {
            int count;
            count = 0;
            int y;
            int swap;
            while(count<a.Length)
            {
                y = count+1;
                while (y < a.Length)
                {
                    if (a[count] > a[y])
                    {
                        swap = a[count];
                        a[count] = a[y];
                        a[y] = swap;
                    }
                    
                    y++;
                }
                Console.Write("{0} ", a[count]);


                count++;
            }
            
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            int[] num = new int[8];
            int count;
            count = 0;
            Console.WriteLine("enter numbers");
            while(count<num.Length)
            {
                num[count] = int.Parse(Console.ReadLine());
                count++;
            }
            bubble(num);

        }
    }
}
