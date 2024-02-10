using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01261Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01261.FindElements(TreeNode.Parse("[-1,null,-1]"));
        sut.Find(1).Should().BeFalse();
        sut.Find(2).Should().BeTrue();
    }
    [Test]
    public void T2()
    {
        var sut = new S01261.FindElements(TreeNode.Parse("[-1,-1,-1,-1,-1]"));
        sut.Find(1).Should().BeTrue();
        sut.Find(3).Should().BeTrue();
        sut.Find(5).Should().BeFalse();
    }
    [Test]
    public void T3()
    {
        var sut = new S01261.FindElements(TreeNode.Parse("[-1,null,-1,-1,null,-1]"));
        sut.Find(2).Should().BeTrue();
        sut.Find(3).Should().BeFalse();
        sut.Find(4).Should().BeFalse();
        sut.Find(5).Should().BeTrue();
    }
}