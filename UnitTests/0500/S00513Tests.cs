using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00513Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00513();
        Assert.That(sut.FindBottomLeftValue(TreeNode.Parse("[2,1,3]")), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S00513();
        Assert.That(sut.FindBottomLeftValue(TreeNode.Parse("[1,2,3,4,null,5,6,null,null,7]")), Is.EqualTo(7));
    }
}