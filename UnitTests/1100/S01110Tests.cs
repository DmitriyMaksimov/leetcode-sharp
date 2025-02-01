using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01110Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01110();
        var treeNodes = sut.DelNodes(TreeNode.Parse("[1,2,3,4,5,6,7]"),[3,5]);
        treeNodes.Should().HaveCount(3);
        Assert.That(treeNodes[0].AsString(), Is.EqualTo("[1,2,null,4]"));
        Assert.That(treeNodes[1].AsString(), Is.EqualTo("[6]"));
        Assert.That(treeNodes[2].AsString(), Is.EqualTo("[7]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01110();
        var treeNodes = sut.DelNodes(TreeNode.Parse("[1,2,4,null,3]"),[3]);
        treeNodes.Should().HaveCount(1);
        Assert.That(treeNodes[0].AsString(), Is.EqualTo("[1,2,4]"));
    }
}