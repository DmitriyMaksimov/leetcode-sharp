using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01367Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01367();
        sut.IsSubPath(ListNode.Parse("[4,2,8]"), TreeNode.Parse("[1,4,4,null,2,2,null,1,null,6,8,null,null,null,null,1,3]")).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S01367();
        sut.IsSubPath(ListNode.Parse("[1,4,2,6]"), TreeNode.Parse("[1,4,4,null,2,2,null,1,null,6,8,null,null,null,null,1,3]")).Should().BeTrue();
    }

    [Test]
    public void T3()
    {
        var sut = new S01367();
        sut.IsSubPath(ListNode.Parse("[1,4,2,6,8]"), TreeNode.Parse("[1,4,4,null,2,2,null,1,null,6,8,null,null,null,null,1,3]")).Should().BeFalse();
    }
}
