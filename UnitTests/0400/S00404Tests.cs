using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00404Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00404();
        Assert.That(sut.SumOfLeftLeaves(null), Is.EqualTo(0));
    }

    [Test]
    public void T2()
    {
        var sut = new S00404();
        Assert.That(sut.SumOfLeftLeaves(TreeNode.Parse("[3,9,20,null,null,15,7]")), Is.EqualTo(24));
    }

    [Test]
    public void T3()
    {
        var sut = new S00404();
        Assert.That(sut.SumOfLeftLeaves(TreeNode.Parse("[1]")), Is.EqualTo(0));
    }

}