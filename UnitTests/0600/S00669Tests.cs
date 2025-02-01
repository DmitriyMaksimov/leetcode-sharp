using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00669Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00669();
        Assert.That(sut.TrimBST(TreeNode.Parse("[1,0,2]"), 1, 2).AsString(), Is.EqualTo("[1,null,2]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00669();
        Assert.That(sut.TrimBST(TreeNode.Parse("[3,0,4,null,2,null,null,1]"), 1, 3).AsString(), Is.EqualTo("[3,2,null,1]"));
    }
}
