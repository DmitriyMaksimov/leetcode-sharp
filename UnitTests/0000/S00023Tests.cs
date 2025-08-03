using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00023Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00023();
        var list = sut.MergeKLists([ListNode.Parse("[1,4,5]"), ListNode.Parse("[1,3,4]"), ListNode.Parse("[2,6]")]);
        var values = new List<int>();
        while (list != null)
        {
            values.Add(list.val);
            list = list.next;
        }

        Assert.That(values, Has.Count.EqualTo(8));
        Assert.That(values, Is.Ordered);
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
        Assert.That(sut.MergeKLists([(ListNode?) null]), Is.Null);
    }

    [Test]
    public void T4()
    {
        var sut = new S00023();
        Assert.That(sut.MergeKLists([]), Is.Null);
    }
}
