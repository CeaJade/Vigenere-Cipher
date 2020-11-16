using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VigenereCipher
{
    class VigenereCipher
    {
        //Decrypts the message using the key
        public static string Decrypt(string message, string key)
        {
            message = message.ToUpper();
            key = key.ToUpper();

            string ciphertext = "";

            int i = 0;

            foreach (char element in message)
            {
                if (!Char.IsLetter(element)) 
                    ciphertext += "";
                
                else
                {
                    int MOrder = Alphabet.EnglishAlphabet().FirstOrDefault(x => x.Value == element).Key;
                    int KOrder = Alphabet.EnglishAlphabet().FirstOrDefault(x => x.Value == key[i]).Key;
                    int Final = (int)(MOrder + KOrder);
                    if (Final > 25) { Final -= 26; }
                    ciphertext += Alphabet.EnglishAlphabet()[Final];
                    i++;
                }
                
                if (i == key.Length)  
                    i = 0; 
            } return ciphertext;
        }

        //Encrypts the message using the key
        public static string Encrypt(string message, string key)
        {
            message = message.ToUpper();
            key = key.ToUpper();

            string plaintext = "";

            int i = 0;

            foreach (char element in message)
            {
                if (!Char.IsLetter(element))
                    plaintext += "";

                else 
                {
                    int MOrder = Alphabet.EnglishAlphabet().FirstOrDefault(x => x.Value == element).Key; 
                    int KOrder = Alphabet.EnglishAlphabet().FirstOrDefault(x => x.Value == key[i]).Key;
                    int Final = (int)(MOrder - KOrder);
                    if (Final < 0) { Final += 26; }
                    plaintext += Alphabet.EnglishAlphabet()[Final];
                    i++;
                }

                if (i == key.Length) 
                    i = 0;
            } return plaintext;
        }
    }
}
