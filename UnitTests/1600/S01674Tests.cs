using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01674))]
public class S01674Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01674();
        Assert.That(sut.MinMoves([1, 2, 4, 3], 4), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01674();
        Assert.That(sut.MinMoves([1, 2, 2, 1], 2), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S01674();
        Assert.That(sut.MinMoves([1, 2, 1, 2], 2), Is.Zero);
    }
}