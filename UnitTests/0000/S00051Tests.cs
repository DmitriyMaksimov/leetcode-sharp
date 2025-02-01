using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00051Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00051();
        Assert.That(sut.SolveNQueens(4), Is.EquivalentTo(new[]{new List<string> {".Q..", "...Q", "Q...", "..Q."},
            new List<string> {"..Q.", "Q...", "...Q", ".Q.."}}));
    }

    [Test]
    public void T2()
    {
        var sut = new S00051();
        Assert.That(sut.SolveNQueens(1), Is.EquivalentTo(new[]{new List<string> {"Q"}}));
    }
}