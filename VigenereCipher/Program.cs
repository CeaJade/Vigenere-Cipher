using System;
using System.Threading;

namespace VigenereCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loads of weird code that makes the application a bit more fancy
            while (true)
            {
                int input;
                bool valid;
                do
                {
                    //Get an input that decides where the user wants to go
                    Console.WriteLine("|| VIGENERE CIPHER ||");
                    Console.Write("1. Encrypt \n2. Decrypt \n3. EXIT \nInput: ");
                    if (!int.TryParse(Console.ReadLine(), out input) || input > 3 || input <= 0)
                    {
                        Console.WriteLine("Invalid input \nplease try again");
                        Console.ReadKey();
                        Console.Clear();
                        valid = false;
                    }
                    else
                        valid = true;
                } while (!valid);
                
                //Takes the input and gets the correct menu
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        Encrypt();
                        break;
                    case 2:
                        Console.Clear();
                        Decrypt();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("ERROR...");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        //User gives message and key and the message will be encrypted
        public static void Encrypt()
        {
            Console.WriteLine("Your Message: ");
            string message = Console.ReadLine();
            Console.WriteLine("Your Key: ");
            string key = Console.ReadLine();
            string encryption = VigenereCipher.Encrypt(message, key);
            for (int i = 0; i <= 100; i++)
            {
                Console.Write($"\rEncrypting: {i}%   ");
                Thread.Sleep(25);
            }
            Thread.Sleep(1000);
            Console.WriteLine("\rEncrypted message: " + encryption);
        }

        //User gives message and key and the message will be decrypted
        public static void Decrypt()
        {
            Console.WriteLine("Your Message: ");
            string message = Console.ReadLine();
            Console.WriteLine("Your Key: ");
            string key = Console.ReadLine();

            string decryption = VigenereCipher.Decrypt(message, key);
            for (int i = 0; i <= 100; i++)
            {
                Console.Write($"\rDecrypting: {i}%   ");
                Thread.Sleep(25);
            }
            Thread.Sleep(1000);
            Console.WriteLine("\rDecrypted message: " + decryption);
        }
    }
}
