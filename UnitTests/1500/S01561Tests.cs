using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01561Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01561();
        Assert.That(sut.MaxCoins(new[] {2, 4, 1, 2, 7, 8}), Is.EqualTo(9));
    }

    [Test]
    public void T2()
    {
        var sut = new S01561();
        Assert.That(sut.MaxCoins(new[] {2, 4, 5}), Is.EqualTo(4));
    }

    [Test]
    public void T3()
    {
        var sut = new S01561();
        Assert.That(sut.MaxCoins(new[] {9, 8, 7, 6, 5, 1, 2, 3, 4}), Is.EqualTo(18));
    }
}