using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00919Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00919.CBTInserter(TreeNode.Parse("[1, 2]"));
        sut.Insert(3).Should().Be(1);
        sut.Insert(4).Should().Be(2);
        sut.Get_root().Should().BeEquivalentTo(TreeNode.Parse("[1, 2, 3, 4]"));
    }
}
