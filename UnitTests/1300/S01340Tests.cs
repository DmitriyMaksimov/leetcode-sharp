using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01340))]
public class S01340Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01340();
        Assert.That(sut.MaxJumps([6, 4, 14, 6, 8, 13, 9, 7, 10, 6, 12], 2), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S01340();
        Assert.That(sut.MaxJumps([3, 3, 3, 3, 3], 3), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S01340();
        Assert.That(sut.MaxJumps([7, 6, 5, 4, 3, 2, 1], 1), Is.EqualTo(7));
    }
}