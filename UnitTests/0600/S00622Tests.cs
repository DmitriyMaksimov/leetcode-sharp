using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00622Tests
{
    [Test]
    public void T1()
    {
        var myCircularQueue = new S00622.MyCircularQueue(3);
        myCircularQueue.IsEmpty().Should().BeTrue();
        myCircularQueue.Front().Should().Be(-1);
        myCircularQueue.Rear().Should().Be(-1);
        myCircularQueue.EnQueue(1).Should().BeTrue();
        myCircularQueue.Front().Should().Be(1);
        myCircularQueue.IsEmpty().Should().BeFalse();
        myCircularQueue.EnQueue(2).Should().BeTrue();
        myCircularQueue.EnQueue(3).Should().BeTrue();
        myCircularQueue.EnQueue(4).Should().BeFalse();
        myCircularQueue.Rear().Should().Be(3);
        myCircularQueue.IsFull().Should().BeTrue();
        myCircularQueue.DeQueue().Should().BeTrue();
        myCircularQueue.EnQueue(4).Should().BeTrue();
        myCircularQueue.Rear().Should().Be(4);
    }
}
