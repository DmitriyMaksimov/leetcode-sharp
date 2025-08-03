using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00892Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00892();
        Assert.That(sut.SurfaceArea([[1, 2], [3, 4]]), Is.EqualTo(34));
    }

    [Test]
    public void T2()
    {
        var sut = new S00892();
        Assert.That(sut.SurfaceArea([[1, 1, 1], [1, 0, 1], [1, 1, 1]]), Is.EqualTo(32));
    }

    [Test]
    public void T3()
    {
        var sut = new S00892();
        Assert.That(sut.SurfaceArea([[2, 2, 2], [2, 1, 2], [2, 2, 2]]), Is.EqualTo(46));
    }
}