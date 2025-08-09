using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02944))]
public class S02944Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02944();
        Assert.That(sut.MinimumCoins([3, 1, 2]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02944();
        Assert.That(sut.MinimumCoins([1, 10, 1, 1]), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S02944();
        Assert.That(sut.MinimumCoins([26, 18, 6, 12, 49, 7, 45, 45]), Is.EqualTo(39));
    }
}