using System;

namespace Aureum.DataStructures.BinarySearchTree
{
    class Node<TKey, TValue> 
        where TKey : IComparable<TKey>
    {
        private readonly Entry<TKey, TValue> _entry;

        public Node(TKey key, TValue value)
        {
            _entry = new Entry<TKey, TValue>(key, value);
        }

        public Node<TKey, TValue> Left { get; set; }

        public Node<TKey, TValue> Right { get; set; }

        public Node<TKey, TValue> Parent { get; set; }

        public Entry<TKey, TValue> Entry => _entry;

        public TKey Key => _entry.Key;

        public TValue Value => _entry.Value;

        public bool IsLeaf => Left == null && Right == null;
    }
}
