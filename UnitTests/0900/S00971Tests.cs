using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00971Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00971();
        sut.FlipMatchVoyage(TreeNode.Parse("[1,2]"), [2, 1]).Should().Equal(-1);
    }

    [Test]
    public void T2()
    {
        var sut = new S00971();
        sut.FlipMatchVoyage(TreeNode.Parse("[1,2,3]"), [1, 3, 2]).Should().Equal(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S00971();
        sut.FlipMatchVoyage(TreeNode.Parse("[1,2,3]"), [1, 2, 3]).Should().Equal();
    }
}
