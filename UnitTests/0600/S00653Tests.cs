using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00653Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00653();
        Assert.That(sut.FindTarget(TreeNode.Parse("[5,3,6,2,4,null,7]"), 9), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00653();
        Assert.That(sut.FindTarget(TreeNode.Parse("[5,3,6,2,4,null,7]"), 28), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S00653();
        Assert.That(sut.FindTarget(TreeNode.Parse("[1]"), 2), Is.False);
    }

    [Test]
    public void T4()
    {
        var sut = new S00653();
        Assert.That(sut.FindTarget(TreeNode.Parse("[2,null,3]"), 6), Is.False);
    }
}
