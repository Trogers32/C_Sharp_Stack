using System;
using System.Collections.Generic;

namespace MultipTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[10,10];
            for(int i = 1; i< 11;i++){
                for(var mul = 1; mul<11;mul++){
                    arr[i-1,mul-1] = mul*i;
                }
            }
            for(int i =0;i<10;i++){
                    string arr2 = "";
                for(int j =0;j<10;j++){
                    arr2 += " " + arr[i,j];
                }
                Console.WriteLine(arr2);
            }
        }
    }
}
