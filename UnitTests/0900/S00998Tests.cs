using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00998Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00998();
        Assert.That(sut.InsertIntoMaxTree(TreeNode.Parse("[4,1,3,null,null,2]"), 5).AsString(), Is.EqualTo("[5,4,null,1,3,null,null,2]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00998();
        Assert.That(sut.InsertIntoMaxTree(TreeNode.Parse("[5,2,4,null,1]"), 3).AsString(), Is.EqualTo("[5,2,4,null,1,null,3]"));
    }

    [Test]
    public void T3()
    {
        var sut = new S00998();
        Assert.That(sut.InsertIntoMaxTree(TreeNode.Parse("[5,2,3,null,1]"), 4).AsString(), Is.EqualTo("[5,2,4,null,1,3]"));
    }
}
