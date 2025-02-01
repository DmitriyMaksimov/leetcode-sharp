using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00021Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00021();
        Assert.That(sut.MergeTwoLists(ListNode.Parse("[1,2,4]"), ListNode.Parse("[1,3,4]")).AsString(), Is.EqualTo("[1,1,2,3,4,4]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00021();
        Assert.That(sut.MergeTwoLists(null, null), Is.Null);
    }
}