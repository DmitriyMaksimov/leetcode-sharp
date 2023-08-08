using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00114Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00114();
        var root = TreeNode.Parse("[1,2,5,3,4,null,6]");
        sut.Flatten(root);
        root.Should().BeEquivalentTo(TreeNode.Parse("[1,null,2,null,3,null,4,null,5,null,6]"));
    }
}