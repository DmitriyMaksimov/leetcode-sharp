using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00724Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00724();
        Assert.That(sut.PivotIndex([1, 7, 3, 6, 5, 6]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00724();
        Assert.That(sut.PivotIndex([1, 2, 3]), Is.EqualTo(-1));
    }

    [Test]
    public void T3()
    {
        var sut = new S00724();
        Assert.That(sut.PivotIndex([2, 1, -1]), Is.EqualTo(0));
    }
}