using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00637Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00637();
        Assert.That(sut.AverageOfLevels(TreeNode.Parse("[3,9,20,null,null,15,7]")), Is.EqualTo((double[]) [3.0, 14.5, 11.0]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00637();
        Assert.That(sut.AverageOfLevels(TreeNode.Parse("[3,9,20,15,7]")), Is.EqualTo((double[]) [3.0, 14.5, 11.0]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00637();
        Assert.That(sut.AverageOfLevels(TreeNode.Parse("[2147483647,2147483647,2147483647]")), Is.EqualTo((double[]) [2147483647.0, 2147483647.0]));
    }
}
