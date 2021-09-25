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

        /// <summary>
        /// Root of BST
        /// </summary>
        public Node<Gtype> root;

        /// <summary>
        /// Constructor
        /// </summary>
        public BinarySearchTree()
        {
            this.root = null;
        }

        /// <summary>
        /// This method mainly calls insertRec()
        /// </summary>
        /// <param name="value">insert the value in tree</param>
        public void insert(int value)
        {
            root = insertRec(root, value);
        }


        /// <summary>
        /// A recursive function to insert
        /// </summary>
        /// <param name="root">Root Node</param>
        /// <param name="value">Value in tree</param>
        /// <returns></returns>
        public Node<Gtype> insertRec(Node<Gtype> root, int value)
        {

            // If the tree is empty,return a new node
            if (root == null)
            {
                root = new Node<Gtype>(value);
                return root;
            }

            // Otherwise, recur down the tree
            if (value < root.key)
            {
                root.left = insertRec(root.left, value);
            }
            else if (value > root.key)
            {
                root.right = insertRec(root.right, value);
            }

            // Return the (unchanged) node pointer
            return root;
        }

        /// <summary>
        /// This method mainly calls InorderRec()
        /// </summary>
        public void inorder()
        {
            inorderRec(root);
        }

        /// <summary>
        /// do inorder traversal of BST
        /// </summary>
        /// <param name="root"></param>
        public void inorderRec(Node<Gtype> root)
        {
            if (root != null)
            {
                inorderRec(root.left);
                Console.WriteLine(root.key);
                inorderRec(root.right);
            } 
        }

        /// <summary>
        /// Calculate heiht of tree
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int Size(Node<Gtype> node)
        {
            if (node == null)
                return 0;
            else
            {
                //compute the depth of each subtree 
                int leftsize = Size(node.left);
                int rightsize = Size(node.right);

                // use the larger one 
                if (leftsize > rightsize)
                {
                    return (leftsize + 1);
                }
                else
                {
                    return (rightsize + 1);
                }
            }

        }

        /// <summary>
        /// Search element in tree
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Search(Node<Gtype> root, int value)
        {
            //loop start if root is not null
            while (root != null)
            {
                //check value is present in tree or not 
                if (root.key == value)
                {
                    Console.WriteLine("Value {0} is Present", value);
                    return true;
                }
                else if (root.key > value)
                {
                    return Search(root.left, value);
                }
                else
                {
                    return Search(root.right, value);
                }
            }
            Console.WriteLine("Value is not Present!");
            return false;
        }
    }
}
