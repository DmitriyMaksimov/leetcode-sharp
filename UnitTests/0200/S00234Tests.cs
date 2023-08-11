using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00234Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00234();
        sut.IsPalindrome(ListNode.Parse("[1,2,2,1]")).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00234();
        sut.IsPalindrome(ListNode.Parse("[1,2]")).Should().BeFalse();
    }
}