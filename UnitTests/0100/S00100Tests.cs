using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00100Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00100();
        sut.IsSameTree(TreeNode.Parse("[1,2,3]"), TreeNode.Parse("[1,2,3]")).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00100();
        sut.IsSameTree(TreeNode.Parse("[1,2]"), TreeNode.Parse("[1,null,2]")).Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S00100();
        sut.IsSameTree(TreeNode.Parse("[1,2,1]"), TreeNode.Parse("[1,1,2]")).Should().BeFalse();
    }
}