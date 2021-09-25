using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class Node<Gtype>
    {
        public int key;
        public Node<Gtype> left, right;

        public Node(int item)
        {
            this.key = item;
            this.left = null;
            this.right = null;
        }
    }
}
