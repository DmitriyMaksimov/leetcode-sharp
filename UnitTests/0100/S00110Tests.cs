using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00110Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00110();
        Assert.That(sut.IsBalanced(TreeNode.Parse("[3,9,20,null,null,15,7]")), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00110();
        Assert.That(sut.IsBalanced(TreeNode.Parse("[1,2,2,3,3,null,null,4,4]")), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S00110();
        Assert.That(sut.IsBalanced(null), Is.True);
    }
}
