using System;
using System.Collections.Generic;

namespace Tries
{
    class Program
    {
        static void Main(string[] args)
        {
            Trie trie = new Trie();

            trie.Insert("babe");
            trie.Insert("baby");
            trie.Insert("he");
            trie.Insert("hey");
            trie.Insert("hell");
            trie.Insert("hello");
            trie.Insert("heaven");
            trie.Insert("havana");
            trie.Remove("he");
            trie.GetAllMatchingPrefix("he");
        }
    }
}
