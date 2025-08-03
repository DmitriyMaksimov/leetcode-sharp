using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00883Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00883();
        Assert.That(sut.ProjectionArea([[1, 2], [3, 4]]), Is.EqualTo(17));
    }

    [Test]
    public void T2()
    {
        var sut = new S00883();
        Assert.That(sut.ProjectionArea([[2]]), Is.EqualTo(5));
    }

    [Test]
    public void T3()
    {
        var sut = new S00883();
        Assert.That(sut.ProjectionArea([[1, 0], [0, 2]]), Is.EqualTo(8));
    }
}