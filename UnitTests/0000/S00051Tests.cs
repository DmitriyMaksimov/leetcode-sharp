using leetcode_sharp._0000;

namespace UnitTests;

[TestFixture]
public class S00051Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00051();
        sut.SolveNQueens(4).Should().BeEquivalentTo(new[]{new List<string> {".Q..", "...Q", "Q...", "..Q."},
            new List<string> {"..Q.", "Q...", "...Q", ".Q.."}});
    }

    [Test]
    public void T2()
    {
        var sut = new S00051();
        sut.SolveNQueens(1).Should().BeEquivalentTo(new[]{new List<string> {"Q"}});
    }
}