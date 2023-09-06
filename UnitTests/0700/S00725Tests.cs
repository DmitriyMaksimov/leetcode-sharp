using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00725Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00725();
        sut.SplitListToParts(ListNode.Parse("[1,2,3]"), 5).Should().BeEquivalentTo(new[]
            {
                ListNode.Parse("[1]"),
                ListNode.Parse("[2]"),
                ListNode.Parse("[3]"),
                null,
                null
            }
        );
    }

    [Test]
    public void T2()
    {
        var sut = new S00725();
        sut.SplitListToParts(ListNode.Parse("[1,2,3,4,5,6,7,8,9,10]"), 3).Should().BeEquivalentTo(new[]
            {
                ListNode.Parse("[1,2,3,4]"),
                ListNode.Parse("[5,6,7]"),
                ListNode.Parse("[8,9,10]"),
            }
        );
    }
}