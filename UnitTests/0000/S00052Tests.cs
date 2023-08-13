using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00052Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00052();
        sut.TotalNQueens(4).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00052();
        sut.TotalNQueens(1).Should().Be(1);
    }
}