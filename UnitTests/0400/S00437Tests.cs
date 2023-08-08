using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00437Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00437();
        sut.PathSum(TreeNode.Parse("[10,5,-3,3,2,null,11,3,-2,null,1]"), 8).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00437();
        sut.PathSum(TreeNode.Parse("[5,4,8,11,null,13,4,7,2,null,null,5,1]"), 22).Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S00437();
        sut.PathSum(TreeNode.Parse("[1000000000,1000000000,null,294967296,null,1000000000,null,1000000000,null,1000000000]"), 0).Should().Be(0);
    }
}