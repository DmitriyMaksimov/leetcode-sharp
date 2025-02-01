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
        Assert.That(bstIterator.HasNext(), Is.True);
        Assert.That(bstIterator.Next(), Is.EqualTo(9));
        Assert.That(bstIterator.HasNext(), Is.True);
        Assert.That(bstIterator.Next(), Is.EqualTo(15));
        Assert.That(bstIterator.HasNext(), Is.True);
        Assert.That(bstIterator.Next(), Is.EqualTo(20));
        Assert.That(bstIterator.HasNext(), Is.False);
    }

}
