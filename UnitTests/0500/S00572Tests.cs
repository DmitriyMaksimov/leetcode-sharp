using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00572Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00572();
        sut.IsSubtree(TreeNode.Parse("[3,4,5,1,2]"), TreeNode.Parse("[4,1,2]")).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00572();
        sut.IsSubtree(TreeNode.Parse("[3,4,5,1,2,null,null,null,null,0]"), TreeNode.Parse("[4,1,2]")).Should()
            .BeFalse();
    }
}