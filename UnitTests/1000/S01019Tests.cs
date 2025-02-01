using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01019Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01019();
        Assert.That(sut.NextLargerNodes(ListNode.Parse("[2,1,5]")), Is.EqualTo((int[]) [5, 5, 0]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01019();
        Assert.That(sut.NextLargerNodes(ListNode.Parse("[2,7,4,3,5]")), Is.EqualTo((int[]) [7, 0, 5, 5, 0]));
    }
}
