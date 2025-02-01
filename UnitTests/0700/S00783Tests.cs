using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00783Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00783();
        Assert.That(sut.MinDiffInBST(TreeNode.Parse("[4,2,6,1,3]")), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S00783();
        Assert.That(sut.MinDiffInBST(TreeNode.Parse("[1,0,48,null,null,12,49]")), Is.EqualTo(1));
    }
}