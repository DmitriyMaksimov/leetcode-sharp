using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01615Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01615();
        Assert.That(sut.MaximalNetworkRank(4, [[0, 1], [0, 3], [1, 2], [1, 3]]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S01615();
        Assert.That(sut.MaximalNetworkRank(5,
            [[0, 1], [0, 3], [1, 2], [1, 3], [2, 3], [2, 4]]), Is.EqualTo(5));
    }

    [Test]
    public void T3()
    {
        var sut = new S01615();
        Assert.That(sut.MaximalNetworkRank(8,
            [[0, 1], [1, 2], [2, 3], [2, 4], [5, 6], [5, 7]]), Is.EqualTo(5));
    }
}