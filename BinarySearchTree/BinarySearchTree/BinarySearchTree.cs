using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree 
{
    class BinarySearchTree<T> : IComparable<T>, IEnumerable<T>
    {
        Node<T> rootNode;
        List<T> nodeList;
        bool isInTree;
        public BinarySearchTree()
        {
            rootNode = new Node<T>();
            rootNode = null;
            nodeList = new List<T>();
            
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
            Node<T> newNode = new Node<T>(input);
            newNode.Value = input;
            if (RootNode == null)
            {
                RootNode = newNode;
            }
            else if (RootNode != null)
            {
                Node<T> current = rootNode;
                Node<T> parent;
                while (true)
                {
                    parent = current;
                    IComparable comparable = (IComparable)newNode.Value;
                    if (comparable.CompareTo(RootNode.Value) >= 0)
                    {
                        newNode.nodePath.Add("Right");
                        if (rootNode.Right == null)
                        {
                            rootNode.Right = newNode;                           
                            break;
                        }
                        else
                        {
                            Add(newNode, rootNode.Right);
                        }
                        break;
                    }
                    else if (comparable.CompareTo(RootNode.Value) < 0)
                    {
                        newNode.nodePath.Add("Left");
                        if (rootNode.Left == null)
                        {                          
                            rootNode.Left = newNode;
                        }
                        else
                        {
                            Add(newNode, rootNode.Left);
                        }
                        break;
                    }
                    break;
                }
            }
        }
        public void Add(Node<T> newNode, Node<T> branchNode)
        {
            
            if (RootNode == null)
            {
                RootNode = branchNode;
            }
            else if (RootNode != null)
            {
                Node<T> current = branchNode;
                Node<T> parent;
                while (true)
                {
                    parent = current;
                    IComparable comparable = (IComparable)newNode.Value;
                    if (comparable.CompareTo(branchNode.Value) >= 0)
                    {
                        newNode.nodePath.Add("Right");

                        if (branchNode.Right == null)
                        {
                            branchNode.Right = newNode;
                            break;
                        }
                        else
                        {
                            Add(newNode, branchNode.Right);
                        }
                        break;
                    }
                    else if (comparable.CompareTo(branchNode.Value) < 0)
                    {
                        newNode.nodePath.Add("Left");
                        if (branchNode.Left == null)
                        {
                            branchNode.Left = newNode;
                        }
                        else
                        {
                            Add(newNode, branchNode.Left);
                        }
                        break;
                    }
                    break;
                }
            }
        }

        public Node<int> GetNodeIntInTree(BinarySearchTree<int> tree, int input)
        {
            Node<int> temporaryNode = new Node<int>();
            if (tree.rootNode == null)
            {
                temporaryNode = tree.rootNode;
            }
            else if (input == tree.rootNode.Value)
            {
                temporaryNode = tree.rootNode;
            }
            else if (input > tree.rootNode.Value)
            {
                if (tree.rootNode.Right == null)
                {
                    temporaryNode = tree.rootNode;
                }
                else if (tree.rootNode.Right.Value == input)
                {
                    temporaryNode = tree.rootNode.Right;
                }
                else
                {
                    temporaryNode = GetNodeIntInTree(tree, tree.rootNode.Right, input);
                }
            }
            else if (input < tree.rootNode.Value)
            {
                if (tree.rootNode.Left == null)
                {
                    temporaryNode = tree.RootNode;
                }
                else if (tree.rootNode.Left.Value == input)
                {
                    temporaryNode = tree.RootNode.Left;
                }
                else
                {
                    temporaryNode = GetNodeIntInTree(tree, tree.rootNode.Left, input);

                }
            }
            return temporaryNode;
        }

        public Node<int> GetNodeIntInTree(BinarySearchTree<int> tree, Node<int> node, int input)
        {
            Node<int> temporaryNode = new Node<int>();
            if (rootNode == null)
            {
                temporaryNode = node;
            }
            else if (input == node.Value)
            {
                temporaryNode = node;
            }
            else if (input > node.Value)
            {
                if (node.Right == null)
                {
                    isInTree = false;
                }
                else if (node.Right.Value == input)
                {
                    temporaryNode = node.Right;
                }
                else
                {
                    temporaryNode = GetNodeIntInTree(tree, node.Right, input);
                }
            }
            else if (input < node.Value)
            {
                if (tree.rootNode.Left == null)
                {
                    isInTree = false;
                }
                else if (node.Left.Value == input)
                {
                    temporaryNode = node.Left;
                }
                else
                {
                    temporaryNode = GetNodeIntInTree(tree, node.Left, input);
                }
            }
            return temporaryNode;
        }

        public bool IsIntInTree(BinarySearchTree<int> tree, int input)
        {
            isInTree = false;
            if(tree.rootNode == null)
            {
                isInTree = false;
            }
            else if(input == tree.rootNode.Value)
            {
                isInTree = true;
            }
            else if (input > tree.rootNode.Value)
            {               
                if (tree.rootNode.Right == null)
                {
                    isInTree = false;
                }
                else if (tree.rootNode.Right.Value == input)
                {
                    isInTree = true;
                }
                else
                {
                    IsIntInTree(tree, tree.rootNode.Right, input);
                }              
            }
            else if ( input < tree.rootNode.Value)
            { 
                if (tree.rootNode.Left == null)
                {
                    isInTree = false;
                }
                else if (tree.rootNode.Left.Value == input)
                {
                    isInTree = true;
                }
                else
                {
                    IsIntInTree(tree, tree.rootNode.Left, input);
                }
            }
            return isInTree;
        }
        public bool IsIntInTree(BinarySearchTree<int> tree, Node<int> node, int input)
        {            
              if (rootNode == null)
            {
                isInTree = false;
            }
            else if (input == node.Value)
            {
                isInTree = true;
            }
            else if (input > node.Value)
            {               
                if (node.Right == null)
                {
                    isInTree = false;
                }
                else if (node.Right.Value == input)
                {
                    isInTree = true;
                }
                else 
                {
                    IsIntInTree(tree, node.Right, input);
                }
            }
            else if (input < node.Value)
            {
                if (tree.rootNode.Left == null)
                {
                    isInTree = false;
                }
                else if (node.Left.Value == input)
                {
                    isInTree = true;
                }               
                else
                {
                    IsIntInTree(tree, node.Left, input);
                }
            }
            return isInTree;
        }

        public void DisplayIntNodePath(BinarySearchTree<int> tree, int nodeValue)
        {
            if (GetNodeIntInTree(tree, nodeValue).Value == nodeValue)
            {
                Console.WriteLine("Path to " + nodeValue + " from root:");
                foreach (var element in GetNodeIntInTree(tree, nodeValue).nodePath)
                {
                    Console.WriteLine(element.ToString());
                }
            }
            else
            {
                Console.WriteLine("Number is not in Tree");
            }
            
        }



        public int CompareTo(T other)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}


//IComparable comparable = (IComparable)newNode.Value;
//if (comparable.CompareTo(RootNode.Value) >= 0)
//{
//    if (newNode.Right == null)
//    {
//        newNode.Right = newNode;
//        RootNode.Right = newNode.Right;
//    }
//    else if (newNode.Right != null)
//    {
//        Add(newNode.Right.Value);
//    }
//}
//else if (comparable.CompareTo(RootNode.Value) < 0)
//{
//    if (newNode.Left == null)
//    {
//        newNode.Left = newNode;
//    }
//    else if (newNode.Left != null)
//    {
//        Add(newNode.Left.Value);
//    }
//} 
