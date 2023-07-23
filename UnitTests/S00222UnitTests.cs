using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00222UnitTests
{
    [Test]
    public void Test1()
    {
        var sut = new S00222();
        var root = new S00222.TreeNode(1, new S00222.TreeNode(2, new S00222.TreeNode(4), new S00222.TreeNode(5)), new S00222.TreeNode(3, new S00222.TreeNode(6)));
        sut.CountNodes(root).Should().Be(6);
    }
    
    [Test]
    public void Test2()
    {
        var sut = new S00222();
        sut.CountNodes(null).Should().Be(0);
    }
    [Test]
    public void Test3()
    {
        var sut = new S00222();
        var root = new S00222.TreeNode(1);
        sut.CountNodes(root).Should().Be(1);
    }
}