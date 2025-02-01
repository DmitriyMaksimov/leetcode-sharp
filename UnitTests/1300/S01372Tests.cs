using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01372Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01372();
        Assert.That(sut.LongestZigZag(TreeNode.Parse("[1,null,1,1,1,null,null,1,1,null,1,null,null,null,1,null,1]")), Is.EqualTo(3));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01372();
        Assert.That(sut.LongestZigZag(TreeNode.Parse("[1,1,1,null,1,null,null,1,1,null,1]")), Is.EqualTo(4));
    }

    [Test]
    public void T3()
    {
        var sut = new S01372();
        Assert.That(sut.LongestZigZag(TreeNode.Parse("[1]")), Is.EqualTo(0));
    }
}