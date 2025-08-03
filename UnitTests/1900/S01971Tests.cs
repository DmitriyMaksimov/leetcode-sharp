using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01971Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01971();
        Assert.That(sut.ValidPath(3, [[0, 1], [1, 2], [2, 0]], 0, 2), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01971();
        Assert.That(sut.ValidPath(6, [[0, 1], [0, 2], [3, 5], [5, 4], [4, 3]], 0, 5), Is.False);
    }
}
