using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();
            for (; ;)
            {
                Greeting();
                Age();

                //Console.ReadLine();

                Settings();
            }

        }

        private static void ValueTypes()
        {
            //    int maxInt = int.MaxValue;
            //    int minInt = int.MinValue;
            //    long maxLong = long.MaxValue;
            //    long minLong = long.MinValue;

            //    Console.WriteLine("maxInt = " + maxInt);
            //    Console.WriteLine("minInt = " + minInt);
            //    Console.WriteLine("maxLong = " + maxLong);
            //    Console.WriteLine("minLong =" + minLong);
            //}

            /// <summary>
            /// Ustawienia.
            /// </summary>
        }

        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        /// <summary>
        /// Otrzymujemy komunikat zależny od wieku.
        /// </summary>
        private static void Age()
        {
            Console.Write("Wpisz ile masz lat: ");

            int age;
            var result = int.TryParse(Console.ReadLine(), out age);

            if (result == true)
            {

                if (age >= 18)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Brawo! Jesteś pełnoletni, możesz wypić Browara!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Możemy zaoferować Ci mleko");
                }
            }
            else
            {
                Console.WriteLine("Miałe(a)ś podać liczbę, do cholery! :)");
            }
        }

        /// <summary>
        /// Witamy użytkownika.
        /// </summary>
        private static void Greeting()
        {
            Console.Write("Wpisz swoje imię: ");
            string name = Console.ReadLine();


            Console.WriteLine("Witaj " + name);
        }
    }
}
