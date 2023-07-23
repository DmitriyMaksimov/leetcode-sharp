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
        sut.Peek().Should().Be(1); // return 1
        sut.Pop().Should().Be(1); // return 1, queue is [2]
        sut.Empty().Should().BeFalse(); // return false
    }
}