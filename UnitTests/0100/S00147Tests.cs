using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00147Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00147();
        sut.InsertionSortList(ListNode.Parse("[4,2,1,3]")).Should().BeEquivalentTo(ListNode.Parse("[1,2,3,4]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00147();
        sut.InsertionSortList(ListNode.Parse("[-1,5,3,4,0]")).Should().BeEquivalentTo(ListNode.Parse("[-1,0,3,4,5]"));
    }
}
