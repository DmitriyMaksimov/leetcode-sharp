using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01022Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01022();
        sut.SumRootToLeaf(TreeNode.Parse("[1,0,1,0,1,0,1]")).Should().Be(22);
    }

    [Test]
    public void T2()
    {
        var sut = new S01022();
        sut.SumRootToLeaf(TreeNode.Parse("[0]")).Should().Be(0);
    }
}