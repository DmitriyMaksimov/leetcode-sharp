using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00226Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00226();
        sut.InvertTree(TreeNode.Parse("[4,2,7,1,3,6,9]")).Should().BeEquivalentTo(TreeNode.Parse("[4,7,2,9,6,3,1]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00226();
        sut.InvertTree(TreeNode.Parse("[2,1,3]")).Should().BeEquivalentTo(TreeNode.Parse("[2,3,1]"));
    }
}