using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03217Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03217();
        sut.ModifiedList([1, 2, 3], ListNode.Parse("[1,2,3,4,5]")).Should().BeEquivalentTo(ListNode.Parse("[4,5]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03217();
        sut.ModifiedList([1], ListNode.Parse("[1,2,1,2,1,2]")).Should().BeEquivalentTo(ListNode.Parse("[2,2,2]"));
    }

    [Test]
    public void T3()
    {
        var sut = new S03217();
        sut.ModifiedList([5], ListNode.Parse("[1,2,3,4]")).Should().BeEquivalentTo(ListNode.Parse("[1,2,3,4]"));
    }
}
