using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00501Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00501();
        sut.FindMode(TreeNode.Parse("[1,null,2,2]")).Should().BeEquivalentTo(new[] {2});
    }

    [Test]
    public void T2()
    {
        var sut = new S00501();
        sut.FindMode(TreeNode.Parse("[0]")).Should().BeEquivalentTo(new[] {0});
    }
}