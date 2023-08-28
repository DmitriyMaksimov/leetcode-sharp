using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00110Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00110();
        sut.IsBalanced(TreeNode.Parse("[3,9,20,null,null,15,7]")).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00110();
        sut.IsBalanced(TreeNode.Parse("[1,2,2,3,3,null,null,4,4]")).Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S00110();
        sut.IsBalanced(null).Should().BeTrue();
    }
}