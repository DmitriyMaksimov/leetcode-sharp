using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00979Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00979();
        sut.DistributeCoins(TreeNode.Parse("[3,0,0]")).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00979();
        sut.DistributeCoins(TreeNode.Parse("[0,3,0]")).Should().Be(3);
    }
}