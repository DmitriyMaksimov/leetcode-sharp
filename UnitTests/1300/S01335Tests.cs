using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01335Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01335();
        Assert.That(sut.MinDifficulty([6, 5, 4, 3, 2, 1], 2), Is.EqualTo(7));
    }

    [Test]
    public void T2()
    {
        var sut = new S01335();
        Assert.That(sut.MinDifficulty([9, 9, 9], 4), Is.EqualTo(-1));
    }

    [Test]
    public void T3()
    {
        var sut = new S01335();
        Assert.That(sut.MinDifficulty([1, 1, 1], 3), Is.EqualTo(3));
    }
}