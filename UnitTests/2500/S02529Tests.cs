using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02529Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02529();
        Assert.That(sut.MaximumCount([-2, -1, -1, 1, 2, 3]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02529();
        Assert.That(sut.MaximumCount([-3, -2, -1, 0, 0, 1, 2]), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S02529();
        Assert.That(sut.MaximumCount([5, 20, 66, 1314]), Is.EqualTo(4));
    }
}