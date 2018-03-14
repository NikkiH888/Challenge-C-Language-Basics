using System;


namespace Basics
{
    class Program
    {
        // Declare the following constants and variables and set their initial values as indicated.
        public const byte sample1 = 0x3a;
        public const byte sample2 = 58;
        public static int heartRate = 85;
        public static double deposits = 135002796;
        public const float acceleration = 9.800f;
        public static float mass = 14.6f;
        public static double distance = 129.763001;
        public static bool lost = true;
        public static bool expensive = true;
        public static int choice = 2;
        public const char integral = '\u222B';
        public const string greeting = "Hello";
        public static string name = "Karen";


        public static void Main(string[] args)
        {
            /*
             * Using the constants and variables declared and initialized based on the above, do the following. 
             * Where is says “display” it means output a line to standard out. Each displayed item is to be on 
             * a separate line. Note that Kotlin has print and println.
             */

            if (sample1 == sample2)
            {
                Console.WriteLine("The samples are equal.");
            }
          

            if (heartRate >= 40 && heartRate <= 80)
            {
                Console.WriteLine("Heart rate is normal.");
            }
            else
            {
                Console.WriteLine("Heart rate is not normal.");
            }


            if (deposits >= 100000000)
            {
                Console.WriteLine("You are exceedingly wealthy.");
            }
            else
            {
                Console.WriteLine("Sorry you are so poor.");
            }


            float force = mass * acceleration;
            Console.WriteLine("force = " + force);
            Console.WriteLine(distance + " is the distance.");


            if (lost == true && expensive == true)
            {
                Console.WriteLine("I am really sorry! I will get the manager.");
            }
            else if (lost == true && expensive == false)
            {
                Console.WriteLine("Here is coupon for 10% off.");
            }

            // Use switch/case and the variable choice to display
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You chose 1.");
                    break;
                case 2:
                    Console.WriteLine("You chose 2");
                    break;
                case 3:
                    Console.WriteLine("You chose 3");
                    break;
                default:
                    Console.WriteLine("You made an unknown choice.");
                    break;
            }
            Console.WriteLine(integral + " is an integral");


            for (int i = 5; i <= 10; i++)
            {
                Console.WriteLine("i = " + i);
            }

            int age = 0;
            while (age < 6)
            {
                Console.WriteLine("age = " + age);
                age++;
            }

            Console.WriteLine(greeting + " " + name);
        }
    }
}
