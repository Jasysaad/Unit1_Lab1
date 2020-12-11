using System;

namespace Lab1_1207
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Create a password.");
            string password = Console.ReadLine();
            Console.WriteLine(password.Length);

            int upper = 0; //initialize counters, could do this in loop
            int lower = 0;
            int excla = 0;
            if (6 < password.Length && password.Length < 13) {
                foreach (char chr in password) //runs each nested if for the entire string
                {
                    if (char.IsUpper(chr))
                    {
                        upper++;
                    }
                    if (char.IsLower(chr))
                    {
                        lower++;
                    }
                    if (chr == '!')
                    {
                        excla++;
                    }
                }
                if (upper >0 && lower>0 && excla >0) //checks that at least one uppercase, lowercase and !
                {
                    Console.WriteLine("Password valid and accepted");
                }
                else
                {
                    Console.WriteLine("Error"); //this error is triggered by not meeting all character requirements
                }
            }
            else
            {
                Console.WriteLine("Error"); //this error is triggered by password being incorrect length
            }
        }
        }
    }
