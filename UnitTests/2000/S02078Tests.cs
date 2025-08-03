using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02078Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02078();
        Assert.That(sut.MaxDistance([1, 1, 1, 6, 1, 1, 1]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02078();
        Assert.That(sut.MaxDistance([1, 8, 3, 8, 3]), Is.EqualTo(4));
    }

    [Test]
    public void T3()
    {
        var sut = new S02078();
        Assert.That(sut.MaxDistance([0, 1]), Is.EqualTo(1));
    }
}