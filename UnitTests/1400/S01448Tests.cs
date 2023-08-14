using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01448Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01448();
        sut.GoodNodes(TreeNode.Parse("[3,1,4,3,null,1,5]")!).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S01448();
        sut.GoodNodes(TreeNode.Parse("[3,3,null,4,2]")!).Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S01448();
        sut.GoodNodes(TreeNode.Parse("[1]")!).Should().Be(1);
    }
}