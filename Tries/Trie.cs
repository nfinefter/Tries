using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Tries
{
    class Trie : IEnumerable
    {

        private Node root;

        public Trie()
        {
            root = new Node('$');
        }

        public void Clear()
        {
            root = new Node(' ');
        }

        public void Insert(string word)
        {
            var children = root.Children;

            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];
                Node temp;

                if (children.ContainsKey(letter))
                {
                    temp = children[letter];
                }
                else
                {
                    temp = new Node(letter);
                    children.Add(letter, temp);
                }

                children = temp.Children;

                if (i == word.Length - 1)
                {
                    temp.IsWord = true;
                }
            }
        }

        public bool Contains(string word)
        {
            if (SearchNode(word) != null)
            {
                return true;
            }

            return false;
        }


        private Node SearchNode(string word)
        {
            var tempChildren = root.Children;
            Node temp = null;

            foreach (var current in word)
            {
                if (tempChildren.ContainsKey(current))
                {
                    temp = tempChildren[current];
                    tempChildren = temp.Children;
                }
                else
                {
                    return null;
                }
            }

            return temp;
        }

        public List<string> GetAllMatchingPrefix(string prefix)
        {
            List<string> words = new List<string>();

            Node start = SearchNode(prefix);

            GetWord(start, prefix, words);
                     
            return words;
        }
        private void GetWord(Node node, string prefix, List<string> words)
        {

            if (node.IsWord)
            {
                words.Add(prefix);
            }

            foreach (KeyValuePair<char, Node> kvpair in node.Children)
            {
                GetWord(kvpair.Value, prefix + kvpair.Key, words);
            }
            
        }


        public bool Remove(string prefix)
        {
            var node = SearchNode(prefix);
            if (node == null)
            {
                return false;
            }
            node.IsWord = false;

            return true;
        }

        public IEnumerator GetEnumerator()
        {

            yield return "";
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
