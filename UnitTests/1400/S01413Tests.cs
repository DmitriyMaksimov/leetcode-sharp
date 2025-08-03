using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01413Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01413();
        Assert.That(sut.MinStartValue([-3, 2, -3, 4, 2]), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S01413();
        Assert.That(sut.MinStartValue([1, 2]), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S01413();
        Assert.That(sut.MinStartValue([1, -2, -3]), Is.EqualTo(5));
    }
}