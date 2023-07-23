using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02336Tests
{
    [Test]
    public void T1()
    {
        var smallestInfiniteSet = new S02336.SmallestInfiniteSet();
        smallestInfiniteSet.AddBack(2); // 2 is already in the set, so no change is made.
        smallestInfiniteSet.PopSmallest().Should().Be(1); // return 1, since 1 is the smallest number, and remove it from the set.
        smallestInfiniteSet.PopSmallest().Should().Be(2); // return 2, and remove it from the set.
        smallestInfiniteSet.PopSmallest().Should().Be(3); // return 3, and remove it from the set.
        smallestInfiniteSet.AddBack(1); // 1 is added back to the set.
        smallestInfiniteSet.PopSmallest().Should().Be(1); // return 1, since 1 was added back to the set and
        // is the smallest number, and remove it from the set.
        smallestInfiniteSet.PopSmallest().Should().Be(4); // return 4, and remove it from the set.
        smallestInfiniteSet.PopSmallest().Should().Be(5); // return 5, and remove it from the set.
    }
}