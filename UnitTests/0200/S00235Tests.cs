using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00235Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00235();
        var root = TreeNode.Parse("[6,2,8,0,4,7,9,null,null,3,5]");
        var node1 = root!.left;
        var node2 = root.right;
        Assert.That(sut.LowestCommonAncestor(root, node1!, node2!).val, Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S00235();
        var root = TreeNode.Parse("[6,2,8,0,4,7,9,null,null,3,5]");
        var node1 = root!.left;
        var node2 = node1!.right;
        Assert.That(sut.LowestCommonAncestor(root, node1, node2!).val, Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S00235();
        var root = TreeNode.Parse("[2,1]");
        var node1 = root;
        var node2 = root!.left;
        Assert.That(sut.LowestCommonAncestor(root, node1!, node2!).val, Is.EqualTo(2));
    }
}