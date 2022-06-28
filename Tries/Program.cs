using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace Tries
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileContents = File.ReadAllText("fulldictionary.json");
            Dictionary<string, string> wordDefinitions = JsonSerializer.Deserialize<Dictionary<string, string>>(fileContents);

            Trie trie = new Trie();

            //trie.Insert("babe");
            //trie.Insert("baby");
            //trie.Insert("he");
            //trie.Insert("hey");
            //trie.Insert("hell");
            //trie.Insert("hello");
            //trie.Insert("heaven");
            //trie.Insert("havana");
            //trie.Remove("he");
            //trie.GetAllMatchingPrefix("wo");

            foreach (string key in wordDefinitions.Keys)
            {
                trie.Insert(key);
            }

            
            Console.WriteLine("Give me a prefix");
            string prefix = Console.ReadLine();
            List<string> words = trie.GetAllMatchingPrefix(prefix);
            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
