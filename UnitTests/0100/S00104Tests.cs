using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00104Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00104();
        Assert.That(sut.MaxDepth(TreeNode.Parse("[3,9,20,null,null,15,7]")), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00104();
        Assert.That(sut.MaxDepth(TreeNode.Parse("[1,null,2]")), Is.EqualTo(2));
    }
}