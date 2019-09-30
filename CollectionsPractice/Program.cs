using System.Linq;
using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Three Basic Arrays
            int[] arr = {0,1,2,3,4,5,6,7,8,9};
            string[] arr1 = {"Tim", "Martin", "Nikki", "Sara"};
            bool[] arr2 = new bool[10];
            arr2[0]=true;
            arr2[1]=false;
            arr2[2]=true;
            arr2[3]=false;
            arr2[4]=true;
            arr2[5]=false;
            arr2[6]=true;
            arr2[7]=false;
            arr2[8]=true;
            arr2[9]=false;
            // List of Flavors
            List<string> flavors = new List<string>();
            flavors.Add("Vanilla");
            flavors.Add("Chocolate");
            flavors.Add("Garbage");
            flavors.Add("Boogers");
            flavors.Add("shoe");
            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.Remove("Garbage");
            Console.WriteLine(flavors.Count);
            // User Info Dictionary
            Dictionary<string,string> users = new Dictionary<string,string>();
            Random rand = new Random();
            foreach(string name in arr1){
                users.Add($"{name}",$"{flavors[rand.Next(0,4)]}");
            }
            foreach (KeyValuePair<string,string> entry in users)
            {
            Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}