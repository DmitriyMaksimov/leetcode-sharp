using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00222UnitTests
{
    [Test]
    public void Test1()
    {
        var sut = new S00222();
        var root = TreeNode.Parse("[1,2,3,4,5,6]");
        TreeNode.Print(root);
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
        var root = TreeNode.Parse("[1]");
        sut.CountNodes(root).Should().Be(1);
    }
}