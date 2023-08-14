using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00450Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00450();
        sut.DeleteNode(TreeNode.Parse("[5,3,6,2,4,null,7]"), 3).Should()
            .BeEquivalentTo(TreeNode.Parse("[5,4,6,2,null,null,7]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00450();
        sut.DeleteNode(TreeNode.Parse("[5,3,6,2,4,null,7]"), 0).Should()
            .BeEquivalentTo(TreeNode.Parse("[5,3,6,2,4,null,7]"));
    }

    [Test]
    public void T3()
    {
        var sut = new S00450();
        sut.DeleteNode(null, 0).Should().BeNull();
    }
}