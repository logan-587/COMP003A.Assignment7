#nullable disable
/* 
 * Author: Logan Smith
 * Course: COMP-003A
 * Purpose: Week 7 Assignment
 * 
 */

using System;

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


            /**************************/
            PrintSeparator("List — Add Section",'*');
            List<string> theList = ListAdd("name");
            
            PrintSeparator("List — Traversal Section", '*');
            ListTraversal(theList, true);
            ListTraversal(theList,false);


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


        /// <summary>
        /// Method to test if something is a palindrome
        /// </summary>
        /// <param name="word">String Input</param>
        ///<returns></returns>
        static void IsPalindrome(string word)
        {
            string reversedWord = "";

            for(int i = (word.Length)-1; i >= 0; i--)
            {
                reversedWord = reversedWord + word[i];
                
            }
            

            if(String.Equals(word.ToLower(), reversedWord.ToLower()))
            {
                Console.Write("True!\n");
            }
            else
            {
                Console.Write("False!\n");
            }
        }


        ///<summary>Method to Add List Items</summary>
        ///<param name="label">String input for what the list is (singular)</param>
        ///<returns>List</returns>
        static List<string> ListAdd(string label)
        {
            char exitGuy = 'a';
            List<string> namesList = new List<string>();

            do
            {
                Console.Write($"\nEnter a {label}: ");
                string userInput = Console.ReadLine();

                namesList.Add(userInput);

                Console.Write("Press (e) to escape, press any key to add more: ");
                exitGuy = Convert.ToChar(Console.ReadLine());

            } while(!Char.Equals(exitGuy,'e'));

            return namesList;
        }


        ///<summary>
        ///Prints a list in its input order or its reverse
        ///</summary>
        ///<param name="names">Input list</param>
        ///<param name="forwards">Boolean input, true to iterate forwards</param>
        static void ListTraversal(List<string> names, bool forwards)
        {
            string phrase = "";
            if(!forwards)
            {
                names.Reverse();
                phrase = "backwards";
            }
            else
            {
                phrase = "forwards";
            }

            Console.WriteLine($"\nHere's your list {phrase}!");

            foreach(var item in names)
            {
                Console.WriteLine(item);
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