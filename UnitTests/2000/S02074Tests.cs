using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02074Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02074();
        Assert.That(sut.ReverseEvenLengthGroups(ListNode.Parse("[5,2,6,3,9,1,7,3,8,4]")).AsString(), Is.EqualTo("[5,6,2,3,9,1,4,8,3,7]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S02074();
        Assert.That(sut.ReverseEvenLengthGroups(ListNode.Parse("[1,1,0,6]")).AsString(), Is.EqualTo("[1,0,1,6]"));
    }

    [Test]
    public void T3()
    {
        var sut = new S02074();
        Assert.That(sut.ReverseEvenLengthGroups(ListNode.Parse("[1,1,0,6,5]")).AsString(), Is.EqualTo("[1,0,1,5,6]"));
    }
}
