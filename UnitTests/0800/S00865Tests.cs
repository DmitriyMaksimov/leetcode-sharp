using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00865Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00865();
        sut.SubtreeWithAllDeepest(TreeNode.Parse("[3,5,1,6,2,0,8,null,null,7,4]")).Should().BeEquivalentTo(TreeNode.Parse("[2,7,4]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00865();
        sut.SubtreeWithAllDeepest(TreeNode.Parse("[1]")).Should().BeEquivalentTo(TreeNode.Parse("[1]"));
    }

    [Test]
    public void T3()
    {
        var sut = new S00865();
        sut.SubtreeWithAllDeepest(TreeNode.Parse("[0,1,3,null,2]")).Should().BeEquivalentTo(TreeNode.Parse("[2]"));
    }
}
