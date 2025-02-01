using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00222Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S00222();
        var root = TreeNode.Parse("[1,2,3,4,5,6]");
        TreeNode.Print(root);
        Assert.That(sut.CountNodes(root), Is.EqualTo(6));
    }
    
    [Test]
    public void Test2()
    {
        var sut = new S00222();
        Assert.That(sut.CountNodes(null), Is.EqualTo(0));
    }
    [Test]
    public void Test3()
    {
        var sut = new S00222();
        var root = TreeNode.Parse("[1]");
        Assert.That(sut.CountNodes(root), Is.EqualTo(1));
    }
}