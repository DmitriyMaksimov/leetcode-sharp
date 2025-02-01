using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00501Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00501();
        Assert.That(sut.FindMode(TreeNode.Parse("[1,null,2,2]")), Is.EquivalentTo(new[] {2}));
    }

    [Test]
    public void T2()
    {
        var sut = new S00501();
        Assert.That(sut.FindMode(TreeNode.Parse("[0]")), Is.EquivalentTo(new[] {0}));
    }
}