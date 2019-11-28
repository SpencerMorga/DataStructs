using System;
using System.Collections.Generic;


namespace BinarySearchTreeExample
{
    public class Node<T>
    {
        /// <summary>
        ///
        /// copied and pasted trying to save to /github t(O)
        ///
        ///this is for a test commit, edits necessary
        /// 
        /// </summary>
        public T Value;
        public Node<T> Left;
        public Node<T> Right;
        public Node<T> Parent;

        //Lets us know if the Node is a left or a right child
        public bool IsLeftChild => Parent == null ? false : Parent.Left == this;
        public bool IsRightChild => Parent == null ? false : Parent.Right == this;

        //Let us know how many children aren't null
        public int ChildCount 
        {
            get
            {
                int count = 0;
                if (Left != null)
                {
                    count++;
                }
                if (Right != null)
                {
                    count++;
                }
                return count;////////r//r//r/rt/r
            }
        }

        public Node(T value, Node<T> parent = null)
        {
            Value = value;
            Parent = parent;
        }
    }

    public class BinaryTree<T> where T : IComparable<T>
    {
        private Node<T> root;
        public int Count { get; private set; }
        public T RootValue => root.Value;

        public BinaryTree()
        {
            root = null;
            Count = 0;
        }

        /// <summary>
        /// Insert a value into the tree
        /// </summary>
        /// <param name="value">The new value that will be inserted</param>
        public void Insert(T value)
        {
            //If the root is null create a new root 
            //Else search for a place to insert into the tree

            Count++;
            if (root != null)
            {
                root = new Node<T>(value);
                return;
            }

            Node<T> current = root;
            while (current != null)
            {
                //If the value is less than
                //We go to the left or if the left is null we insert the value at the left
                //Samething goes for the right side
                if (value.CompareTo(current.Value) < 0)
                {
                    if (current.Left == null)
                    {
                        current.Left = new Node<T>(value, current);
                        break;
                    }
                    current = current.Left;
                }
                else
                {
                    if (current.Right == null)
                    {
                        current.Right = new Node<T>(value, current);
                        break;
                    }
                    current = current.Right;
                }
            }
        }

        private Node<T> Find(T value)
        {
            Node<T> current = root;
            while (current != null)
            {
                int comp = value.CompareTo(current.Value);

                if (comp < 0)
                {
                    current = current.Left;
                }
                else if (comp > 0)
                {
                    current = current.Right;
                }
                else if (comp == 0)
                {
                    return current;
                }
            }

            return null;
        }

        public bool Contains(T value)
        {
            return Find(value) != null;
        }

        /// <summary>
        /// Deleting a value from the tree
        /// </summary>
        /// <param name="value">The value to delete</param>
        /// <returns>If the deletion was succesful</returns>
        public bool Delete(T value)
        {
            Node<T> toDelete = Find(value);
            if (toDelete == null)
            {
                return false;
            }

            Delete(toDelete);
            Count--;
            return true;
        }

        private void Delete(Node<T> node)
        {
            if (node.ChildCount == 2)
            {
                Node<T> candidate = Minimum(node.Right);
                node.Value = candidate.Value;
                node = candidate; // node is now pointing to candidate
            }

            if (node.ChildCount == 0) //set parents child pointer to null
            {
                if (node == root)
                {
                    root = null;
                }
                else if (node.IsLeftChild)
                {
                    node.Parent.Left = null;
                }
                else if (node.IsRightChild)
                {
                    node.Parent.Right = null;
                }
            }
            else if (node.ChildCount == 1) //link child to parent
            {
                Node<T> child = node.Left == null ? node.Right : node.Left;

                if (node == root)
                {
                    root = child;
                }
                else if (node.IsLeftChild)
                {
                    node.Parent.Left = child;
                }
                else if (node.IsRightChild)
                {
                    node.Parent.Right = child;
                }
                child.Parent = node.Parent;
            }
        }

        /// <summary>
        /// Get the minimum value of the node
        /// </summary>
        /// <param name="node">The starting node to find the minimum</param>
        /// <returns>The minimum node value</returns>
        private Node<T> Minimum(Node<T> node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }

            return node;
        }

        /// <summary>
        /// Get the maximum value of the node
        /// </summary>
        /// <param name="node">The starting node to find the maximum</param>
        /// <returns>The maximum node value</returns>
        private Node<T> Maximum(Node<T> node)
        {
            while (node.Right != null)
            {
                node = node.Right;
            }

            return node;
        }

        /// <summary>
        /// Go through the tree in PreOrder starting from the root
        /// </summary>
        /// <returns>Values of the tree in PreOrder</returns>
        public IEnumerable<T> PreOrder()
        {
            Queue<T> nodes = new Queue<T>();

            Stack<Node<T>> stack = new Stack<Node<T>>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                Node<T> curr = stack.Pop();

                nodes.Enqueue(curr.Value);

                if (curr.Right != null)
                {
                    stack.Push(curr.Right);
                }

                if (curr.Left != null)
                {
                    stack.Push(curr.Left);
                }
            }

            return nodes;
        }

        /// <summary>
        /// Go through the tree in InOrder starting from the root
        /// </summary>
        /// <returns>Values of the tree in InOrder</returns>
        public IEnumerable<T> InOrder()
        {
            Queue<T> nodes = new Queue<T>();

            Stack<Node<T>> stack = new Stack<Node<T>>();

            Node<T> curr = root;

            while (curr != null || stack.Count != 0)
            {
                if (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.Left;
                }
                else
                {
                    curr = stack.Pop();
                    nodes.Enqueue(curr.Value);
                    curr = curr.Right;
                }
            }

            return nodes;
        }

        /// <summary>
        /// Go through the tree in PostPorder starting from the root
        /// </summary>
        /// <returns>Values of the tree in PostOrder</returns>
        public IEnumerable<T> PostOrder()
        {
            Stack<T> nodes = new Stack<T>();

            Stack<Node<T>> stack = new Stack<Node<T>>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                Node<T> curr = stack.Pop();

                nodes.Push(curr.Value);

                if (curr.Left != null)
                {
                    stack.Push(curr.Left);
                }

                if (curr.Right != null)
                {
                    stack.Push(curr.Right);
                }
            }

            return nodes;
        }

        /// <summary>
        /// Go through the tree in BreadthFirst
        /// </summary>
        /// <returns>Values of the tree in BreadthFirst</returns>
        public IEnumerable<T> BreadthFirst()
        {
            Queue<Node<T>> temp = new Queue<Node<T>>(new Node<T>[] { root });
            Queue<T> nodes = new Queue<T>();

            while (temp.Count != 0)
            {
                Node<T> cur = temp.Dequeue();
                nodes.Enqueue(cur.Value);

                if (cur.Left != null)
                {
                    temp.Enqueue(cur.Left);
                }
                if (cur.Right != null)
                {
                    temp.Enqueue(cur.Right);
                }
            }

            return nodes;
        }
    }
}