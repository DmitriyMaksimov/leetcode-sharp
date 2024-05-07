using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02816Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02816();
        sut.DoubleIt(ListNode.Parse("[1,8,9]")).Should().BeEquivalentTo(ListNode.Parse("[3,7,8]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S02816();
        sut.DoubleIt(ListNode.Parse("[9,9,9]")).Should().BeEquivalentTo(ListNode.Parse("[1,9,9,8]"));
    }
}