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
        list[0].Should().Equal(15, 7);
        list[1].Should().Equal(9, 20);
        list[2].Should().Equal(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00107();
        Assert.That(sut.LevelOrderBottom(TreeNode.Parse("[1]")), Is.EquivalentTo(new[] {new[] {1}}));
    }

    [Test]
    public void T3()
    {
        var sut = new S00107();
        sut.LevelOrderBottom(null).Should().BeEmpty();
    }

    [Test]
    public void T4()
    {
        var sut = new S00107();
        var list = sut.LevelOrderBottom(TreeNode.Parse("[1,2,3,4,null,null,5]"));
        list[0].Should().Equal(4, 5);
        list[1].Should().Equal(2, 3);
        list[2].Should().Equal(1);
    }
}