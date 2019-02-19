using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication87
{
    class Program
    {
        static int price()
        {
            int price;
            Console.WriteLine("enter the price of selected item");
            price = int.Parse(Console.ReadLine());
            return price;
        }
        static int no()
        {
            int jl;
            Console.WriteLine("enter total no of items clients have asked");
            jl = int.Parse(Console.ReadLine());
            return jl;
        }
        static void Main(string[] args)
        {
            char choice;
           
            int num;
            int total;
            int cv;
            cv = 0;
            total = 0;
            int ui;

            do
            {
                Console.WriteLine("enter nums for \n 1.Drinks \n 2.Food");
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        int a;
                        Console.WriteLine("enter the choice \n 1. soft drink \n 2. hard drink");
                        a = int.Parse(Console.ReadLine());
                        if (a == 1)
                        {
                            total = total + (price() * no());

                        }
                        else if (a == 2)
                        {
                            total = total + (price() * no());
                        }
                        else
                        {
                            Console.WriteLine("sorry");
                        }
                        break;

                    case 2:
                        int r;
                        Console.WriteLine("enter the choice for \n 1. momo \n 2. burger \n 3. pizza \n 4. thukpa");
                        r = int.Parse(Console.ReadLine());
                        int p;
                        Console.WriteLine("enter the flavor \n 1. buff \n 2. chicken \n 3.pork \n 4. mutton");
                        p = int.Parse(Console.ReadLine());
                        if (r == 1)
                        {
                            cv = cv + (price() * no());
                        }
                        else if (r == 2)
                        {
                            cv = cv + (price() * no());
                        }
                        else if (r == 3)
                        {
                            cv = cv + (price() * no());
                        }
                        else if (r == 4)
                        {
                            cv = cv + (price() * no());
                        }
                        else
                        {
                            Console.WriteLine("sorry");
                        }
                        break;





                }
                Console.WriteLine("enter capital Y for again");
                choice = char.Parse(Console.ReadLine());
            }
            while (choice == 'Y');
            ui = total + cv;
            Console.WriteLine("\n Your bill amount is RS "+ui);
            Console.ReadKey();
            

        }
    }
}
