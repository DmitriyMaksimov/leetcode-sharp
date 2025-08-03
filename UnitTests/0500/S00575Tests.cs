using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00575Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00575();
        Assert.That(sut.DistributeCandies([1, 1, 2, 2, 3, 3]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00575();
        Assert.That(sut.DistributeCandies([1, 1, 2, 3]), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S00575();
        Assert.That(sut.DistributeCandies([6, 6, 6, 6]), Is.EqualTo(1));
    }
}