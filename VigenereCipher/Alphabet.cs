using System;
using System.Collections.Generic;
using System.Text;

namespace VigenereCipher
{
    class Alphabet
    {
        //Future me can add more languages and give the option to the user to pick the alphabet
        public static Dictionary<int, char> EnglishAlphabet()
        {
            Dictionary<int, char> alphabet = new Dictionary<int, char>();
            alphabet.Add(0, 'A');
            alphabet.Add(1, 'B');
            alphabet.Add(2, 'C');
            alphabet.Add(3, 'D');
            alphabet.Add(4, 'E');
            alphabet.Add(5, 'F');
            alphabet.Add(6, 'G');
            alphabet.Add(7, 'H');
            alphabet.Add(8, 'I');
            alphabet.Add(9, 'J');
            alphabet.Add(10, 'K');
            alphabet.Add(11, 'L');
            alphabet.Add(12, 'M');
            alphabet.Add(13, 'N');
            alphabet.Add(14, 'O');
            alphabet.Add(15, 'P');
            alphabet.Add(16, 'Q');
            alphabet.Add(17, 'R');
            alphabet.Add(18, 'S');
            alphabet.Add(19, 'T');
            alphabet.Add(20, 'U');
            alphabet.Add(21, 'V');
            alphabet.Add(22, 'W');
            alphabet.Add(23, 'X');
            alphabet.Add(24, 'Y');
            alphabet.Add(25, 'Z');
            return alphabet;
        }
    }
}
