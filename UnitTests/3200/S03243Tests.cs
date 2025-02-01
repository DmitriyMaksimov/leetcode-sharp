using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03243Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03243();
        Assert.That(sut.ShortestDistanceAfterQueries(5, [[2, 4], [0, 2], [0, 4]]), Is.EqualTo((int[]) [3, 2, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03243();
        Assert.That(sut.ShortestDistanceAfterQueries(4, [[0, 3], [0, 2]]), Is.EqualTo((int[]) [1, 1]));
    }
}
