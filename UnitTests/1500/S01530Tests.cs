using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01530Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01530();
        Assert.That(sut.CountPairs(TreeNode.Parse("[1,2,3,null,4]"), 3), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01530();
        Assert.That(sut.CountPairs(TreeNode.Parse("[1,2,3,4,5,6,7]"), 3), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S01530();
        Assert.That(sut.CountPairs(TreeNode.Parse("[7,1,4,6,null,5,3,null,null,null,null,null,2]"), 3), Is.EqualTo(1));
    }
}