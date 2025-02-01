using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00623Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00623();
        Assert.That(sut.AddOneRow(TreeNode.Parse("[4,2,6,3,1,5]"), 1, 2).AsString(), Is.EqualTo("[4,1,1,2,null,null,6,3,1,5]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00623();
        Assert.That(sut.AddOneRow(TreeNode.Parse("[4,2,null,3,1]"), 1, 3).AsString(), Is.EqualTo("[4,2,null,1,1,3,null,null,1]"));
    }
}