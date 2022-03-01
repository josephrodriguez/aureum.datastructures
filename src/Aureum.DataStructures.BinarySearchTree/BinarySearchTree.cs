using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aureum.DataStructures.BinarySearchTree
{
    public class BinarySearchTree<TKey, TValue> : IBinarySearchTree<TKey, TValue>
        where TKey : IComparable<TKey>
    {
        private Node<TKey, TValue> root;

        private int count;

        public BinarySearchTree()
        {
            count = 0;
        }

        public void Insert(TKey key, TValue value)
        {
            Node<TKey, TValue> parent  = null;
            Node<TKey, TValue> current = root;

            while (current != null)
            {
                parent = current;
                if (key.CompareTo(current.Key) < 0)
                    current = current.Left;
                else
                    current = current.Right;
            }

            var node = new Node<TKey, TValue>(key, value) { Parent = parent };

            if (parent == null)
                root = node;
            else if (node.Key.CompareTo(parent.Key) < 0)
                parent.Left = node;
            else
                parent.Right = node;

            count++;
        }

        public void Delete(TKey key)
        {
            throw new NotImplementedException();
        }

        public TValue GetValue(TKey key)
        {
            throw new NotImplementedException();
        }

        public TValue Find(TKey key)
        {
            throw new NotImplementedException();
        }

        public Entry<TKey, TValue> Minimum()
        {
            var current = root;
            while (current?.Left != null)
                current = current.Left;

            return current.Entry;
        }

        public Entry<TKey, TValue> Maximum()
        {
            var current = root;
            while (current?.Right != null)
                current = current.Right;

            return current.Entry;
        }
    }
}
