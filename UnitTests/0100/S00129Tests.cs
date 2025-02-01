using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00129Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00129();
        Assert.That(sut.SumNumbers(TreeNode.Parse("[1,2,3]")), Is.EqualTo(25));
    }

    [Test]
    public void T2()
    {
        var sut = new S00129();
        Assert.That(sut.SumNumbers(TreeNode.Parse("[4,9,0,5,1]")), Is.EqualTo(1026));
    }

    [Test]
    public void T3()
    {
        var sut = new S00129();
        Assert.That(sut.SumNumbers(TreeNode.Parse("[1,null,5]")), Is.EqualTo(15));
    }
}