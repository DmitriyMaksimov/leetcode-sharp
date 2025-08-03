using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01572Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01572();
        Assert.That(sut.DiagonalSum([[1, 2, 3], [4, 5, 6], [7, 8, 9]]), Is.EqualTo(25));
    }

    [Test]
    public void T2()
    {
        var sut = new S01572();
        Assert.That(sut.DiagonalSum([[1, 1, 1, 1], [1, 1, 1, 1], [1, 1, 1, 1], [1, 1, 1, 1]]), Is.EqualTo(8));
    }

    [Test]
    public void T3()
    {
        var sut = new S01572();
        Assert.That(sut.DiagonalSum([[5]]), Is.EqualTo(5));
    }
}