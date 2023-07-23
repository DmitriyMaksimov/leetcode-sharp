using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01026Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01026();
        var root = TreeNode.Parse("[1,null,2,null,0,3]");
        sut.MaxAncestorDiff(root).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01026();
        var root = TreeNode.Parse("[8,3,10,1,6,null,14,null,null,4,7,13]");
        sut.MaxAncestorDiff(root).Should().Be(7);
    }
}