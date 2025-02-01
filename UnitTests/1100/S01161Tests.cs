using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01161Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01161();
        Assert.That(sut.MaxLevelSum(TreeNode.Parse("[1,7,0,7,-8,null,null]")), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01161();
        Assert.That(sut.MaxLevelSum(TreeNode.Parse("[989,null,10250,98693,-89388,null,null,null,-32127]")), Is.EqualTo(2));
    }
}