using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02807Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02807();
        sut.InsertGreatestCommonDivisors(ListNode.Parse("[18,6,10,3]")).Should()
            .BeEquivalentTo(ListNode.Parse("[18,6,6,2,10,1,3]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S02807();
        sut.InsertGreatestCommonDivisors(ListNode.Parse("[7]")).Should().BeEquivalentTo(ListNode.Parse("[7]"));
    }
}