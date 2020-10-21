using System;
using System.Reflection.Metadata.Ecma335;

namespace IDCodeReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your ID code: ");
            string usersID = Console.ReadLine();

            if (Validate(usersID))
            {
                Console.WriteLine("welcome!");
                HelloUser(usersID);
                GetAge(usersID);
            }
            else
            {
                Console.WriteLine("wrong format. try again.");
            }
            
        }

        public static bool Validate(string idCode)
        {
            if (idCode.Length == 11)
            {
                try
                {
                    long.Parse(idCode);
                    return true;
                }
                catch(Exception e)
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
        public static void HelloUser(string idCode)
        {
            int firstNum = Int32.Parse(idCode[0].ToString());
            // || - alt gr + <>
            if(firstNum == 1|| firstNum == 3 || firstNum == 5)
            {
                Console.WriteLine("hello, sir!");
            }else if (firstNum == 2 || firstNum == 4 || firstNum == 6)
            {
                Console.WriteLine("hello, madam!");
            }
            
        }

        public static int GetYear(string idCode)
        {

            string yearFromCode = idCode.Substring(1, 2);
            string year;
            if (int.Parse(idCode[0].ToString()) > 4)
            {
                year = "20" + yearFromCode;
            }
            else
            {
                year = "19" + yearFromCode;
            }
            Console.WriteLine($"You were born in {year}");
            int yearParsed = Int32.Parse(year);
            return yearParsed;
        }
        public static void GetAge(string idCode)
        {
            int yearOfBirth = GetYear(idCode);
            DateTime now = DateTime.Now;
            int yearNow = Int32.Parse(now.Year.ToString());
            int age = yearNow - yearOfBirth;
            Console.WriteLine($"You are {age} years old");
        }
    }
}
