using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00606Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00606();
        sut.Tree2str(TreeNode.Parse("[1,2,3,4]")).Should().Be("1(2(4))(3)");
    }

    [Test]
    public void T2()
    {
        var sut = new S00606();
        sut.Tree2str(TreeNode.Parse("[1,2,3,null,4]")).Should().Be("1(2()(4))(3)");
    }
}