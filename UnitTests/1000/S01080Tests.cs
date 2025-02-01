using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01080Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01080();
        Assert.That(sut.SufficientSubset(TreeNode.Parse("[1,2,3,4,-99,-99,7,8,9,-99,-99,12,13,-99,14]"), 1).AsString(), Is.EqualTo("[1,2,3,4,null,null,7,8,9,null,14]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01080();
        Assert.That(sut.SufficientSubset(TreeNode.Parse("[5,4,8,11,null,17,4,7,1,null,null,5,3]"), 22).AsString(), Is.EqualTo("[5,4,8,11,null,17,4,7,null,null,null,5]"));
    }

    [Test]
    public void T3()
    {
        var sut = new S01080();
        Assert.That(sut.SufficientSubset(TreeNode.Parse("[1,2,-3,-5,null,4,null]"), -1).AsString(), Is.EqualTo("[1,null,-3,4]"));
    }
}
