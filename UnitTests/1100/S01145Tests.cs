using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01145Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01145();
        Assert.That(sut.BtreeGameWinningMove(TreeNode.Parse("[1,2,3,4,5,6,7,8,9,10,11]"), 11, 3), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01145();
        Assert.That(sut.BtreeGameWinningMove(TreeNode.Parse("[1,2,3]"), 3, 1), Is.False);
    }
}
