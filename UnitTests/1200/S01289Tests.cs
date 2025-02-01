using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01289Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01289();
        Assert.That(sut.MinFallingPathSum([[1, 2, 3], [4, 5, 6], [7, 8, 9]]), Is.EqualTo(13));
    }

    [Test]
    public void T2()
    {
        var sut = new S01289();
        Assert.That(sut.MinFallingPathSum([[7]]), Is.EqualTo(7));
    }
}