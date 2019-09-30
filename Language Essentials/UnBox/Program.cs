using System;
using System.Collections.Generic;

namespace UnBox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> objs = new List<object>();
            objs.Add(7);
            objs.Add(28);
            objs.Add(-1);
            objs.Add(true);
            objs.Add("chair");
            int sum = 0;
            foreach(var i in objs){
                Console.WriteLine(i);
                if(i is int){
                    sum += (int)i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
//  Create an empty List of type object
//  Add the following values to the list: 7, 28, -1, true, "chair"
//  Loop through the list and print all values (Hint: Type Inference might help here!)
//  Add all values that are Int type together and output the sum