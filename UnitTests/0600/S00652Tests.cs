using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00652Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00652();
        var treeNodes = sut.FindDuplicateSubtrees(TreeNode.Parse("[1,2,3,4,null,2,4,null,null,4]"));
        treeNodes.Should().HaveCount(2);
        treeNodes.Should().ContainEquivalentOf(TreeNode.Parse("[2,4]"));
        treeNodes.Should().ContainEquivalentOf(TreeNode.Parse("[4]"));
    }    

    [Test]
    public void T2()
    {
        var sut = new S00652();
        var treeNodes = sut.FindDuplicateSubtrees(TreeNode.Parse("[2,1,1]"));
        treeNodes.Should().HaveCount(1);
        treeNodes.Should().ContainEquivalentOf(TreeNode.Parse("[1]"));
    }    
}