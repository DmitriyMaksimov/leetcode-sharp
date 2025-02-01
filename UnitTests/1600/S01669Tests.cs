using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01669Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01669();
        Assert.That(sut.MergeInBetween(ListNode.Parse("[10,1,13,6,9,5]"), 3, 4, ListNode.Parse("[1000000,1000001,1000002]")).AsString(), Is.EqualTo("[10,1,13,1000000,1000001,1000002,5]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01669();
        Assert.That(sut.MergeInBetween(ListNode.Parse("[0,1,2,3,4,5,6]"), 2, 5,
                ListNode.Parse("[1000000,1000001,1000002,1000003,1000004]")).AsString(), Is.EqualTo("[0,1,1000000,1000001,1000002,1000003,1000004,6]"));
    }
}