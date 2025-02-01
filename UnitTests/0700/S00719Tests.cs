using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00719Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00719();
        Assert.That(sut.SmallestDistancePair([1, 3, 1], 1), Is.EqualTo(0));
    }

    [Test]
    public void T2()
    {
        var sut = new S00719();
        Assert.That(sut.SmallestDistancePair([1, 1, 1], 2), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S00719();
        Assert.That(sut.SmallestDistancePair([1, 6, 1], 3), Is.EqualTo(5));
    }
}
