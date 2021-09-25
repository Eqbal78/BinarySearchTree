using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree");
            // create object
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>();
            // Add Element
            binarySearch.insert(56);
            binarySearch.insert(30);
            binarySearch.insert(70);
            binarySearch.inorder();
        }
    }
}
