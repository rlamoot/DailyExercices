/* Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
    For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17. */

using System;
using System.Collections.Generic;

class Program
{
    static bool HasSeen(int[] Array, int k){
        HashSet<int> seen = new HashSet<int>();
        foreach(int i in Array){        
            int complement = k - i;
            Console.WriteLine(complement);
            if  (seen.Contains(complement)){
                return true;
            }
            seen.Add(i);
        }
        
        return false;

    }
    static void Main(string[] args){
        int[] arr = { 10, 15, 3, 14};
        int k = 17;
        var result = HasSeen(arr, k);
        Console.WriteLine(result);
    }

}