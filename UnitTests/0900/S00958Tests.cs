using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00958Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00958();
        sut.IsCompleteTree(TreeNode.Parse("[1,2,3,4,5,6]")).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00958();
        sut.IsCompleteTree(TreeNode.Parse("[1,2,3,4,5,null,7]")).Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S00958();
        TreeNode.Print(TreeNode.Parse("[1,2,3,4,5,6,7,8,9,10,11,12,13,null,null,15]"));
        sut.IsCompleteTree(TreeNode.Parse("[1,2,3,4,5,6,7,8,9,10,11,12,13,null,null,15]")).Should().BeFalse();
    }
}