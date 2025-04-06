using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03432Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03432();
        Assert.That(sut.CountPartitions([10, 10, 3, 7, 6]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S03432();
        Assert.That(sut.CountPartitions([1, 2, 2]), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S03432();
        Assert.That(sut.CountPartitions([2, 4, 6, 8]), Is.EqualTo(3));
    }
}
