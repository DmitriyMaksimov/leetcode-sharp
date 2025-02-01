using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00701Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00701();
        Assert.That(sut.InsertIntoBST(TreeNode.Parse("[4,2,7,1,3]"), 5).AsString(), Is.EqualTo("[4,2,7,1,3,5]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00701();
        Assert.That(sut.InsertIntoBST(TreeNode.Parse("[40,20,60,10,30,50,70]"), 25).AsString(), Is.EqualTo("[40,20,60,10,30,50,70,null,null,25]"));
    }

    [Test]
    public void T3()
    {
        var sut = new S00701();
        Assert.That(sut.InsertIntoBST(TreeNode.Parse("[4,2,7,1,3,null,null,null,null,null,null]"), 5).AsString(), Is.EqualTo("[4,2,7,1,3,5]"));
    }
}