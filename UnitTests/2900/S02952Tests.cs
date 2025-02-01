using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02952Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02952();
        Assert.That(sut.MinimumAddedCoins([1, 4, 10], 19), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02952();
        Assert.That(sut.MinimumAddedCoins([1, 4, 10, 5, 7, 19], 19), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S02952();
        Assert.That(sut.MinimumAddedCoins([1, 1, 1], 20), Is.EqualTo(3));
    }
}
