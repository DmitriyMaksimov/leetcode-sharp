using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03238Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03238();
        Assert.That(sut.WinningPlayerCount(4, [[0, 0], [1, 0], [1, 0], [2, 1], [2, 1], [2, 0]]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03238();
        Assert.That(sut.WinningPlayerCount(5, [[1, 1], [1, 2], [1, 3], [1, 4]]), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S03238();
        Assert.That(sut.WinningPlayerCount(5, [[1, 1], [2, 4], [2, 4], [2, 4]]), Is.EqualTo(1));
    }
}
