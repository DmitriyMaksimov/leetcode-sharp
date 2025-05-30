using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03319Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03319();
        Assert.That(sut.KthLargestPerfectSubtree(TreeNode.Parse("[5,3,6,5,2,5,7,1,8,null,null,6,8]"), 2), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03319();
        Assert.That(sut.KthLargestPerfectSubtree(TreeNode.Parse("[1,2,3,4,5,6,7]"), 1), Is.EqualTo(7));
    }

    [Test]
    public void T3()
    {
        var sut = new S03319();
        Assert.That(sut.KthLargestPerfectSubtree(TreeNode.Parse("[1,2,3,null,4]"), 3), Is.EqualTo(-1));
    }
}
