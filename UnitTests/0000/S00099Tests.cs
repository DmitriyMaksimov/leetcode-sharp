using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00099Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00099();
        var treeNode = TreeNode.Parse("[1,3,null,null,2]");
        sut.RecoverTree(treeNode);
        Assert.That(treeNode.AsString(), Is.EqualTo("[3,1,null,null,2]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00099();
        var treeNode = TreeNode.Parse("[3,1,4,null,null,2]");
        sut.RecoverTree(treeNode);
        Assert.That(treeNode.AsString(), Is.EqualTo("[2,1,4,null,null,3]"));
    }
}
