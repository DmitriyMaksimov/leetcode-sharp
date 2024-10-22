using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02583Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02583();
        sut.KthLargestLevelSum(TreeNode.Parse("[5,8,9,2,1,3,7,4,6]"), 2).Should().Be(13);
    }

    [Test]
    public void T2()
    {
        var sut = new S02583();
        sut.KthLargestLevelSum(TreeNode.Parse("[1,2,null,3]"), 1).Should().Be(3);
    }
}
