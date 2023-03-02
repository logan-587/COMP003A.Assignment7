#nullable disable
/* 
 * Author: Logan Smith
 * Course: COMP-003A
 * Purpose: Week 7 Assignment
 * 
 */

namespace COMP003A.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            //Character Counter Section using Arrays
            PrintSeparator("Array — Character Counter Section",'*');

            Console.Write("\nPlease enter a letter: ");
            char gimmieChar = Convert.ToChar(Console.ReadLine());
            Console.Write("Please enter a word: ");
            string gimmieString = Console.ReadLine();

            //yeah I know this is unfortunate but I kept getting very anti-cool error messages when I put the color changes in
            Console.Write("\nYour word, "); ChangeColor(gimmieString, 13); Console.Write(", has "); ChangeColor(gimmieChar, 10); Console.Write($" in it {CharacterCounter(gimmieChar, gimmieString)} time(s)!\n");




            /**************************/
            PrintSeparator("Array — Palindromic Section", '*');

            Console.Write("\nPlease enter a word: ");
            string gimmieWord = Console.ReadLine();
            Console.Write("Is "); ChangeColor(gimmieWord, 13); Console.Write(" a palindrome? ");
            IsPalindrome(gimmieWord);

        }


        /// <summary>
        /// Determines how many times a word has a certain letter in it
        /// </summary>
        /// <param name="characterInput">Character input</param>
        /// <param name="word">String input</param>
        /// <returns></returns>
        static int CharacterCounter(char characterInput, string word)
        {
            int counter = 0;
            for(int i = 0; i < word.Length; i++)
            {
                if (Char.Equals(Char.ToLower(word[i]), Char.ToLower(characterInput)))
                {
                    counter++;
                }
            }
            return counter;
        }



        static void IsPalindrome(string word)
        {
            string reversedWord = "";
            Console.WriteLine($"This is: {reversedWord}");
            Console.WriteLine($"This is: {word}");

            for(int i = (word.Length)-1; i == 0; i--)
            {
                reversedWord = reversedWord + Convert.ToString(word[i]);
                Console.WriteLine($"Here is: {reversedWord}");
                
            }

            if(String.Equals(word, reversedWord))
            {
                Console.Write("True");
            }
            else
            {
                Console.Write("False");
            }
        }








        /// <summary>
        /// Method to make titles easy
        /// </summary>
        /// <param name="message">String Input</param>
        /// <param name="x">Char Input</param>
        static void PrintSeparator(string message, char x)
        {
            Console.WriteLine("\n\n".PadRight(102, x));
            Console.WriteLine($"\t{message}");
            Console.WriteLine("".PadRight(100, x));
        }
        
        /************************************************************/
        //Methods for Color Changing Emphasis

        /// <summary>
        /// Changes color (within text!) for emphasis
        /// </summary>
        /// <param name="message">String input for emphasized message</param>
        /// <param name="color">Int input for color name (corresponds to MS Docs)</param>
        static void ChangeColor(string message, int color) 
        {
            switch (color)
            {
                case 13:
                    Console.Write($"{message}", Console.ForegroundColor = ConsoleColor.Magenta);
                    break;

                case 9:
                    Console.Write($"{message}", Console.ForegroundColor = ConsoleColor.Blue);
                    break;

                case 11:
                    Console.Write($"{message}", Console.ForegroundColor = ConsoleColor.Cyan);
                    break;

                case 10:
                    Console.Write($"{message}", Console.ForegroundColor = ConsoleColor.Green);
                    break;

                case 14:
                    Console.Write($"{message}", Console.ForegroundColor = ConsoleColor.Yellow);
                    break;

                case 12:
                    Console.Write($"{message}", Console.ForegroundColor = ConsoleColor.Red);
                    break;

                default:
                    Console.Write($"{message}");
                    break;
            }
            Console.ForegroundColor = ConsoleColor.White;

        }

        /// <summary>
        /// method overload for ChangeColor in char cases
        /// </summary>
        /// <param name="message">char input</param>
        /// <param name="color">Int input for color name (corresponds to MS Docs)</param>
        static void ChangeColor(char message, int color)
        {
            ChangeColor(Convert.ToString(message), color);
        }

        /// <summary>
        /// method overload for ChangeColor in int cases
        /// </summary>
        /// <param name="message">Int input for color name (corresponds to MS Docs)</param>
        /// <param name="color"></param>
        static void ChangeColor(int message, int color)
        {
            ChangeColor(Convert.ToString(message), color);
        }


        /************************************************************/



    }
}