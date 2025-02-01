using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00112Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00112();
        Assert.That(sut.HasPathSum(TreeNode.Parse("[5,4,8,11,null,13,4,7,2,null,null,null,1]"), 22), Is.True);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00112();
        Assert.That(sut.HasPathSum(TreeNode.Parse("[1,2,3]"), 5), Is.False);
    }
    
    [Test]
    public void T3()
    {
        var sut = new S00112();
        Assert.That(sut.HasPathSum(null, 0), Is.False);
    }
}
