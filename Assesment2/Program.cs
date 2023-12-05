using System;
using System.Collections.Generic;


namespace Assesment2
{
    class Program
    {
        static void Main()
        {
            // Sorting and Searching
            List<int> numbers = new List<int> { 5, 2, 8, 1, 7, 3 };
            Console.WriteLine("Original List: " + string.Join(", ", numbers));

            // Sorting
            Utility<int>.QuickSortAscending(numbers);
            Console.WriteLine("Sorted List (Ascending): " + string.Join(", ", numbers));

            Utility<int>.QuickSortDescending(numbers);
            Console.WriteLine("Sorted List (Descending): " + string.Join(", ", numbers));

            // Searching
            int target = 7;
            bool found = SearchingUtility<int>.BinarySearch(numbers, target);
            Console.WriteLine($"Binary Search: Target {target} found? {found}");

            found = SearchingUtility<int>.LinearSearch(numbers, target);
            Console.WriteLine($"Linear Search: Target {target} found? {found}");

            // Doubly Linked List
            var doublyLinkedList = new DataStructures<int>.DoublyLinkedList<int>();
            doublyLinkedList.AddAtHead(3);
            doublyLinkedList.AddAtTail(7);
            doublyLinkedList.AddAtHead(1);

            Console.Write("Doubly Linked List: ");
            doublyLinkedList.Traverse();

            doublyLinkedList.DeleteNode(7);
            Console.Write("Doubly Linked List after deleting 7: ");
            doublyLinkedList.Traverse();

            // Binary Tree
            var binaryTree = new DataStructures<int>.BinaryTree<int>();
            binaryTree.AddNode(5);
            binaryTree.AddNode(3);
            binaryTree.AddNode(7);
            binaryTree.AddNode(2);
            binaryTree.AddNode(4);
            binaryTree.AddNode(6);
            binaryTree.AddNode(8);

            Console.Write("InOrder Traversal of Binary Tree: ");
            binaryTree.InOrderTraversal();

            Console.ReadLine();
        }
    }
}