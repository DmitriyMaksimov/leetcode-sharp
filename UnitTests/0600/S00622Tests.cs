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
        Assert.That(myCircularQueue.Front(), Is.EqualTo(-1));
        Assert.That(myCircularQueue.Rear(), Is.EqualTo(-1));
        myCircularQueue.EnQueue(1).Should().BeTrue();
        Assert.That(myCircularQueue.Front(), Is.EqualTo(1));
        myCircularQueue.IsEmpty().Should().BeFalse();
        myCircularQueue.EnQueue(2).Should().BeTrue();
        myCircularQueue.EnQueue(3).Should().BeTrue();
        myCircularQueue.EnQueue(4).Should().BeFalse();
        Assert.That(myCircularQueue.Rear(), Is.EqualTo(3));
        myCircularQueue.IsFull().Should().BeTrue();
        myCircularQueue.DeQueue().Should().BeTrue();
        myCircularQueue.EnQueue(4).Should().BeTrue();
        Assert.That(myCircularQueue.Rear(), Is.EqualTo(4));
    }
}
