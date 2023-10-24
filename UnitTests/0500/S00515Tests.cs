using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00515Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00515();
        sut.LargestValues(TreeNode.Parse("[1,3,2,5,3,null,9]")).Should().Equal(1, 3, 9);
    }

    [Test]
    public void T2()
    {
        var sut = new S00515();
        sut.LargestValues(TreeNode.Parse("[1,2,3]")).Should().Equal(1, 3);
    }
}