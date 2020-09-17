using System;

namespace passwordChecker
{
    class Program
    {
        static void Main(string[] args)
        {

            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstubwxyz";
            string digits = "0123456789";
            string specialChars = "!@#$%^&*(),.?";
            int score = 0;

            Console.WriteLine("please enter your password to determine it's strength");
            string pass = Console.ReadLine();
            Console.WriteLine($"your password is {pass}");

            if (pass.Length >= minLength)
            {
                ++score;
                Console.WriteLine($"you got a point for good password length, your score is {score}");
            }
            else
            {
                Console.WriteLine("your password length doodo");
            }

            if (Tools.Contains(pass, lowercase))
            {
                ++score;
                Console.WriteLine($"you got a point for good password casing, your score is {score}");
            }
            else
            {
                Console.WriteLine("your password casing doodo");
            }
            if (Tools.Contains(pass, digits))
            {
                ++score;
                Console.WriteLine($"you got a point for good password numbers, your score is {score}");
            }
            else
            {
                Console.WriteLine("your password numbers doodo");
            }
            if (Tools.Contains(pass, digits))
            {
                ++score;
                Console.WriteLine($"you got a point for good password numbers, your score is {score}");
            }
            else
            {
                Console.WriteLine("your password numbers doodo");
            } 
            if (Tools.Contains(pass, specialChars))
            {
                ++score;
                Console.WriteLine($"you got a point for good password characters, your score is {score}");
            }
            else
            {
                Console.WriteLine("your password characters doodo");
            }

            switch (score)
            {
                case 0:
                    Console.WriteLine("your scoree doodoo");
                    break; 
                case 1:
                    Console.WriteLine("your scoree kinda bad");
                    break; 
                case 2:
                    Console.WriteLine("your scoree aight, still weak af");
                    break;
                case 3:
                    Console.WriteLine("your scoree passes");
                    break; 
                case 4:
                    Console.WriteLine("your scoree pretty epic");
                    break;



                   
               
            }


        }
    }
}
