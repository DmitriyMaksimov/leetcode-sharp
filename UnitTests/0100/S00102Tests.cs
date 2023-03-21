using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00102Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00102();
        var list = sut.LevelOrder(TreeNode.Parse("[3,9,20,null,null,15,7]"));
        list[0].Should().Equal(3);
        list[1].Should().Equal(9, 20);
        list[2].Should().Equal(15, 7);
    }

    [Test]
    public void T2()
    {
        var sut = new S00102();
        sut.LevelOrder(TreeNode.Parse("[1]")).Should().BeEquivalentTo(new[] {new[] {1}});
    }

    [Test]
    public void T3()
    {
        var sut = new S00102();
        sut.LevelOrder(null).Should().BeEmpty();
    }

    [Test]
    public void T4()
    {
        var sut = new S00102();
        var list = sut.LevelOrder(TreeNode.Parse("[1,2,3,4,null,null,5]"));
        list[0].Should().Equal(1);
        list[1].Should().Equal(2, 3);
        list[2].Should().Equal(4, 5);
    }
}