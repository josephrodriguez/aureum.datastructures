namespace Aureum.DataStructures.BinarySearchTree
{
    public class Entry<TKey, TValue>
    {
        private readonly TKey _key;
        private readonly TValue _value;

        public Entry(TKey key, TValue value)
        {
            _key = key;
            _value = value;
        }

        public TKey Key => _key;

        public TValue Value => _value;
    }
}
