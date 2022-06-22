using System;
using System.Collections.Generic;

namespace Tries
{
    class Program
    {
        static void Main(string[] args)
        {
            Trie trie = new Trie();

            trie.Insert("hello");
            trie.Insert("bye");
            trie.Remove("hello");
            trie.Insert("thing");
        }
    }
}
