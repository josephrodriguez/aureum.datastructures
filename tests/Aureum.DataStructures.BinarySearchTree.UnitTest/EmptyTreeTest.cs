using System;
using Xunit;

namespace Aureum.DataStructures.BinarySearchTree.UnitTest
{
    public class EmptyTreeTest
    {
        [Fact]
        public void EmptyTreeCount()
        {
            var tree = new BinarySearchTree<int, string>();
            Assert.Equal(0, tree.Count);
        }

        [Fact]
        public void EmptyTreeDepth()
        {
            var tree = new BinarySearchTree<int, string>();
            Assert.Equal(0, tree.Depth);
        }
    }
}
