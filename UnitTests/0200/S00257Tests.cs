using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00257Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00257();
        Assert.That(sut.BinaryTreePaths(TreeNode.Parse("[1,2,3,null,5]")), Is.EqualTo((string[]) ["1->2->5", "1->3"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00257();
        Assert.That(sut.BinaryTreePaths(TreeNode.Parse("[1]")), Is.EqualTo((string[]) ["1"]));
    }
}
