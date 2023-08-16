using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00061Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00061();
        sut.RotateRight(ListNode.Parse("[1,2,3,4,5]"), 2).Should().BeEquivalentTo(ListNode.Parse("[4,5,1,2,3]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00061();
        sut.RotateRight(ListNode.Parse("[0,1,2]"), 4).Should().BeEquivalentTo(ListNode.Parse("[2,0,1]"));
    }
}