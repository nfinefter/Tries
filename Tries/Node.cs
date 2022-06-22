using System;
using System.Collections.Generic;
using System.Text;

namespace Tries
{
    class Node
    {
        public char Letter { get; private set; }
        public Dictionary<char, Node> Children { get; private set; }
        public bool IsWord { get; set; }

        public Node(char c)
        {
            Children = new Dictionary<char, Node>();
            Letter = c;
            IsWord = false;
        }
    }
}
