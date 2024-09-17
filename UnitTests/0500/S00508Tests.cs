using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00508Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00508();
        sut.FindFrequentTreeSum(TreeNode.Parse("[5,2,-3]")).Should().Equal(2, -3, 4);
    }

    [Test]
    public void T2()
    {
        var sut = new S00508();
        sut.FindFrequentTreeSum(TreeNode.Parse("[5,2,-5]")).Should().Equal(2);
    }
}
