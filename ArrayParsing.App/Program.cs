using System.Text.RegularExpressions; /*Declaring use of Regular Expressions to match characters in the inputString*/

namespace ArrayParsingApp /*Declaring the namespace*/
{
    class Program /*Declaring the class*/
    {
        static void Main(string[] args) /*setting the entry point*/
        {
            string loopAgain = null; /*declaring a variable to hold the user's decision to repeat the loop and setting = to null for now*/

            do /*Initializing do-while loop*/
            {
                Console.WriteLine("----------------"); /*clear line separation for user*/
                Console.WriteLine("Enter string to parse: "); /*Asking the user to input their string for parsing*/
                string inputString = Console.ReadLine(); /*storing the users input into an object called inputString*/
                Console.WriteLine("Enter delimiter value: "); /*Asking the user to input their delimiter value*/
                string delimitVal = Console.ReadLine(); /*Storing the users delimiter value in the object delimitVal*/

                string[] delimitedString = Regex.Split(inputString, delimitVal); /*creating an array of substrings which constists of the values created when using the Regex Split method to split the inputString text at each delimiter value that the user has chosen*/

                string newString = Regex.Replace(inputString, @"[^0-9,]", ""); /*creating a new string which uses the Regex Replace method to take the inputString and replace all non-numeric characters with "" no character and preserves the numeric values 0-9 as well as the comma , */

                Console.WriteLine(newString); /*displaying the newString*/
                Console.WriteLine("-------------------"); /*line separation for user*/
                Console.WriteLine("Parse again?: [Y/y]"); /*Asking the user if they would like to parse again*/
                Console.WriteLine("-------------------"); /*line separation for user*/
                loopAgain = Console.ReadLine().ToUpper(); /*setting the loopAgain string = to the users input, converted to uppercase to decrease error, on ln25*/

            } while (loopAgain == "Y"); /*closing the do-while loop to continue if the loopAgain string is == to "Y"*/
        }
    }
}