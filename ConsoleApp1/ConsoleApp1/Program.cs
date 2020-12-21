using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string character = "Ahmad";
            int age = 15;
            string superpower1 = "steel armor";
            string superpower2 = "night vision";
            double speed = 1.65;
            Console.WriteLine("My name is {0}, my super powers are {1} and {2}, my age is {3} and my speed is {4}.", character, superpower1, superpower2, age, speed);
            //second task
            string heroName = "John";
            string heroHeight = "193cm";
            int heroAge = 22;
            string heroSuperPower1 = "strong punch";
            string heroSuperPower2 = "high jumps";
            int ageDifference = heroAge - age;
            Console.WriteLine("the age difference is : {0}", ageDifference);
        }
    }
}
