using System;

namespace Input
{
    
    class Program
    {
        
        static void Main(string[] args){

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("Your age is: " + age);

        }

    }

}