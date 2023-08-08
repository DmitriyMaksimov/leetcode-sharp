using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00105Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00105();
        sut.BuildTree(new[] {3, 9, 20, 15, 7}, new[] {9, 3, 15, 20, 7}).Should()
            .BeEquivalentTo(TreeNode.Parse("[3,9,20,null,null,15,7]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00105();
        sut.BuildTree(new[] {-1}, new[] {-1}).Should().BeEquivalentTo(TreeNode.Parse("[-1]"));
    }
}