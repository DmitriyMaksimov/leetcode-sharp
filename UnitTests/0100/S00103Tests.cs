using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00103Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00103();
        var list = sut.ZigzagLevelOrder(TreeNode.Parse("[3,9,20,null,null,15,7]"));
        Assert.That(list[0], Is.EqualTo((int[]) [3]));
        Assert.That(list[1], Is.EqualTo((int[]) [20, 9]));
        Assert.That(list[2], Is.EqualTo((int[]) [15, 7]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00103();
        Assert.That(sut.ZigzagLevelOrder(TreeNode.Parse("[1]")), Is.EquivalentTo(new[] {new[] {1}}));
    }

    [Test]
    public void T3()
    {
        var sut = new S00103();
        Assert.That(sut.ZigzagLevelOrder(null), Is.Empty);
    }

    [Test]
    public void T4()
    {
        var sut = new S00103();
        var list = sut.ZigzagLevelOrder(TreeNode.Parse("[1,2,3,4,null,null,5]"));
        Assert.That(list[0], Is.EqualTo((int[]) [1]));
        Assert.That(list[1], Is.EqualTo((int[]) [3, 2]));
        Assert.That(list[2], Is.EqualTo((int[]) [4, 5]));
    }
}