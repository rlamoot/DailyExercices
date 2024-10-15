/* Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
    For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17. */

using System;
using System.Collections.Generic;

class Program
{
    static bool HasPairwithSum(int[] array, int k)
    {
        HashSet <int> Seen = new HashSet <int>();
        foreach (int i in array){
            int complement = k - i;
            if (Seen.Contains(complement)){
                return true;
            }
            Seen.Add(i);
        }
        return false;
    }

    static void Main(string[] args){
        int[] array = { 10, 15, 3, 7};
        int k = 18;
        bool result = HasPairwithSum(array, k);
        Console.WriteLine(result);
    }

}