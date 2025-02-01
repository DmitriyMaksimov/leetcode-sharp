using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00515Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00515();
        Assert.That(sut.LargestValues(TreeNode.Parse("[1,3,2,5,3,null,9]")), Is.EqualTo((int[]) [1, 3, 9]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00515();
        Assert.That(sut.LargestValues(TreeNode.Parse("[1,2,3]")), Is.EqualTo((int[]) [1, 3]));
    }
}