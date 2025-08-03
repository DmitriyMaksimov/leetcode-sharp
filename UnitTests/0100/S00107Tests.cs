using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00107Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00107();
        var list = sut.LevelOrderBottom(TreeNode.Parse("[3,9,20,null,null,15,7]"));
        Assert.That(list[0], Is.EqualTo((int[]) [15, 7]));
        Assert.That(list[1], Is.EqualTo((int[]) [9, 20]));
        Assert.That(list[2], Is.EqualTo((int[]) [3]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00107();
        Assert.That(sut.LevelOrderBottom(TreeNode.Parse("[1]")), Is.EquivalentTo([new[] {1}]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00107();
        Assert.That(sut.LevelOrderBottom(null), Is.Empty);
    }

    [Test]
    public void T4()
    {
        var sut = new S00107();
        var list = sut.LevelOrderBottom(TreeNode.Parse("[1,2,3,4,null,null,5]"));
        Assert.That(list[0], Is.EqualTo((int[]) [4, 5]));
        Assert.That(list[1], Is.EqualTo((int[]) [2, 3]));
        Assert.That(list[2], Is.EqualTo((int[]) [1]));
    }
}