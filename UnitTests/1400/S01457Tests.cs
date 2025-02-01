using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01457Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01457();
        Assert.That(sut.PseudoPalindromicPaths(TreeNode.Parse("[2,3,1,3,1,null,1]")), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01457();
        Assert.That(sut.PseudoPalindromicPaths(TreeNode.Parse("[2,1,1,1,3,null,null,null,null,null,1]")), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S01457();
        Assert.That(sut.PseudoPalindromicPaths(TreeNode.Parse("[9]")), Is.EqualTo(1));
    }
}