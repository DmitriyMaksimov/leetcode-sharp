using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01470Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01470();
        Assert.That(sut.Shuffle([2, 5, 1, 3, 4, 7], 3), Is.EqualTo((int[]) [2, 3, 5, 4, 1, 7]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01470();
        Assert.That(sut.Shuffle([1, 2, 3, 4, 4, 3, 2, 1], 4), Is.EqualTo((int[]) [1, 4, 2, 3, 3, 2, 4, 1]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01470();
        Assert.That(sut.Shuffle([1, 1, 2, 2], 2), Is.EqualTo((int[]) [1, 2, 1, 2]));
    }
}