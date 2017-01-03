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

            Console.ReadLine();
        }
    }
}
