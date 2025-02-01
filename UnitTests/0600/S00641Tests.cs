using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00641Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00641.MyCircularDeque(3);
        Assert.That(sut.InsertLast(1), Is.True);
        Assert.That(sut.InsertLast(2), Is.True);
        Assert.That(sut.InsertFront(3), Is.True);
        Assert.That(sut.InsertFront(4), Is.False);
        Assert.That(sut.GetRear(), Is.EqualTo(2));
        Assert.That(sut.IsFull(), Is.True);
        Assert.That(sut.DeleteLast(), Is.True);
        Assert.That(sut.InsertFront(4), Is.True);
        Assert.That(sut.GetFront(), Is.EqualTo(4));
        Assert.That(sut.DeleteFront(), Is.True);
        Assert.That(sut.GetFront(), Is.EqualTo(3));
    }
}
