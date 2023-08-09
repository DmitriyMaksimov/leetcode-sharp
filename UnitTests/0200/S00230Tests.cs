using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00230Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00230();
        sut.KthSmallest(TreeNode.Parse("[3,1,4,null,2]"), 1).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S00230();
        sut.KthSmallest(TreeNode.Parse("[5,3,6,2,4,null,null,1]"), 3).Should().Be(3);
    }
}