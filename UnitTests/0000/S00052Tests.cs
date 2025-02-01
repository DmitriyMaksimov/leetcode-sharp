using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00052Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00052();
        Assert.That(sut.TotalNQueens(4), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00052();
        Assert.That(sut.TotalNQueens(1), Is.EqualTo(1));
    }
}