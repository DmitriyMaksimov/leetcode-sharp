using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02304Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02304();
        Assert.That(sut.MinPathCost([[5, 3], [4, 0], [2, 1]], [[9, 8], [1, 5], [10, 12], [18, 6], [2, 4], [14, 3]]), Is.EqualTo(17));
    }

    [Test]
    public void T2()
    {
        var sut = new S02304();
        Assert.That(sut.MinPathCost([[5, 1, 2], [4, 0, 3]], [[12, 10, 15], [20, 23, 8], [21, 7, 1], [8, 1, 13], [9, 10, 25], [5, 3, 2]]), Is.EqualTo(6));
    }
}
