using System;
using Scrabble.Models;
using System.Collections.Generic;

namespace Scrabble.Program
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Scrabble!");
            Console.WriteLine("Enter a word to see its Scrabble Score!");
            string userInput = Console.ReadLine();
            ScrabbleScores newWord = new ScrabbleScores(userInput.ToLower());
            Console.WriteLine(newWord.getPoints());
        }
    }
}
