using System;

namespace LOGITpe20
{
    class Program
    {
        static void Main(string[] args)
        {
            /*write a function that takes in LOGITpe20 and displays the following output in the console:
            --> LOGIT
            --> pe
            --> 20
            public static void DisplayLOGIT("LOGITpe20")*/
            DisplayLOGIT();
        }
        public static void DisplayLOGIT()
        {
            string klass = "LOGITpe20";
            string first = klass.Substring(0, 5);
            string second = klass.Substring(5, 2);
            string theird = klass.Substring(7, 2);
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(theird);
        }
    }
}
