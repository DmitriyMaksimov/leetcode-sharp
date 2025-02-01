using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00144Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00144();
        Assert.That(sut.PreorderTraversal(TreeNode.Parse("[1,null,2,3]")), Is.EqualTo((int[]) [1, 2, 3]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00144();
        Assert.That(sut.PreorderTraversal(null), Is.Empty);
    }

    [Test]
    public void T3()
    {
        var sut = new S00144();
        Assert.That(sut.PreorderTraversal(TreeNode.Parse("[1]")), Is.EqualTo((int[]) [1]));
    }
}