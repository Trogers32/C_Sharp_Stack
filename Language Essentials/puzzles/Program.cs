using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RandomArray();
            TossCoin();
            Console.WriteLine(TossMultipleCoins(10));
            foreach(string a in Names()){
                Console.WriteLine(a);
            }
        }

        // Random Array
        // Create a function called RandomArray() that returns an integer array
        // Place 10 random integer values between 5-25 into the array
        // Print the min and max values of the array
        // Print the sum of all the values
        public static int[] RandomArray(){
            Random rand = new Random();
            int[] ra = new int[10];
            for(int i = 0;i<ra.Length;i++){
                ra[i] = rand.Next(5,25);
            }
            int min = ra[0];
            int max = ra[0];
            int sum = 0;
            foreach(int a in ra){
                if(a < min){
                    min = a;
                }
                if(a>max){
                    max = a;
                }
                sum += a;
            }
            Console.WriteLine($"{min} {max} {sum}");
            return ra;
        }
        public static string TossCoin(){
            // Coin Flip
            // Create a function called TossCoin() that returns a string
            // Have the function print "Tossing a Coin!"
            // Randomize a coin toss with a result signaling either side of the coin 
            // Have the function print either "Heads" or "Tails"
            // Finally, return the result
            Console.WriteLine("Tossing a Coin!");
            Random rand = new Random();
            int test = rand.Next(0,2);
            if(test == 1){
                Console.WriteLine("Heads");
                return "Heads";
            } else {
                Console.WriteLine("Tails");
                return "Tails";
            }
        }
        public static Double TossMultipleCoins(int num){
            // Create another function called TossMultipleCoins(int num) that returns a Double
            // Have the function call the tossCoin function multiple times based on num value
            // Have the function return a Double that reflects the ratio of head toss to total toss
            List<string> ratio = new List<string>();
            int count = 0;
            for(int i = 0; i<num;i++){
                ratio.Add(TossCoin());
            }
            foreach(string a in ratio){
                if(a =="Heads"){
                    count++;
                }
            }
                Console.WriteLine(count);
            Double c = ((double)count/(double)num);
            return c;
        }
        public static List<string> Names(){
            // Names
            // Build a function Names that returns a list of strings.  In this function:
            // Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
            // Shuffle the list and print the values in the new order
            // Return a list that only includes names longer than 5 characters
            List<string> name = new List<string>();
            List<string> longNames = new List<string>();
            Random rand = new Random();
            name.Add("Todd");
            name.Add("Tiffany");
            name.Add("Charlie");
            name.Add("Geneva");
            name.Add("Sydney");
            int n = name.Count;
            while(n>1){
                n--;
                int k = rand.Next(n+1);
                string value = name[k];
                name[k] = name[n];
                name[n] = value;
            }
            foreach(string a in name){
                Console.WriteLine(a);
                if(a.Length>5){
                    longNames.Add(a);
                }
            }
            return longNames;
        }
    }
}
