using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01779Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01779();
        Assert.That(sut.NearestValidPoint(3, 4, [[1, 2], [3, 1], [2, 4], [2, 3], [4, 4]]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01779();
        Assert.That(sut.NearestValidPoint(3, 4, [[3, 4]]), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S01779();
        Assert.That(sut.NearestValidPoint(3, 4, [[2, 3]]), Is.EqualTo(-1));
    }
}