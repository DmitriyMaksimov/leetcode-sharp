using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00988Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00988();
        Assert.That(sut.SmallestFromLeaf(TreeNode.Parse("[0,1,2,3,4,3,4]")), Is.EqualTo("dba"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00988();
        Assert.That(sut.SmallestFromLeaf(TreeNode.Parse("[25,1,3,1,3,0,2]")), Is.EqualTo("adz"));
    }

    [Test]
    public void T3()
    {
        var sut = new S00988();
        Assert.That(sut.SmallestFromLeaf(TreeNode.Parse("[2,2,1,null,1,0,null,0]")), Is.EqualTo("abc"));
    }
}