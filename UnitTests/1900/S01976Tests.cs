using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01976Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01976();
        Assert.That(sut.CountPaths(7, [[0, 6, 7], [0, 1, 2], [1, 2, 3], [1, 3, 3], [6, 3, 3], [3, 5, 1], [6, 5, 1], [2, 5, 1], [0, 4, 5], [4, 6, 2]]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S01976();
        Assert.That(sut.CountPaths(2, [[1, 0, 10]]), Is.EqualTo(1));
    }
}
