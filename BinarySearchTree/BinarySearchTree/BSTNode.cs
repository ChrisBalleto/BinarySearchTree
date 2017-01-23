using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node<T>
    {
        T value;
        Node<T> right;
        Node<T> left;
        public List<string> nodePath;

        public Node (T value)
        {
            nodePath = new List<string>();
            this.value = value;
        }
        public Node()
        {
            nodePath = new List<string>();

        }
        public Node<T> Right
        {
            get
            {
                return right;
            }
            set
            {
                right = value;
            }
        }
        public Node<T> Left
        {
            get
            {
                return left;
            }
            set
            {
                left = value;
            }
        }
        public T Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
            }
        }
    }
}
