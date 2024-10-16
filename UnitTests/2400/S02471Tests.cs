using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02471Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02471();
        sut.MinimumOperations(TreeNode.Parse("[1,4,3,7,6,8,5,null,null,null,null,9,null,10]")).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S02471();
        sut.MinimumOperations(TreeNode.Parse("[1,3,2,7,6,5,4]")).Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S02471();
        sut.MinimumOperations(TreeNode.Parse("[1,2,3,4,5,6]")).Should().Be(0);
    }
}
