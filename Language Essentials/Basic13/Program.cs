using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static void PrintNumbers()
        {
            for(int i =1; i<256;i++){
                Console.WriteLine(i);
            }
        }
        public static void PrintOdds()
        {
            for(int i = 1; i <256;i+=2){
                Console.WriteLine(i);
            }
            // Print all of the odd integers from 1 to 255.
        }
        public static void PrintSum()
        {
            int sum = 0;
            for(int i = 0; i<256; i++){
                sum += i;
                Console.WriteLine($"New number: {i} Sum: {sum}");
            }
            // Print all of the numbers from 0 to 255, 
            // but this time, also print the sum as you go. 
            // For example, your output should be something like this:
            
            // New number: 0 Sum: 0
            // New number: 1 Sum: 1
            // New Number: 2 Sum: 3
        }
        public static void LoopArray(int[] numbers)
        {
            foreach(int i in numbers){
                Console.WriteLine(i);
            }
            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console. 
        }
        public static int FindMax(int[] numbers)
        {
            int max = numbers[0];
            foreach(int i in numbers){
                if(max<i){
                    max = i;
                }
            }
            return max;
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.
        }
        public static void GetAverage(int[] numbers)
        {
            int ave = 0;
            foreach(int i in numbers){
                ave += i;
            }
            ave /= numbers.Length;
            Console.WriteLine(ave);
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.
        }
        public static int[] OddArray()
        {
            int[] nums = new int[128];
            int count = 1;
            for(int i = 0; i<129;i++){
                nums[i] = count;
                count+=2;
            }
            return nums;
            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
            // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
        }
        public static int GreaterThanY(int[] numbers, int y)
        {
            int count = 0;
            foreach(int i in numbers){
                if(y<i){
                    count++;
                }
            }
            return count;
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).
        }
        public static void SquareArrayValues(int[] numbers)
        {
            for(int i = 0; i<numbers.Length;i++){
                numbers[i] *= numbers[i];
            }
            // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]
        }
        public static void EliminateNegatives(int[] numbers)
        {
            for(int i = 0; i<numbers.Length; i++){
                if(numbers[i]<0){
                    numbers[i] = 0;
                }
            }
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
        }
        public static void MinMaxAverage(int[] numbers)
        {
            int max = numbers[0];
            int min = numbers[0];
            int ave = 0;
            for(int i = 0; i<numbers.Length;i++){
                if(numbers[i]<min){
                    min = numbers[i];
                }
                if(numbers[i]>max){
                    max = numbers[i];
                }
                ave += numbers[i];
            }
            ave /= numbers.Length;
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(ave);
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.
        }
        public static void ShiftValues(int[] numbers)
        {
            for(int i =0;i<numbers.Length-1;i++){
                numbers[i] = numbers[i+1];
            }
            numbers[numbers.Length-1] = 0;
            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].
        }
        public static object[] NumToString(int[] numbers)
        {
            object[] d = new object[numbers.Length];
            for(int i = 0; i<numbers.Length; i++){
                if(numbers[i]<0){
                    d[i]="Dojo";
                } else {
                    d[i] = numbers[i];
                }
            }
            return d;
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
        }
    }
}
