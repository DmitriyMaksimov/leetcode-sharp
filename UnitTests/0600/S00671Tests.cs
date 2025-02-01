using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00671Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00671();
        Assert.That(sut.FindSecondMinimumValue(TreeNode.Parse("[2,2,5,null,null,5,7]")), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S00671();
        Assert.That(sut.FindSecondMinimumValue(TreeNode.Parse("[2,2,2]")), Is.EqualTo(-1));
    }
}