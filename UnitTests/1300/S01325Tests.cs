using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01325Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01325();
        sut.RemoveLeafNodes(TreeNode.Parse("[1,2,3,2,null,2,4]"), 2).Should().BeEquivalentTo(TreeNode.Parse("[1,null,3,null,4]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01325();
        sut.RemoveLeafNodes(TreeNode.Parse("[1,3,3,3,2]"), 3).Should().BeEquivalentTo(TreeNode.Parse("[1,3,null,null,2]"));
    }

    [Test]
    public void T3()
    {
        var sut = new S01325();
        sut.RemoveLeafNodes(TreeNode.Parse("[1,2,null,2,null,2]"), 2).Should().BeEquivalentTo(TreeNode.Parse("[1]"));
    }
}