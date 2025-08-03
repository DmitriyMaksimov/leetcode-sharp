using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02316Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02316();
        Assert.That(sut.CountPairs(3, [[0, 1], [0, 2], [1, 2]]), Is.EqualTo(0));
    }

    [Test]
    public void T2()
    {
        var sut = new S02316();
        Assert.That(sut.CountPairs(7, [[0, 2], [0, 5], [2, 4], [1, 6], [5, 4]]), Is.EqualTo(14));
    }
}