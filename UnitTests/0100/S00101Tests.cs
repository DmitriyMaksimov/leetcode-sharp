using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00101Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00101();
        Assert.That(sut.IsSymmetric(TreeNode.Parse("[1,2,2,3,4,4,3]")), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00101();
        Assert.That(sut.IsSymmetric(TreeNode.Parse("[1,2,2,null,3,null,3]")), Is.False);
    }
}
