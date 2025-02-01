using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00951Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00951();
        Assert.That(sut.FlipEquiv(TreeNode.Parse("[1,2,3,4,5,6,null,null,null,7,8]"), TreeNode.Parse("[1,3,2,null,6,4,5,null,null,null,null,8,7]")), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00951();
        Assert.That(sut.FlipEquiv(TreeNode.Parse("[]"), TreeNode.Parse("[]")), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S00951();
        Assert.That(sut.FlipEquiv(TreeNode.Parse("[]"), TreeNode.Parse("[1]")), Is.False);
    }
}
