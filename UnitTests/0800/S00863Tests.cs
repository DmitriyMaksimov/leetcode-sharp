using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00863Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00863();
        var treeNode = TreeNode.Parse("[3,5,1,6,2,0,8,null,null,7,4]");
        var target = treeNode.left;
        sut.DistanceK(treeNode, target, 2).Should().Equal(7,4,1);
    }

    [Test]
    public void T2()
    {
        var sut = new S00863();
        var treeNode = TreeNode.Parse("[1]");
        var target = treeNode;
        sut.DistanceK(treeNode, target, 3).Should().Equal();
    }
}