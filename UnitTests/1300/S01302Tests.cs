using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01302Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01302();
        sut.DeepestLeavesSum(TreeNode.Parse("[1,2,3,4,5,null,6,7,null,null,null,null,8]")).Should().Be(15);
    }

    [Test]
    public void T2()
    {
        var sut = new S01302();
        sut.DeepestLeavesSum(TreeNode.Parse("[6,7,8,2,7,1,3,9,null,1,4,null,null,null,5]")).Should().Be(19);
    }
}