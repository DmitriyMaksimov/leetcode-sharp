using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01609Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01609();
        Assert.That(sut.IsEvenOddTree(TreeNode.Parse("[1,10,4,3,null,7,9,12,8,6,null,null,2]")), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01609();
        Assert.That(sut.IsEvenOddTree(TreeNode.Parse("[5,4,2,3,3,7]")), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S01609();
        Assert.That(sut.IsEvenOddTree(TreeNode.Parse("[5,9,1,3,5,7]")), Is.False);
    }
}
