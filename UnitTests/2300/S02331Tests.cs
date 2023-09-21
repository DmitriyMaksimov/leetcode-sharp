using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02331Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02331();
        sut.EvaluateTree(TreeNode.Parse("[2,1,3,null,null,0,1]")!).Should().BeTrue();
    }
    [Test]
    public void T3()
    {
        var sut = new S02331();
        sut.EvaluateTree(TreeNode.Parse("[0]")!).Should().BeFalse();
    }

}