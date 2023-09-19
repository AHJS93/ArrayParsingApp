using System.Text.RegularExpressions; 

namespace ArrayParsingApp 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            string loopAgain = string.Empty; /*Storing the do while loop condition*/

            /****************************************************
             * Initialize do while loop which contains our code
             ****************************************************/
            do
            {
                /******************************************************
                 * Gathering user input string and delimiter value
                 ******************************************************/
                Console.WriteLine("----------------"); 
                Console.WriteLine("Enter string to parse: "); 
                string inputString = Console.ReadLine(); 
                Console.WriteLine("Enter delimiter value: "); 
                string delimitVal = Console.ReadLine(); 

                /*********************************************
                 * Implementing the use of Regular Expressions
                 * to split the string at the delimiter value
                 * and to further replace non-numeric characters
                 * with empty characters
                 *********************************************/
                string[] delimitedString = Regex.Split(inputString, delimitVal); 

                string newString = Regex.Replace(inputString, @"[^0-9,]", ""); 

                /******************************************
                 * Printing the output string and then
                 * asking the user if they would like to
                 * parse another string and updating the
                 * loop condition variable
                 ******************************************/
                Console.WriteLine(newString); 
                Console.WriteLine("-------------------"); 
                Console.WriteLine("Parse again?: [Y/y]"); 
                Console.WriteLine("-------------------"); 
                loopAgain = Console.ReadLine().ToUpper(); 

            } while (loopAgain == "Y"); 
        }
    }
}