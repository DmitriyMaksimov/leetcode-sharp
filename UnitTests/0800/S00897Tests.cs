using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00897Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00897();
        Assert.That(sut.IncreasingBST(TreeNode.Parse("[5,3,6,2,4,null,8,1,null,null,null,7,9]")).AsString(), Is.EqualTo("[1,null,2,null,3,null,4,null,5,null,6,null,7,null,8,null,9]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00897();
        Assert.That(sut.IncreasingBST(TreeNode.Parse("[5,1,7]")).AsString(), Is.EqualTo("[1,null,5,null,7]"));
    }
}