using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01670Tests
{
    [Test]
    public void T1()
    {
        var q = new S01670.FrontMiddleBackQueue();
        q.PushFront(1); // [1]
        q.PushBack(2); // [1, 2]
        q.PushMiddle(3); // [1, 3, 2]
        q.PushMiddle(4); // [1, 4, 3, 2]
        Assert.That(q.PopFront(), Is.EqualTo(1)); // return 1 -> [4, 3, 2]
        Assert.That(q.PopMiddle(), Is.EqualTo(3)); // return 3 -> [4, 2]
        Assert.That(q.PopMiddle(), Is.EqualTo(4)); // return 4 -> [2]
        Assert.That(q.PopBack(), Is.EqualTo(2)); // return 2 -> []
        Assert.That(q.PopFront(), Is.EqualTo(-1)); // return -1 -> [] (The queue is empty)
    }
}
