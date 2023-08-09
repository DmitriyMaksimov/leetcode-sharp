using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00236Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00236();
        var root = TreeNode.Parse("[3,5,1,6,2,0,8,null,null,7,4]");
        var node5 = root?.left;
        var node1 = root?.right;
        sut.LowestCommonAncestor(root, node5, node1).Should().Be(root);
    }

    [Test]
    public void T2()
    {
        var sut = new S00236();
        var root = TreeNode.Parse("[3,5,1,6,2,0,8,null,null,7,4]");
        var node5 = root?.left;
        var node4 = root?.left?.right?.right;
        sut.LowestCommonAncestor(root, node5, node4).Should().Be(node5);
    }

    [Test]
    public void T3()
    {
        var sut = new S00236();
        var root = TreeNode.Parse("[1,2]");
        var node1 = root;
        var node2 = root?.left;
        sut.LowestCommonAncestor(root, node1, node2).Should().Be(node1);
    }
}