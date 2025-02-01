using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01325Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01325();
        Assert.That(sut.RemoveLeafNodes(TreeNode.Parse("[1,2,3,2,null,2,4]"), 2).AsString(), Is.EqualTo("[1,null,3,null,4]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01325();
        Assert.That(sut.RemoveLeafNodes(TreeNode.Parse("[1,3,3,3,2]"), 3).AsString(), Is.EqualTo("[1,3,null,null,2]"));
    }

    [Test]
    public void T3()
    {
        var sut = new S01325();
        Assert.That(sut.RemoveLeafNodes(TreeNode.Parse("[1,2,null,2,null,2]"), 2).AsString(), Is.EqualTo("[1]"));
    }
}