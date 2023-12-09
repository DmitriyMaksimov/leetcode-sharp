using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00654Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00654();
        sut.ConstructMaximumBinaryTree(new[] { 3,2,1,6,0,5}).Should().BeEquivalentTo(TreeNode.Parse("[6,3,5,null,2,0,null,null,1]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00654();
        sut.ConstructMaximumBinaryTree(new[] {3,2,1 }).Should().BeEquivalentTo(TreeNode.Parse("[3,null,2,null,1]"));
    }
}