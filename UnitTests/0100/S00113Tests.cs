using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00113Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00113();
        Assert.That(sut.PathSum(TreeNode.Parse("[5,4,8,11,null,13,4,7,2,null,null,5,1]"), 22), Is.EquivalentTo((int[][]) [[5, 4, 11, 2], [5, 8, 4, 5]]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00113();
        Assert.That(sut.PathSum(TreeNode.Parse("[1,2,3]"), 5), Is.Empty);
    }

    [Test]
    public void T3()
    {
        var sut = new S00113();
        Assert.That(sut.PathSum(TreeNode.Parse("[1,2]"), 0), Is.Empty);
    }
}
