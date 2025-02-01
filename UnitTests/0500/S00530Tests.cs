using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00530Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00530();
        Assert.That(sut.GetMinimumDifference(TreeNode.Parse("[4,2,6,1,3]")), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S00530();
        Assert.That(sut.GetMinimumDifference(TreeNode.Parse("[1,0,48,null,null,12,49]")), Is.EqualTo(1));
    }
}