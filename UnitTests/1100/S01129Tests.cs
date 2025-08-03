using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01129Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01129();
        Assert.That(sut.ShortestAlternatingPaths(3, [[0, 1], [1, 2]], []), Is.EqualTo((int[]) [0, 1, -1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01129();
        Assert.That(sut.ShortestAlternatingPaths(3, [[0, 1]], [[2, 1]]), Is.EqualTo((int[]) [0, 1, -1]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01129();
        Assert.That(sut.ShortestAlternatingPaths(5, [[0, 1], [1,2], [2,3], [3,4]], [
            [1, 2], [2,3], [3,1]
        ]), Is.EqualTo((int[]) [0, 1, 2,3,7]));
    }
}