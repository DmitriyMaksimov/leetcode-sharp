using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00965Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00965();
        Assert.That(sut.IsUnivalTree(TreeNode.Parse("[1,1,1,1,1,null,1]")), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00965();
        Assert.That(sut.IsUnivalTree(TreeNode.Parse("[2,2,2,5,2]")), Is.False);
    }
}
