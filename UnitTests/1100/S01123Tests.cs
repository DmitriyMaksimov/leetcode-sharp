using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01123Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01123();
        Assert.That(sut.LcaDeepestLeaves(TreeNode.Parse("[3,5,1,6,2,0,8,null,null,7,4]"))?.val, Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01123();
        Assert.That(sut.LcaDeepestLeaves(TreeNode.Parse("[1]"))?.val, Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S01123();
        Assert.That(sut.LcaDeepestLeaves(TreeNode.Parse("[0,1,3,null,2]"))?.val, Is.EqualTo(2));
    }
}