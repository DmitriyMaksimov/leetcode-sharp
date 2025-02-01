using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01448Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01448();
        Assert.That(sut.GoodNodes(TreeNode.Parse("[3,1,4,3,null,1,5]")!), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S01448();
        Assert.That(sut.GoodNodes(TreeNode.Parse("[3,3,null,4,2]")!), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S01448();
        Assert.That(sut.GoodNodes(TreeNode.Parse("[1]")!), Is.EqualTo(1));
    }
}