using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01022Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01022();
        Assert.That(sut.SumRootToLeaf(TreeNode.Parse("[1,0,1,0,1,0,1]")), Is.EqualTo(22));
    }

    [Test]
    public void T2()
    {
        var sut = new S01022();
        Assert.That(sut.SumRootToLeaf(TreeNode.Parse("[0]")), Is.EqualTo(0));
    }
}