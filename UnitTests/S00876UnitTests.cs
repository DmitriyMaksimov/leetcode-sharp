using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00876UnitTests
{
    [Test]
    public void Test1()
    {
        var sut = new S00876();

        var n5 = new S00876.ListNode(5);
        var n4 = new S00876.ListNode(4, n5);
        var n3 = new S00876.ListNode(3, n4);
        var n2 = new S00876.ListNode(2, n3);
        var n1 = new S00876.ListNode(1, n2);
        sut.MiddleNode(n1).val.Should().Be(3);
    }

    [Test]
    public void Test2()
    {
        var sut = new S00876();

        var n6 = new S00876.ListNode(6);
        var n5 = new S00876.ListNode(5, n6);
        var n4 = new S00876.ListNode(4, n5);
        var n3 = new S00876.ListNode(3, n4);
        var n2 = new S00876.ListNode(2, n3);
        var n1 = new S00876.ListNode(1, n2);
        sut.MiddleNode(n1).val.Should().Be(4);
    }
}