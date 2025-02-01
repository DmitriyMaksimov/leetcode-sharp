using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01334Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01334();
        Assert.That(sut.FindTheCity(4, [[0, 1, 3], [1, 2, 1], [1, 3, 4], [2, 3, 1]], 4), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01334();
        Assert.That(sut.FindTheCity(5, [[0, 1, 2], [0, 4, 8], [1, 2, 3], [1, 4, 2], [2, 3, 1], [3, 4, 1]], 2), Is.EqualTo(0));
    }
}