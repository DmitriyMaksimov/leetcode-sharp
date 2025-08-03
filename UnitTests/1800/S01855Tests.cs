using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01855Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01855();
        Assert.That(sut.MaxDistance([55, 30, 5, 4, 2], [100, 20, 10, 10, 5]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01855();
        Assert.That(sut.MaxDistance([2, 2, 2], [10, 10, 1]), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S01855();
        Assert.That(sut.MaxDistance([30, 29, 19, 5], [25, 25, 25, 25, 25]), Is.EqualTo(2));
    }
}