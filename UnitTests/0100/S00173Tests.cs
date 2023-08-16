using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00173Tests
{
    [Test]
    public void T1()
    {
        var bstIterator = new S00173.BSTIterator(TreeNode.Parse("[7, 3, 15, null, null, 9, 20]"));
        bstIterator.Next().Should().Be(3);
        bstIterator.Next().Should().Be(7);
        bstIterator.HasNext().Should().BeTrue();
        bstIterator.Next().Should().Be(9);
        bstIterator.HasNext().Should().BeTrue();
        bstIterator.Next().Should().Be(15);
        bstIterator.HasNext().Should().BeTrue();
        bstIterator.Next().Should().Be(20);
        bstIterator.HasNext().Should().BeFalse();
    }

}