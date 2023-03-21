using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00094Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00094();
        sut.InorderTraversal(TreeNode.Parse("[1,null,2,3]")).Should().Equal(1, 3, 2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00094();
        sut.InorderTraversal(null).Should().BeEmpty();
    }
    
    [Test]
    public void T3()
    {
        var sut = new S00094();
        sut.InorderTraversal(TreeNode.Parse("[1]")).Should().Equal(1);
    }
}