using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00002Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00002();
        Assert.That(sut.AddTwoNumbers(ListNode.Parse("[2,4,3]"), ListNode.Parse("[5,6,4]")).AsString(), Is.EqualTo("[7,0,8]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00002();
        Assert.That(sut.AddTwoNumbers(ListNode.Parse("[0]"), ListNode.Parse("[0]")).AsString(), Is.EqualTo("[0]"));
    }

    [Test]
    public void T3()
    {
        var sut = new S00002();
        Assert.That(sut.AddTwoNumbers(ListNode.Parse("[9,9,9,9,9,9,9]"), ListNode.Parse("[9,9,9,9]")).AsString(), Is.EqualTo("[8,9,9,9,0,0,0,1]"));
    }
}
