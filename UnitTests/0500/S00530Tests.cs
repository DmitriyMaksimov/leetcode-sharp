using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00530Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00530();
        sut.GetMinimumDifference(TreeNode.Parse("[4,2,6,1,3]")).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S00530();
        sut.GetMinimumDifference(TreeNode.Parse("[1,0,48,null,null,12,49]")).Should().Be(1);
    }
}