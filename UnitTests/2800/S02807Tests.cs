using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02807Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02807();
        Assert.That(sut.InsertGreatestCommonDivisors(ListNode.Parse("[18,6,10,3]")).AsString(), Is.EqualTo("[18,6,6,2,10,1,3]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S02807();
        Assert.That(sut.InsertGreatestCommonDivisors(ListNode.Parse("[7]")).AsString(), Is.EqualTo("[7]"));
    }
}