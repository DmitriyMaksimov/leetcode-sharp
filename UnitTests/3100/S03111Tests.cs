using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03111Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03111();
        Assert.That(sut.MinRectanglesToCoverPoints([[2, 1], [1, 0], [1, 4], [1, 8], [3, 5], [4, 6]], 1), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03111();
        Assert.That(sut.MinRectanglesToCoverPoints([[0, 0], [1, 1], [2, 2], [3, 3], [4, 4], [5, 5], [6, 6]], 2), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S03111();
        Assert.That(sut.MinRectanglesToCoverPoints([[2, 3], [1, 2]], 0), Is.EqualTo(2));
    }
}
