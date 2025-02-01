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
        Assert.That(peekingIterator.Next(), Is.EqualTo(0));
        Assert.That(peekingIterator.Next(), Is.EqualTo(1)); // return 1, the pointer moves to the next element [1,*2*,3].
        Assert.That(peekingIterator.Peek(), Is.EqualTo(2)); // return 2, the pointer does not move [1,*2*,3].
        Assert.That(peekingIterator.Next(), Is.EqualTo(2)); // return 2, the pointer moves to the next element [1,2,*3*]
        Assert.That(peekingIterator.Next(), Is.EqualTo(3)); // return 3, the pointer moves to the next element [1,2,3]
        Assert.That(peekingIterator.HasNext(), Is.False); // return False
    }
}
