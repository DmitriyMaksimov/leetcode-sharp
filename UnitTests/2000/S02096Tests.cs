using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02096Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02096();
        Assert.That(sut.GetDirections(TreeNode.Parse("[5,1,2,3,null,6,4]")!, 3, 6), Is.EqualTo("UURL"));
    }

    [Test]
    public void T2()
    {
        var sut = new S02096();
        Assert.That(sut.GetDirections(TreeNode.Parse("[2,1]")!, 2, 1), Is.EqualTo("L"));
    }
}