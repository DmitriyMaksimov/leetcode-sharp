using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00023Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00023();
        var list = sut.MergeKLists(new[] {ListNode.Parse("[1,4,5]"), ListNode.Parse("[1,3,4]"), ListNode.Parse("[2,6]")});
        var values = new List<int>();
        while (list != null)
        {
            values.Add(list.val);
            list = list.next;
        }

        values.Should().HaveCount(8);
        values.Should().BeInAscendingOrder();
    }

    [Test]
    public void T2()
    {
        var sut = new S00023();
        Assert.That(sut.MergeKLists(null), Is.Null);
    }

    [Test]
    public void T3()
    {
        var sut = new S00023();
        Assert.That(sut.MergeKLists(new [] {(ListNode?) null}), Is.Null);
    }

    [Test]
    public void T4()
    {
        var sut = new S00023();
        Assert.That(sut.MergeKLists(Array.Empty<ListNode?>()), Is.Null);
    }
}