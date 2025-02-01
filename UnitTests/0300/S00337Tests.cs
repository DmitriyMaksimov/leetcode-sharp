using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00337Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00337();
        Assert.That(sut.Rob(TreeNode.Parse("[3,2,3,null,3,null,1]")), Is.EqualTo(7));
    }

    [Test]
    public void T2()
    {
        var sut = new S00337();
        Assert.That(sut.Rob(TreeNode.Parse("[3,4,5,1,3,null,1]")), Is.EqualTo(9));
    }
}
