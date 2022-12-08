using System.Collections.Generic;
using Scrabble.Program;
using System;

namespace Scrabble.Models
{
    public class ScrabbleScores
    {
        public string Word { get; set; }
        public ScrabbleScores(string word)
        {
            Word = word;
        }

        public int getPoints()
        {
            char[] userWord = Word.ToCharArray();
            int score = 0;

            for (int i = 0; i < userWord.Length; i++)
            {
                Console.WriteLine(userWord[i]);
                if (userWord[i] == 'a' || userWord[i] == 'e' || userWord[i] == 'i' || userWord[i] == 'o' || userWord[i] == 'u' || userWord[i] == 'l' || userWord[i] == 'n' || userWord[i] == 'r' || userWord[i] == 's' || userWord[i] == 't')
                {
                    score += 1;
                }
                else if (userWord[i] == 'd' || userWord[i] == 'g')
                {
                    score += 2;
                }
                else if (userWord[i] == 'b' || userWord[i] == 'c' || userWord[i] == 'm' || userWord[i] == 'p')
                {
                    score += 3;
                }
                else if (userWord[i] == 'f' || userWord[i] == 'h' || userWord[i] == 'v' || userWord[i] == 'w' || userWord[i] == 'y')
                {
                    score += 4;
                }
                else if (userWord[i] == 'k')
                {
                    score += 5;
                }
                else if (userWord[i] == 'j' || userWord[i] == 'x')
                {
                    score += 8;
                }
                else if (userWord[i] == 'q' || userWord[i] == 'z')
                {
                    score += 10;
                }
                else
                {
                    return score;
                }
            }

            return score;

        }
    }
}