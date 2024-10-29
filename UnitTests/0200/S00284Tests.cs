using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00284Tests
{
    [Test]
    public void T1()
    {
        var n = new List<int> { 1, 2, 3 };
        var peekingIterator = new S00284.PeekingIterator(n.GetEnumerator());
        peekingIterator.Next().Should().Be(0);
        peekingIterator.Next().Should().Be(1); // return 1, the pointer moves to the next element [1,*2*,3].
        peekingIterator.Peek().Should().Be(2); // return 2, the pointer does not move [1,*2*,3].
        peekingIterator.Next().Should().Be(2); // return 2, the pointer moves to the next element [1,2,*3*]
        peekingIterator.Next().Should().Be(3); // return 3, the pointer moves to the next element [1,2,3]
        peekingIterator.HasNext().Should().BeFalse(); // return False
    }
}
