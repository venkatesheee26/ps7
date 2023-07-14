using System;
using System.Collections.Generic;

public class ArrayListExample
{
    public static void Main(string[] args)
    {
      
        List<string> fruits = new List<string>();

       
        fruits.Add("apple");
        fruits.Add("banana");
        fruits.Add("cherry");
        fruits.Add("date");
        fruits.Add("elderberry");

       
        Console.WriteLine("Total number of elements: " + fruits.Count);

      
        bool containsDate = fruits.Contains("date");
        Console.WriteLine("List contains 'date': " + containsDate);

   
        fruits.Insert(1, "fig");

 
       fruits.Remove("banana");

      
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}


