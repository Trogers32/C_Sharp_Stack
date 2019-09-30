using System;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Variable to interpolate
            string place = "Coding Dojo";
            //Interpolated string, note the $
            string message = $"Hello {place}"; ///f string
            // Displaying final message
            Console.WriteLine(message);
            Console.WriteLine("The value of pi is " + 3.14159);
            Console.WriteLine("My name is {0}, I am " + 28 + " years old", "Tim");
            Console.WriteLine($"My name is {0}, I am " + 28 + " years old", "Tim"); 
            string name = "Todd";
            int age = 32;
            double height = 1.875;
            bool blueEyed = true;
            Random rand = new Random();
            for(int val = 0; val < 10; val++){
                //Prints the next random value between 2 and 8
                Console.WriteLine(rand.Next(2,8));
            }
            for(int i = 1; i < 256; i++){
                Console.WriteLine(i);
            }
            for(int i = 1; i < 101; i++){
                if(i%3 == 0 && i%5 == 0){
                    Console.WriteLine("FizzBuzz");
                } else if(i%3 == 0){
                    Console.WriteLine("Fizz");
                } else if(i%5 == 0){
                    Console.WriteLine("Buzz");
                }
            }
        }
    }
}
