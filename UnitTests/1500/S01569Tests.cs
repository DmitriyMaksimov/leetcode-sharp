using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01569Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01569();
        Assert.That(sut.NumOfWays(new[] {2, 1, 3}), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01569();
        Assert.That(sut.NumOfWays(new[] {3, 4, 5, 1, 2}), Is.EqualTo(5));
    }

    [Test]
    public void T3()
    {
        var sut = new S01569();
        Assert.That(sut.NumOfWays(new[] {1, 2, 3}), Is.EqualTo(0));
    }
}