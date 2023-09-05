using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00965Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00965();
        sut.IsUnivalTree(TreeNode.Parse("[1,1,1,1,1,null,1]")).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00965();
        sut.IsUnivalTree(TreeNode.Parse("[2,2,2,5,2]")).Should().BeFalse();
    }
}