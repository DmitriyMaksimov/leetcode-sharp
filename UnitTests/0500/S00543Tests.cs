using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00543Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00543();
        Assert.That(sut.DiameterOfBinaryTree(TreeNode.Parse("[1,2,3,4,5]")), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00543();
        Assert.That(sut.DiameterOfBinaryTree(TreeNode.Parse("[1,2]")), Is.EqualTo(1));
    }
}