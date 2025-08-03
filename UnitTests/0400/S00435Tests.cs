using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00435Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00435();
        Assert.That(sut.EraseOverlapIntervals([[1, 2], [2, 3], [3, 4], [1, 3]]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S00435();
        Assert.That(sut.EraseOverlapIntervals([[1, 2], [1, 2], [1, 2]]), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S00435();
        Assert.That(sut.EraseOverlapIntervals([[1, 2], [2, 3]]), Is.EqualTo(0));
    }
}