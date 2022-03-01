using System;

namespace Aureum.DataStructures.BinarySearchTree
{
    public interface IBinarySearchTree<TKey, TValue>
        where TKey : IComparable<TKey>
    {
        void Insert(TKey key, TValue value);

        void Delete(TKey key);

        TValue Find(TKey key);

        Entry<TKey, TValue> Minimum();

        Entry<TKey, TValue> Maximum();
    }
}
