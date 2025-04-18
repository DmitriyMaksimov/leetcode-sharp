using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00814Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00814();
        Assert.That(sut.PruneTree(TreeNode.Parse("[1,null,0,0,1]")).AsString(), Is.EqualTo("[1,null,0,null,1]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00814();
        Assert.That(sut.PruneTree(TreeNode.Parse("[1,0,1,0,0,0,1]")).AsString(), Is.EqualTo("[1,null,1,null,1]"));
    }

    [Test]
    public void T3()
    {
        var sut = new S00814();
        Assert.That(sut.PruneTree(TreeNode.Parse("[1,1,0,1,1,0,1,0]")).AsString(), Is.EqualTo("[1,1,0,1,1,null,1]"));
    }
}