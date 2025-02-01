using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00173Tests
{
    [Test]
    public void T1()
    {
        var bstIterator = new S00173.BSTIterator(TreeNode.Parse("[7, 3, 15, null, null, 9, 20]"));
        Assert.That(bstIterator.Next(), Is.EqualTo(3));
        Assert.That(bstIterator.Next(), Is.EqualTo(7));
        bstIterator.HasNext().Should().BeTrue();
        Assert.That(bstIterator.Next(), Is.EqualTo(9));
        bstIterator.HasNext().Should().BeTrue();
        Assert.That(bstIterator.Next(), Is.EqualTo(15));
        bstIterator.HasNext().Should().BeTrue();
        Assert.That(bstIterator.Next(), Is.EqualTo(20));
        bstIterator.HasNext().Should().BeFalse();
    }

}