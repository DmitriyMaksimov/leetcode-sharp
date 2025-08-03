using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01261Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01261.FindElements(TreeNode.Parse("[-1,null,-1]"));
        Assert.That(sut.Find(1), Is.False);
        Assert.That(sut.Find(2), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01261.FindElements(TreeNode.Parse("[-1,-1,-1,-1,-1]"));
        Assert.That(sut.Find(1), Is.True);
        Assert.That(sut.Find(3), Is.True);
        Assert.That(sut.Find(5), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S01261.FindElements(TreeNode.Parse("[-1,null,-1,-1,null,-1]"));
        Assert.That(sut.Find(2), Is.True);
        Assert.That(sut.Find(3), Is.False);
        Assert.That(sut.Find(4), Is.False);
        Assert.That(sut.Find(5), Is.True);
    }
}