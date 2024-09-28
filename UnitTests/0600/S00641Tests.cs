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
        sut.GetRear().Should().Be(2);
        sut.IsFull().Should().BeTrue();
        sut.DeleteLast().Should().BeTrue();
        sut.InsertFront(4).Should().BeTrue();
        sut.GetFront().Should().Be(4);
        sut.DeleteFront().Should().BeTrue();
        sut.GetFront().Should().Be(3);
    }
}
