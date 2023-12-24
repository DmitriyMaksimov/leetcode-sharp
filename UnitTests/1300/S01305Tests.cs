using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01305Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01305();
        sut.GetAllElements(TreeNode.Parse("[2,1,4]"), TreeNode.Parse("[1,0,3]")).Should().Equal(0, 1, 1, 2, 3, 4);
    }

    [Test]
    public void T2()
    {
        var sut = new S01305();
        sut.GetAllElements(TreeNode.Parse("[1,null,8]"), TreeNode.Parse("[8,1]")).Should().Equal(1, 1, 8, 8);
    }
}