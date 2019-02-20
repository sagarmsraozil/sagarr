using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication99
{
    class Program
    {
        class twelve
        {
            public string name;
            public int roll_no;
            public string section;

          

            public void printbase()
            {
                Console.WriteLine("Name "+name);
                Console.WriteLine("Roll_no "+roll_no);
                Console.WriteLine("Section "+section);
            } 
        }
        class result : twelve
        {

            public string[] subjects = new string[4] { "1.sdt", "2.sfc", "3.ddw", "4.cs" };
            public int[] marks = new int[4];

            

            public void printing()
            {
                int count;
                count = 0;
                while(count<subjects.Length)
                {
                    Console.WriteLine(subjects[count]);
                    count++;
                }
                count = 0;
                while(count<subjects.Length)
                {
                    
                    Console.WriteLine("enter the marks for the given subject "+(count+1));
                    marks[count] = int.Parse(Console.ReadLine());
                    count++;
                }
              
                count = 0;
                int total;
                total = 0;
                int percentage;
                while(count<marks.Length)
                {
                    total = total + marks[count];
                    count++;
                }
                percentage = total / 4;
                Console.WriteLine("\n Student got "+percentage+"%");
            }
        }

  


        static void Main(string[] args)
        {
            result absek = new result();
            absek.name = "absek";
            absek.roll_no = 14;
            absek.section = "A";
            absek.printbase();
            absek.printing();

            Console.WriteLine();
            Console.WriteLine();

            result asis = new result();
            asis.name = "asis";
            asis.roll_no = 1;
            asis.section = "A";
            asis.printbase();
            asis.printing();

            Console.ReadKey();
        }
    }
}
