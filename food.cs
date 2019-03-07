using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication110
{
    class Program
    {
        static int price()
        {
            int price;
            Console.WriteLine("\nENTER THE PRICE");
            price = int.Parse(Console.ReadLine());
            return price;
        }
        static int no()
        {
            int no;
            Console.WriteLine("\nenter total (no/plates) of (drinks/food) you want" );
            no = int.Parse(Console.ReadLine());
            return no;
        }
        static void Main(string[] args)
        {
            
            char choice;
            int total;
            int items;
            total = 0;
            int ftotal;
            ftotal = 0;
            int flavor;
            do
            {
                Console.WriteLine("WHAT'S YOUR ORDER??" + "\n 1.DRINKS \n 2.FOOD");
                items = int.Parse(Console.ReadLine());
                int drink;
                int food;
                int p;
                switch (items)
                {
                    case 1:
                        Console.WriteLine("\nWHAT DO YOU WANNA DRINK??" + "\n 1.Soft drink \n 2.Hard drink");
                        drink = int.Parse(Console.ReadLine());
                        if (drink == 1)
                        {
                            Console.WriteLine("\n WHICH DO YOU PREFER?" + "\n 1.COKE \n 2.FANTA \n 3.SPRITE");
                            p = int.Parse(Console.ReadLine());
                            total = total + (no() * price());
                        }
                        else if (drink == 2)
                        {
                            Console.WriteLine("\n WHICH DO YOU PREFER?"+"\n 1.BEER \n 2.VODKA \n 3.RUM");
                            p = int.Parse(Console.ReadLine());
                            total = total + (no() * price());
                        }
                        else
                        {
                            Console.WriteLine("sorry");
                        }
                        break;

                    case 2:
                        Console.WriteLine("WHAT DO YOU WANNA EAT" + "\n 1.MOMO \n 2.CHOUMIN \n 3.FRENCHFRIES");
                        food = int.Parse(Console.ReadLine());
                        
                        if (food == 1)
                        {
                            Console.WriteLine("\n WHAT FLAVOR YOU WANT TO EAT" + "\n 1.BUFF \n 2.VEG \n 3.MUTTON");
                            flavor = int.Parse(Console.ReadLine());
                            ftotal = ftotal + (no() * price());
                        }
                        else if (food == 2)
                        {
                            Console.WriteLine("\n WHAT FLAVOR YOU WANT TO EAT" + "\n 1.BUFF \n 2.VEG \n 3.MUTTON");
                            flavor = int.Parse(Console.ReadLine());
                            ftotal = ftotal + (no() * price());
                        }
                        else if (food == 3)
                        {
                            ftotal = ftotal + (no() * price());
                        }
                        else
                        {
                            Console.WriteLine("sorry");
                        }
                        break;
                }
                Console.WriteLine("\n ENTER capital Y IF YOU WANT TO START AGAIN \n ENTER N TO EXIT");
                choice = char.Parse(Console.ReadLine());

            }
            while (choice == 'Y');
            int sum;
            sum = total + ftotal;
            Console.WriteLine("\n YOU NEED TO PAY RS "+sum);
            Console.ReadKey();

        }
    }
}
