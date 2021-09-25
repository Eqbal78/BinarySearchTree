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
            binarySearch.insert(22);
            binarySearch.insert(40);
            binarySearch.insert(60);
            binarySearch.insert(95);
            binarySearch.insert(11);
            binarySearch.insert(65);
            binarySearch.insert(3);
            binarySearch.insert(16);
            binarySearch.insert(63);
            binarySearch.insert(67);
            binarySearch.inorder();

            int height = binarySearch.Size(binarySearch.root);
            Console.WriteLine("Height of the Tree is: " + height);
        }
    }
}
