using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial.DataTypes
{
    internal class CharString
    {
        public CharString()
        {
            int charSize = sizeof(char);

            char letter = 'A';
            char symbol = '$';
            char digit = '1';

            Console.WriteLine("Size of char:- {0}", charSize);

            Console.WriteLine("Character letter: {0}", letter);
            Console.WriteLine("Character symbol: {0}", symbol);
            Console.WriteLine("Character digit: {0}", digit);

            Console.WriteLine("Min char value (as integer): {0}", (int)char.MinValue);
            Console.WriteLine("Max char value (as integer): {0}", (int)char.MaxValue);
            Console.WriteLine("Min char value: {0}", char.MinValue);
            Console.WriteLine("Max char value: {0}", char.MaxValue);

            int letterUnicode = (int)letter;
            int symbolUnicode = (int)symbol;
            int digitUnicode = (int)digit;

            char letter0 = '0';
            char letter1 = '1';
            char letter2 = '2';
            char letter3 = '3';
            char letter4 = '4';
            char letter5 = '5';
            char letter6 = '6';
            char letter7 = '7';
            char letter8 = '8';
            char letter9 = '9';

            int letter0Unicode = (int)letter0;
            int letter1Unicode = (int)letter1;
            int letter2Unicode = (int)letter2;
            int letter3Unicode = (int)letter3;
            int letter4Unicode = (int)letter4;
            int letter5Unicode = (int)letter5;
            int letter6Unicode = (int)letter6;
            int letter7Unicode = (int)letter7;
            int letter8Unicode = (int)letter8;
            int letter9Unicode = (int)letter9;


            char letterA = 'a';
            char letterB = 'b';
            char letterC = 'c';
            char letterD = 'd';
            char letterE = 'e';

            int letterAUnicode = (int)letterA;
            int letterBUnicode = (int)letterB;
            int letterCUnicode = (int)letterC;
            int letterDUnicode = (int)letterD;
            int letterEUnicode = (int)letterE;

            for (int i = 0; i <= 127; i++)
            {
                char character = (char)i;
                Console.WriteLine("Unicode: {0} Character: {1}", i, character);
            }

            string word = "Akram Pasha H";
            Console.WriteLine("Word: {0}", word);
            Console.WriteLine("Length of word: {0}", word.Length);
            Console.WriteLine("Size of word in bytes: {0}", word.Length * charSize);

            string sentence = "C# programming is fun!";
            Console.WriteLine("\nSentence: {0}", sentence);
            Console.WriteLine("Length of sentence: {0}", sentence.Length);
            Console.WriteLine("Size of sentence in bytes: {0}", sentence.Length * charSize);

            string paragraph = @"This is a paragraph.
It spans multiple lines.
Each line is part of the same string.";

            Console.WriteLine("\nParagraph:\n{0}", paragraph);
            Console.WriteLine("Length of paragraph: {0}", paragraph.Length);
            Console.WriteLine("Size of paragraph in bytes: {0}", paragraph.Length * charSize);

            int lineCount = paragraph.Split('\n').Length;
            Console.WriteLine("Number of lines in paragraph: {0}", lineCount);

        }
    }
}
