using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00095Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00095();
        var trees = sut.GenerateTrees(3);
        trees.Should().HaveCount(5);
        trees.Should().ContainEquivalentOf(TreeNode.Parse("[1,null,2,null,3]"));
        trees.Should().ContainEquivalentOf(TreeNode.Parse("[1,null,3,2]"));
        trees.Should().ContainEquivalentOf(TreeNode.Parse("[2,1,3]"));
        trees.Should().ContainEquivalentOf(TreeNode.Parse("[3,1,null,null,2]"));
        trees.Should().ContainEquivalentOf(TreeNode.Parse("[3,2,null,1]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00095();
        var trees = sut.GenerateTrees(1);
        trees.Should().HaveCount(1);
        trees.Should().ContainEquivalentOf(TreeNode.Parse("[1]"));
    }

}