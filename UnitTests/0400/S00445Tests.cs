using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00445Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00445();
        Assert.That(sut.AddTwoNumbers(ListNode.Parse("[7,2,4,3]"), ListNode.Parse("[5,6,4]")).AsString(), Is.EqualTo("[7,8,0,7]"));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00445();
        Assert.That(sut.AddTwoNumbers(ListNode.Parse("[2,4,3]"), ListNode.Parse("[5,6,4]")).AsString(), Is.EqualTo("[8,0,7]"));
    }

    [Test]
    public void T3()
    {
        var sut = new S00445();
        Assert.That(sut.AddTwoNumbers(ListNode.Parse("[0]"), ListNode.Parse("[0]")).AsString(), Is.EqualTo("[0]"));
    }

    [Test]
    public void T4()
    {
        var sut = new S00445();
        Assert.That(sut.AddTwoNumbers(ListNode.Parse("[5]"), ListNode.Parse("[7]")).AsString(), Is.EqualTo("[1,2]"));
    }
}