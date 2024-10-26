using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02458Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02458();
        sut.TreeQueries(TreeNode.Parse("[1,3,4,2,null,6,5,null,null,null,null,null,7]"), [4]).Should().Equal(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02458();
        sut.TreeQueries(TreeNode.Parse("[5,8,9,2,1,3,7,4,6]"), [3, 2, 4, 8]).Should().Equal(3, 2, 3, 2);
    }
}
