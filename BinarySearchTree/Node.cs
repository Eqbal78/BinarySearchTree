using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class Node<Gtype>
    {
        /// <summary>
        /// Initialize key store value
        /// </summary>
        public int key;

        /// <summary>
        /// Intialize left and righr tree 
        /// </summary>
        public Node<Gtype> left, right;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="value"></param>
        public Node(int value)
        {
            this.key = value;
            this.left = null;
            this.right = null;
        }
    }
}
