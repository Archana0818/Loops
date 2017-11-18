/* created by Archana lohani 
 * to understand loops, switch and if else statements 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3ArchanalohaniP1
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            option = 0;
            do
            {
                Menu:
                Console.WriteLine("Welcome to the Menu");
                Console.WriteLine("Chose from the following option :");
                Console.WriteLine("\t1 : to display sequence of" +
                    "even numbers");
                Console.WriteLine("\t2 : to display perfect square");
                Console.WriteLine("\t3 : exit");

                option = int.Parse(Console.ReadLine());


                switch (option)
                {
                    case 1:
                        DisplayEven();
                        goto Menu;

                    case 2:

                        int number1;
                        int perfectSquare;
                        int choice;

                        number1 = 0;
                        perfectSquare = 0;
                        choice = 0;

            while (choice != 3)
             {
               Square:
               number1++;
               perfectSquare = number1 * number1;
               Console.WriteLine("Perfect square of {0} is"+
                "{1}", number1, perfectSquare);
                Console.WriteLine("Chose from the following option :");
                Console.WriteLine("\t1 : Continue");
                Console.WriteLine("\t2 : return to previous menu");
                            
                      choice = int.Parse(Console.ReadLine());

                            if (choice == 1)
                            {
                                goto Square;

                            }
                            else if (choice == 2)
                            {
                                goto Menu;
                            }
                           
                            else
                            {
                                Console.WriteLine("invalid entry");
                            }
                        }
                        break;


                    case 3:
                        Console.WriteLine("Bye bye");
                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        break;
                }


            } while (option != 3);

        }

        static int DisplayEven()
        {
            int number;
            int evenNumber;

            number = 0;
            evenNumber = 0;

            Console.WriteLine("This is the program to display even" +
                    " numbers starting from 0.");
            Console.WriteLine();
            Console.WriteLine("Enter the highest even number you" +
                " want to be displayed?(enter integer)");
            number = int.Parse(Console.ReadLine());


   for (evenNumber = 0; evenNumber <= number; evenNumber = evenNumber + 2)
            {
                Console.WriteLine(evenNumber);
            }
            return evenNumber;
        }
    }
}         
             
        
    





