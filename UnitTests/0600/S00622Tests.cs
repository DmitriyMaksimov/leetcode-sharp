using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00622Tests
{
    [Test]
    public void T1()
    {
        var myCircularQueue = new S00622.MyCircularQueue(3);
        Assert.That(myCircularQueue.IsEmpty(), Is.True);
        Assert.That(myCircularQueue.Front(), Is.EqualTo(-1));
        Assert.That(myCircularQueue.Rear(), Is.EqualTo(-1));
        Assert.That(myCircularQueue.EnQueue(1), Is.True);
        Assert.That(myCircularQueue.Front(), Is.EqualTo(1));
        Assert.That(myCircularQueue.IsEmpty(), Is.False);
        Assert.That(myCircularQueue.EnQueue(2), Is.True);
        Assert.That(myCircularQueue.EnQueue(3), Is.True);
        Assert.That(myCircularQueue.EnQueue(4), Is.False);
        Assert.That(myCircularQueue.Rear(), Is.EqualTo(3));
        Assert.That(myCircularQueue.IsFull(), Is.True);
        Assert.That(myCircularQueue.DeQueue(), Is.True);
        Assert.That(myCircularQueue.EnQueue(4), Is.True);
        Assert.That(myCircularQueue.Rear(), Is.EqualTo(4));
    }
}
