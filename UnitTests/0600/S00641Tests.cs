using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00641Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00641.MyCircularDeque(3);
        sut.InsertLast(1).Should().BeTrue();
        sut.InsertLast(2).Should().BeTrue();
        sut.InsertFront(3).Should().BeTrue();
        sut.InsertFront(4).Should().BeFalse();
        Assert.That(sut.GetRear(), Is.EqualTo(2));
        sut.IsFull().Should().BeTrue();
        sut.DeleteLast().Should().BeTrue();
        sut.InsertFront(4).Should().BeTrue();
        Assert.That(sut.GetFront(), Is.EqualTo(4));
        sut.DeleteFront().Should().BeTrue();
        Assert.That(sut.GetFront(), Is.EqualTo(3));
    }
}
