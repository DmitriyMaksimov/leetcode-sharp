using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01379Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01379();
        var original = TreeNode.Parse("[7,4,3,null,null,6,19]");
        var clone = TreeNode.Parse("[7,4,3,null,null,6,19]");
        var targetOriginal = original!.right;
        var expected = clone!.right;
        var targetCopy = sut.GetTargetCopy(original, clone, targetOriginal!);
        Assert.That(targetCopy, Is.EqualTo(expected));
    }

    [Test]
    public void T2()
    {
        var sut = new S01379();
        var original = TreeNode.Parse("[7]");
        var clone = TreeNode.Parse("[7]");
        var targetOriginal = original;
        var expected = clone;
        var targetCopy = sut.GetTargetCopy(original, clone, targetOriginal!);
        Assert.That(targetCopy, Is.EqualTo(expected));
    }
    
    [Test]
    public void T3()
    {
        var sut = new S01379();
        var original = TreeNode.Parse("[8,null,6,null,5,null,4,null,3,null,2,null,1]");
        var clone = TreeNode.Parse("[8,null,6,null,5,null,4,null,3,null,2,null,1]");
        var targetOriginal = original!.right!.right!.right;
        var expected = clone!.right!.right!.right;
        var targetCopy = sut.GetTargetCopy(original, clone, targetOriginal!);
        Assert.That(targetCopy, Is.EqualTo(expected));
    }
}