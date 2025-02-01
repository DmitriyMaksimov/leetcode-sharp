using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00206Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00206();
        Assert.That(sut.ReverseList(ListNode.Parse("[1,2,3,4,5]")).AsString(), Is.EqualTo("[5,4,3,2,1]"));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00206();
        Assert.That(sut.ReverseList(ListNode.Parse("[1,2]")).AsString(), Is.EqualTo("[2,1]"));
    }

    [Test]
    public void T3()
    {
        var sut = new S00206();
        Assert.That(sut.ReverseList(ListNode.Parse("[]")).AsString(), Is.EqualTo("[]"));
    }
}