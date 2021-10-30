using System;
using System.Collections.Generic;

namespace Anagrams {
    public class Program {
        public static void Main(string[] args) {
            List<Anagram> uniqueAnagrams = new List<Anagram>();
            if (!int.TryParse(Console.ReadLine(), out int count))
                Environment.Exit(-1); //TODO At best, redo on exceptions
            for (int i = 0; i < count; i++) {
                String word = Console.ReadLine();
                Anagram anagram = new Anagram(word);
                if(!uniqueAnagrams.Contains(anagram))
                    uniqueAnagrams.Add(anagram);
            }
            
            uniqueAnagrams.Sort((x, y) 
                => String.CompareOrdinal(x.ToString(),y.ToString()));
            
            foreach (Anagram anagram in uniqueAnagrams) {
                Console.WriteLine(anagram);
            }
        }
    }
}