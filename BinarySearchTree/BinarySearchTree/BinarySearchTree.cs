using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree<T> : IComparable<T>
    {
        Node<T> rootNode;

        public BinarySearchTree()
        {
            rootNode = new Node<T>();
            rootNode = null;
        }
        public Node<T> RootNode
        {
            get
            {
                return rootNode;
            }
            set
            {
                rootNode = value;
            }
        }
        public void Add(T input)
        {
            Node<T> newNode = new Node<T>();
            newNode.Value = input;      
            if (RootNode == null)
            {
                RootNode = newNode;
                RootNode.Value = newNode.Value;           
            }
            else if (RootNode != null)
            {
                IComparable comparable = (IComparable)newNode.Value;
                if (comparable.CompareTo(RootNode.Value) >= 0)
                {
                    if (newNode.Right == null)
                    {
                        newNode.Right = newNode;
                        RootNode.Right = newNode.Right;
                    }
                    else if (newNode.Right != null)
                    {
                        Add(newNode.Right.Value);
                    }
                }
                else if (comparable.CompareTo(RootNode.Value) < 0)
                {
                    if (newNode.Left == null)
                    {
                        newNode.Left = newNode;
                    }
                    else if (newNode.Left != null)
                    {
                        Add(newNode.Left.Value);
                    }
                } 
            }
        }
        public void Add(Node<T> node, T value)
        {

        }



        public int CompareTo(T other)
        {
            throw new NotImplementedException();
        }
    }
}
