using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01110Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01110();
        var treeNodes = sut.DelNodes(TreeNode.Parse("[1,2,3,4,5,6,7]"),[3,5]);
        treeNodes.Should().HaveCount(3);
        treeNodes[0].Should().BeEquivalentTo(TreeNode.Parse("[1,2,null,4]"));
        treeNodes[1].Should().BeEquivalentTo(TreeNode.Parse("[6]"));
        treeNodes[2].Should().BeEquivalentTo(TreeNode.Parse("[7]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01110();
        var treeNodes = sut.DelNodes(TreeNode.Parse("[1,2,4,null,3]"),[3]);
        treeNodes.Should().HaveCount(1);
        treeNodes[0].Should().BeEquivalentTo(TreeNode.Parse("[1,2,4]"));
    }
}