using System;

namespace CVVValitation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your CVV code: ");
            string usersID = Console.ReadLine();

            if (Validate(usersID))
            {
                Console.WriteLine("welcome!");
                Validate(usersID);
            }
            else
            {
                Console.WriteLine("wrong format. try again.");
            }

            
        }

        public static bool Validate(string CVVCode)
        {
            if (CVVCode.Length == 3)
            {
                try
                {
                    long.Parse(CVVCode);
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"wrong formar: {e}");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
