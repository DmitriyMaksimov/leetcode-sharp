using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00836Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00836();
        Assert.That(sut.IsRectangleOverlap([0, 0, 2, 2], [1, 1, 3, 3]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00836();
        Assert.That(sut.IsRectangleOverlap([0, 0, 1, 1], [1, 0, 2, 1]), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S00836();
        Assert.That(sut.IsRectangleOverlap([0, 0, 1, 1], [2, 2, 3, 3]), Is.False);
    }
}
