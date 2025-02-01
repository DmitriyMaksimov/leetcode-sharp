using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00232Tests
{
    [Test]
    public void T0()
    {
        var sut = new S00232();

        sut.Push(1); // queue is: [1]
        sut.Push(2); // queue is: [1, 2] (leftmost is front of the queue)
        Assert.That(sut.Peek(), Is.EqualTo(1)); // return 1
        Assert.That(sut.Pop(), Is.EqualTo(1)); // return 1, queue is [2]
        Assert.That(sut.Empty(), Is.False); // return false
    }
}
