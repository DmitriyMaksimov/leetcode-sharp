using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01975Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01975();
        Assert.That(sut.MaxMatrixSum([[1, -1], [-1, 1]]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S01975();
        Assert.That(sut.MaxMatrixSum([[1, 2, 3], [-1, -2, -3], [1, 2, 3]]), Is.EqualTo(16));
    }
}
