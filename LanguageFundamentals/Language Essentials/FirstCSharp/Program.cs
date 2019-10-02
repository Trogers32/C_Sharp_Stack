using System.Linq;
using System;
using System.Collections.Generic;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // // Variable to interpolate
            // string place = "Coding Dojo";
            // //Interpolated string, note the $
            // string message = $"Hello {place}"; ///f string
            // // Displaying final message
            // Console.WriteLine(message);
            // Console.WriteLine("The value of pi is " + 3.14159);
            // Console.WriteLine("My name is {0}, I am " + 28 + " years old", "Tim");
            // Console.WriteLine($"My name is {0}, I am " + 28 + " years old", "Tim"); 
            // string name = "Todd";
            // int age = 32;
            // double height = 1.875;
            // bool blueEyed = true;
            // Random rand = new Random();
            // // Declaring an array of length 5, initialized by default to all zeroes
            // int[] numArray = new int[5];
            // // Declaring an array with pre-populated values
            // // For Arrays initialized this way, the length is determined by the size of the given data
            // int[] numArray2 = {1,2,3,4,6};
            // int[] array3;
            // array3 = new int[] {1,3,5,7,9};
            // string[] myCars = new string[] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx"};
            // // The 'Length' property tells us how many values are in the Array (4 in our example here). 
            // // We can use this to determine where the loop ends: Length-1 is the index of the last value. 
            // for (int idx = 0; idx < myCars.Length; idx++)
            // {
            //     Console.WriteLine($"I own a {myCars[idx]}");
            // }
            // foreach (string car in myCars)
            // {
            //     // We no longer need the index, because variable 'car' already represents each indexed value
            //     Console.WriteLine($"I own a {car}");
            // }
            // for(int val = 0; val < 10; val++){
            //     //Prints the next random value between 2 and 8
            //     Console.WriteLine(rand.Next(2,8));
            // }
            // // for(int i = 1; i < 256; i++){
            // //     Console.WriteLine(i);
            // // }
            // // for(int i = 1; i < 101; i++){
            // //     if(i%3 == 0 && i%5 == 0){
            // //         Console.WriteLine("FizzBuzz");
            // //     } else if(i%3 == 0){
            // //         Console.WriteLine("Fizz");
            // //     } else if(i%5 == 0){
            // //         Console.WriteLine("Buzz");
            // //     }
            // // }
            // ////////////////lists
            // //Initializing an empty list of Motorcycle Manufacturers
            // List<string> bikes = new List<string>();
            // //Use the Add function in a similar fashion to push
            // bikes.Add("Kawasaki");
            // bikes.Add("Triumph");
            // bikes.Add("BMW");
            // bikes.Add("Moto Guzzi");
            // bikes.Add("Harley Davidson");
            // bikes.Add("Suzuki");
            // //Accessing a generic list value is the same as you would an array
            // Console.WriteLine(bikes[2]); //Prints "BMW"
            // Console.WriteLine($"We currently know of {bikes.Count} motorcycle manufacturers.");
            // //Using our array of motorcycle manufacturers from before
            // //we can easily loop through the list of them with a C-style for loop
            // //this time, however, Count is the attribute for a number of items.
            // Console.WriteLine("The current manufacturers we have seen are:");
            // for (var idx = 0; idx < bikes.Count; idx++)
            // {
            // Console.WriteLine("-" + bikes[idx]);
            // }
            // // Insert a new item between a specific index
            // bikes.Insert(2, "Yamaha");
            // //Removal from Generic List
            // //Remove is a lot like Javascript array pop, but searches for a specified value
            // //In this case we are removing all manufacturers located in Japan
            // bikes.Remove("Suzuki");
            // bikes.Remove("Yamaha");
            // bikes.RemoveAt(0); //RemoveAt has no return value however
            // //The updated list can then be iterated through using a foreach loop
            // Console.WriteLine("List of Non-Japanese Manufacturers:");
            // foreach (string manu in bikes)
            // {
            // Console.WriteLine("-" + manu);
            // }
            // Dictionary<string,string> profile = new Dictionary<string,string>();
            // //Almost all the methods that exists with Lists are the same with Dictionaries
            // profile.Add("Name", "Speros");
            // profile.Add("Language", "PHP");
            // profile.Add("Location", "Greece");
            // Console.WriteLine("Instructor Profile");
            // Console.WriteLine("Name - " + profile["Name"]);
            // Console.WriteLine("From - " + profile["Location"]);
            // Console.WriteLine("Favorite Language - " + profile["Language"]);
            // foreach (KeyValuePair<string,string> entry in profile)
            // {
            // Console.WriteLine(entry.Key + " - " + entry.Value);
            // }
            // //The var keyword takes the place of a type in type-inference
            // foreach (var entry in profile)
            // {
            // Console.WriteLine(entry.Key + " - " + entry.Value);
            // }
            int[] ar = {1,2,3,4,5,6,7,8};
            Console.WriteLine(Avg(ar));
            // ///////////////////////////////// Multidimensional array declaration////////////////////////////////////
            // // This example contains 3 arrays -- each of these is length 2 -- all initialized to zeroes.
            // int [,] array2D = new int[3,2];
            // // This is equivalent to:
            // //  int [,] array2D = new int[3,2]  {  { 0,0 }, { 0,0 }, { 0,0 } }; 
            // // This example has 2 large rows that each contain 3 arrays -- and each of those arrays is length 4.
            // int[,,] array3D = new int[2,3,4] 
            //     {
            //         {  { 45,1,16,17 }, { 4,47,21,68 }, { 21,28,32,76 }  },
            //         {  { 11,0,85,42 }, { 9,10,14,96 }, { 66,99,33,12 }  }
            //     };
            // // Directly accessing a multidimensional array
            // Console.WriteLine(array2D[0,1]);   // prints 0
            // Console.WriteLine(array3D[1,0,3]); // prints 42
            
            ///////////////////////////////// Jagged array declaration//////////////////////////////////
            // int[][] jaggedArray = new int[3][];
            // jaggedArray[0] = new int[5];
            // jaggedArray[1] = new int[4]; 
            // jaggedArray[2] = new int[2];
            // int[][] jaggedArray2 = new int[][] {
            //     new int[] {1,3,5,7,9},
            //     new int[] {0,2},
            //     new int[] {11,22,33,44}
            // };
            // // Short-hand form
            // int[][] jaggedArray3 = {
            //     new int[] {1,3,5,7,9},
            //     new int[] {0,2},
            //     new int[] {11,22,33,44}
            // };
            // // You can even mix jagged and multi-dimensional arrays
            // int[][,] jaggedArray4 = new int[3][,] 
            // {
            //     new int[,] { {1,3}, {5,7} },
            //     new int[,] { {0,2}, {4,6}, {8,10} },
            //     new int[,] { {11,22}, {99,88}, {0,9} } 
            // };
            // // Working through each array in a jagged array
            // foreach(int[] innerArr in jaggedArray){
            //     Console.WriteLine("Inner array length is {0}", innerArr.Length);
            // }
            // // Accessing a jagged array
            // Console.WriteLine(jaggedArray2[0][1]); // 3
            // Console.WriteLine(jaggedArray3[2][3]); // 44
        }
        public static int Avg(int[] arr){
            int sum = 0;
            foreach(int a in arr){
                sum += a;
            }
            return sum/arr.Length;
        }
    }
}
