using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00145Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00145();
        sut.PostorderTraversal(TreeNode.Parse("[1,null,2,3]")).Should().Equal(3, 2, 1);
    }

    [Test]
    public void T2()
    {
        var sut = new S00145();
        sut.PostorderTraversal(null).Should().BeEmpty();
    }
    
    [Test]
    public void T3()
    {
        var sut = new S00145();
        sut.PostorderTraversal(TreeNode.Parse("[1]")).Should().Equal(1);
    }
}