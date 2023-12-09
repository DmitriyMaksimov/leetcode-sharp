using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01315Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01315();
        sut.SumEvenGrandparent(TreeNode.Parse("[6,7,8,2,7,1,3,9,null,1,4,null,null,null,5]")).Should().Be(18);
    }

    [Test]
    public void T2()
    {
        var sut = new S01315();
        sut.SumEvenGrandparent(TreeNode.Parse("[1]")).Should().Be(0);
    }
}