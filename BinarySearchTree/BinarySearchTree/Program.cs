using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> newTree = new BinarySearchTree<int>();
            newTree.Add(5);
            newTree.Add(20);
            newTree.Add(4);
            newTree.Add(15);
            newTree.Add(17);
            newTree.Add(1);
            newTree.Add(8);
            newTree.Add(2);
            newTree.Add(6);
            newTree.Add(7);

            newTree.DisplayIntNodePath(newTree, 7);
            Console.WriteLine();
            newTree.DisplayIntNodePath(newTree, 6);
            Console.WriteLine();
            newTree.DisplayIntNodePath(newTree, 20);
            Console.WriteLine();
            newTree.DisplayIntNodePath(newTree, 15);
            Console.WriteLine();
            newTree.DisplayIntNodePath(newTree, 3);
            Console.WriteLine();
            Console.WriteLine(newTree.IsIntInTree(newTree, 2));
            Console.WriteLine(newTree.IsIntInTree(newTree, 21));
            Console.WriteLine(newTree.IsIntInTree(newTree, 5));
            Console.WriteLine(newTree.IsIntInTree(newTree, 6));

            Console.ReadLine();
        }
    }
}
