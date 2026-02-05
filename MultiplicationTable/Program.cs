
namespace MultiplicationTable
//Cambria Morgan
//Spring 2026
//RCET 2265
//MultiplicationTable
//https://github.com/cambriajm/MultiplicationTable.git 

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
                        
            {
            Console.WriteLine($"Welcome to the multiplication table," +
                "\nenter the number you wish to see the times table for. " +
                "\nThis will default to a 12x12 table if " +
                "\nenter or any letter is pressed.");
            
                userInput = Console.ReadLine();
                
                if(userInput != null) //if input is null, it defaults to the catch,
                                      //sending it to the default of the 12x12
                {
                    try// if integer is entered then this runs array with user input
                    {
                        int result = int.Parse(userInput);

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
                    }
                    catch(Exception) //here is where the null user input gets sent to show the 
                                     //default 12x12 table
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
 