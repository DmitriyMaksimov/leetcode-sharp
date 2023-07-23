using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00876Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S00876();

        sut.MiddleNode(ListNode.Parse("[1,2,3,4,5]")!).val.Should().Be(3);
    }

    [Test]
    public void Test2()
    {
        var sut = new S00876();

        sut.MiddleNode(ListNode.Parse("[1,2,3,4,5,6]")!).val.Should().Be(4);
    }
}