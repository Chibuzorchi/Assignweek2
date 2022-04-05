using System;

namespace Week2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables and Data types
            
            int myAge = 27;
            string myName = "Chinonso";
            long myNumber = 8093639845;
            double dollarToNaira = 570.37;
            float entryCode = 10.2f;
            bool chooseValue = true;
            char charTra = 'A';
            decimal height = 1000.15m;
            ulong serialNumber = 3456766889765444ul;
            uint examNumber = 100u;
            short queueNumber = 001;

            //Implicit Conversion

            float figMa = myAge;
            double glide = dollarToNaira;

            //Explicit Conversion

            int width = (int)height;

            

            Console.WriteLine(myAge);
            Console.WriteLine(myName);
            Console.WriteLine(myNumber);
            Console.WriteLine(dollarToNaira);
            Console.WriteLine(chooseValue);
            Console.WriteLine(charTra);
            Console.WriteLine(height);
            Console.WriteLine(serialNumber);
            Console.WriteLine(examNumber);
            Console.WriteLine(entryCode);
            Console.WriteLine(queueNumber);
            Console.WriteLine(figMa);
            Console.WriteLine(glide);
            Console.WriteLine(width);




        }
    }
}
