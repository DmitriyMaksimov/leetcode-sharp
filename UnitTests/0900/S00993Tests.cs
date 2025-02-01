using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00993Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00993();
        Assert.That(sut.IsCousins(TreeNode.Parse("[1,2,3,4]"), 4, 3), Is.False);
    }

    [Test]
    public void T2()
    {
        var sut = new S00993();
        Assert.That(sut.IsCousins(TreeNode.Parse("[1,2,3,null,4,null,5]"), 5, 4), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S00993();
        Assert.That(sut.IsCousins(TreeNode.Parse("[1,2,3,null,4]"), 2, 3), Is.False);
    }
}
