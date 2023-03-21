using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00206Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00206();
        sut.ReverseList(ListNode.Parse("[1,2,3,4,5]")).Should().BeEquivalentTo(ListNode.Parse("[5,4,3,2,1]"));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00206();
        sut.ReverseList(ListNode.Parse("[1,2]")).Should().BeEquivalentTo(ListNode.Parse("[2,1]"));
    }

    [Test]
    public void T3()
    {
        var sut = new S00206();
        sut.ReverseList(ListNode.Parse("[]")).Should().BeEquivalentTo(ListNode.Parse("[]"));
    }
}