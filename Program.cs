using System;
using System.Linq.Expressions;
namespace assignment3ism4300
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a integer between 1 and 100 to execute a loop: ");
            try
            {
                int intinput = int.Parse(Console.ReadLine());
                Console.WriteLine("Pick 1 for Odd or 2 for Even");
                int stringinput = int.Parse(Console.ReadLine());

                if (stringinput == 1)
                {
                    Console.WriteLine("You have selected Odd. The numbers between 0 and " + intinput.ToString() + " are");
                }
                else
                {
                    Console.WriteLine("You have selected Odd. The numbers between 0 and " + intinput.ToString() + " are");
                }


                for (int i = 0; i <= intinput; i++)
                {
                    if (stringinput == 2)
                    {
                        int even = 2 * i;
                        if (even > intinput)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine(even.ToString());
                        }
                    }
                    else
                    {

                        int odd = 2 * i;
                        int newodd = odd + 1;
                        if (odd > intinput - 1)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine(newodd.ToString());
                        }

                    }
                }
            }
            catch
            {
                Console.WriteLine("Please enter a integer value and try again");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);
            }
        }
    }
}