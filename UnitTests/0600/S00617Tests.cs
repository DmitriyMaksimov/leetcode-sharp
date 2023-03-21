using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00617Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00617();
        sut.MergeTrees(TreeNode.Parse("[1,3,2,5]"), TreeNode.Parse("[2,1,3,null,4,null,7]")).Should().BeEquivalentTo(TreeNode.Parse("[3,4,5,5,4,null,7]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00617();
        sut.MergeTrees(TreeNode.Parse("[1]"), TreeNode.Parse("[1,2]")).Should().BeEquivalentTo(TreeNode.Parse("[2,2]"));
    }
}