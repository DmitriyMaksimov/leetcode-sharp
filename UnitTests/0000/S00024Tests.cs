using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00024Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00024();
        ListNode.ToString(sut.SwapPairs(ListNode.Parse("[1,2,3,4]"))).Should().Be("[2,1,4,3]");
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00024();
        ListNode.ToString(sut.SwapPairs(ListNode.Parse("[1]"))).Should().Be("[1]");
    }

    [Test]
    public void T3()
    {
        var sut = new S00024();
        ListNode.ToString(sut.SwapPairs(null)).Should().Be("[]");
    }
}