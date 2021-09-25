using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    /// <summary>
    /// Create Binary Search Tree class Generic Type
    /// </summary>
    /// <typeparam name="Gtype"></typeparam>
    class BinarySearchTree<Gtype>
    {

        // Root of BST
        public Node<Gtype> root;

        // Constructor
        public BinarySearchTree()
        {
            this.root = null;
        }

        // This method mainly calls insertRec()
        public void insert(int value)
        {
            root = insertRec(root, value);
        }

        // A recursive function to insert
        // a new key in BST
        public Node<Gtype> insertRec(Node<Gtype> root, int value)
        {

            // If the tree is empty,
            // return a new node
            if (root == null)
            {
                root = new Node<Gtype>(value);
                return root;
            }

            // Otherwise, recur down the tree
            if (value < root.key)
                root.left = insertRec(root.left, value);
            else if (value > root.key)
                root.right = insertRec(root.right, value);

            // Return the (unchanged) node pointer
            return root;
        }

        // This method mainly calls InorderRec()
        public void inorder()
        {
            inorderRec(root);
        }

        // A utility function to
        // do inorder traversal of BST
        public void inorderRec(Node<Gtype> root)
        {
            if (root != null)
            {
                inorderRec(root.left);
                Console.WriteLine(root.key);
                inorderRec(root.right);
            } 
        }
    }
}
