using System.Data.Common;
using System.Runtime.ExceptionServices;

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            
            
            {
            Console.WriteLine("Welcome to the multiplication table," +
                "enter the number you wish to see the times table for.");
            
                userInput = Console.ReadLine();
                

                if(userInput != null)
                {
                    try
                    {

                    for (int array = 0; array < 1; array++)
                    {

                        for (int row = 1; row < int.Parse(userInput) + 1; row++)
                        {
                            for
                                (int column = 1; column < int.Parse(userInput) + 1; column++)
                            {
                                Console.Write((row * column).ToString().PadLeft(4));
                            }
                            Console.WriteLine();
                        }
                    }
                        int result = int.Parse(userInput);

                    }
                    catch(Exception)
                    {
                        for (int array = 0; array < 1; array++)
                        {

                            for (int row = 1; row < 12 + 1; row++)
                            {
                                for
                                    (int column = 1; column < 12 + 1; column++)
                                {
                                    Console.Write((row * column).ToString().PadLeft(4));
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                    }

                //pause 
                Console.Read();
                            
                    }
                }

            } 

        }
 