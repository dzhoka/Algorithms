using NUnit.Framework;
using System;
using System.Collections.Generic;
namespace Algorithms
{
    [TestFixture]
    public class CollectionsTests
    {
        [Test]
        public void FindKthElement()
        {
            var numbers = new List<int> { 30, 10, 20 };
            Assert.True(Collections.FindKthElement(numbers, 1) == 10);
            Assert.True(Collections.FindKthElement(numbers, 3) == 30);

            var strings = new List<string> { "bus", "airplain", "train" };
            Assert.True(Collections.FindKthElement(strings, 2) == "bus");
            Assert.True(Collections.FindKthElement(strings, 3) == "train");
        }

        [Test]
        public void FindKthElementOutOfRange()
        {
            var numbers = new List<int> { 1, 2, 3 };

            Assert.That(() => Collections.FindKthElement(numbers, 0),
                        Throws.Exception.TypeOf<ArgumentOutOfRangeException>());

            Assert.That(() => Collections.FindKthElement(numbers, 4),
                        Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}
